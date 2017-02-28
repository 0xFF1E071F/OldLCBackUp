; This is the file c:\WinAsm\LobbApps\MyConsoleIO\MyConsole.inc
; that is used/needed with MyConsole.asm
; Include file for I/O
.386
.MODEL flat, stdcall
OPTION CASEMAP:NONE

Include windows.inc
Include kernel32.inc
Include masm32.inc
IncludeLib kernel32.lib
IncludeLib masm32.lib

Main		PROTO

;**************************************************************************
; This Macro outputs a line of text - To use it the form is:  
;	USE:					Print_Text   Message
;	VAR DECLARATION:	in DATA	Message byte " whatever you want" ,0	
Print_Text Macro txt:REQ
	PUSHAD		; save register
	Invoke StdOut,ADDR txt
	POPAD		; restore registers
EndM

;**************************************************************************
; This macro gives a prompt, and then reads the users response as a string
;	USE:					Get_Input Prompt , InPutBuffer
;	VAR DECLARATION:	in DATA		Prompt byte "whatever you want",0
;						in DATA?		InPutBuffer byte 100 DUP(?) 
Get_String Macro prompt:REQ,buffer:REQ
	PUSHAD		; save registers
	Invoke StdOut,ADDR prompt
	Invoke StdIn,ADDR buffer, LengthOf buffer
	POPAD		; restore registers
EndM
;**************************************************************************
; This macro gives a prompt, and then reads the users response as a string,
;	converts it to an integer, and returns the integer
;	USE:					Get_Integ Prompt , Integ
;	VAR DECLARATION:	in DATA		Prompt byte "whatever you want",0
;						in DATA		Integ word 0 
Get_Integer Macro prompt:REQ,Integ:REQ
    local InString
    .data?  
    	InString byte  8 DUP(?)
    .code
    	PUSHAD		; save registers
	Invoke StdOut,ADDR prompt
	Invoke StdIn,ADDR InString, LengthOf InString
	String_To_Integer InString , Integ  ; convert it
	POPAD		; restore registers
EndM
;**************************************************************************
; This macro receivess an integer (Integ), converts the digits to the
; corresponding characters and prints them out.
;	USE:	 Print_Integer SomeInteger
;	VAR DECLARATION:  DATA		Integ word 0 
Print_Integer Macro SomeInteger:REQ
    local	StringInteger	; the binary integer as a string of char
    .data
	StringInteger  byte 8 DUP(?)
    .code
    	PUSHAD		; save registers
	Integer_To_String SomeInteger , StringInteger ; convert it
	Invoke StdOut , ADDR StringInteger
	POPAD		; restore registers
EndM
;**************************************************************************
;  This macro gets a NULL terminated string of char String (between 0 and 9) 
;  and returns it converted to a binary integer in Integ
;	USE:  				String_To_Integer StringVar , IntegVar
;	VAR DECLARATIONS:    	in DATA?		StringVar byte 8 DUP(?)  
;						in DATA		IntegVar word 0 
String_To_Integer Macro String:REQ , Integ:REQ
    local Ten, Positive_Integer, Positive_Integer, No_More_Digits, Done
    .data 	
		Ten word 10 
    .code
    	PUSHAD		; save registers
	
	XOR AX , AX	; clear the register - AX will be the integer we are creating
	XOR	BX , BX	;	BX will be a flag for a negative integer
	XOR CX , CX	;	CL will be the next digit
	XOR DX , DX	;	DX will be used for division
	
	mov BL , 0		; BL will be a flag to tell if the integer is + or -. 0=+,1=-
	; get first digit in string
	mov esi , 0
	XOR CX , CX	; clear CX
	mov CL , String[esi]
	
	; check for minus sign
	CMP	CL , '-'		; see if it is a negative number
	JNE Positive_Integer	; if not leave flag BL = 0
	mov BL , 1 ;		; set flag for a negative number
	add esi , 1			; go on to next digit
	XOR CX , CX
	mov	CL , String[esi]	; get next digit
	
    Positive_Integer:
   	CMP CL , 0Dh		; see if end of string - carriage return
   	JE	No_More_Digits
   	CMP CL , 0Ah		; see if end of string - carriage return
   	JE	No_More_Digits
   	CMP CL , 0		; see if end of string - carriage return
   	JE	No_More_Digits

	; if here, a good digit
	sub   CL , 30h		; convert the char to its actual binary digit
	MUL Ten			; AX = AX * 10		
	ADD AX , CX
	
	; go on to next digit
	add esi , 1
	XOR CX , CX
	mov CL , String[esi]
	JMP Positive_Integer
	
    No_More_Digits:
    	; finally, if there was a leading minus sign, negate number
    	CMP	BL , 0	; if flag is 0 the positive
    	JE Done
    	Neg  AX		; negate the integer
    	
    Done: 
    	mov Integ , AX	; put the integer in CX in Integ to return it
    	
	POPAD		; restore registers
EndM

;**************************************************************************
;  This macro inputs a positive integer, Integ, and returns it converted to the 
;  corresponding string of characters in String
;	USE:				Integer_To_String Integ , String
;	VAR DECLATION:	in  DATA		Integ word 0
;					in  DATA?		String byte 8 DUP(?)
Integer_To_String Macro Integ:REQ , String:REQ
    local Non_Negative , Not_Zero , Next_Digit , Store_Digit 
    local	Set_Up_For_Next_Digit, Done_Converting_Integer
    .code
	PUSHAD			; save registers	
	XOR   AX , AX		; clear AX
	mov	esi , 0		; esi will be an index into the String Array
	
	mov  AX , Integ		; AX contains the integer to be converted
	mov	CX , 0		; CX will be a flag to not display leading zero's
	
	; check if integer is negative - if it is, store a - and negate the number
	cmp AX , 0
	JGE  Non_Negative
	mov String[esi] , '-'	; store a minus sign at beginning of string
	add esi , 1			; set up- for next char in string
	neg AX			; make integer non-negative
	
    Non_Negative:		; we are now at the positive part
    	; check if integer is 0 - if so store a zero and quit
    	cmp AX , 0			; see if it is zero
	JNE   Not_Zero		; if not go on to number
	add AL , 30h		; convert integer 0 to char 0
	mov String[esi] , AL	; if it is zero, store a zero and quit
	add esi , 1
	jmp Done_Converting_Integer
	
    Not_Zero:	; we now have a positive integer
    		; since the integer will be < 32,767 we will begin by looking
    		; for a digit in the 5th position by dividing by 10,000, and then work
    		; our way down to the units position
	mov	BX , 10000
	
    Next_Digit:
	cmp BX , 0		; when BX gets to zero we are done
	JZ Done_Converting_Integer
	
	mov  DX , 0	; divide BX into DX:AX so first clear DX
	div	BX		; quotient in AX , Remainder in DX
	add   AL , 30h	; but because of size, AH will be 0, AL is current digit
	
	; check for leading zeros
	CMP	CX , 0		; if CX = 0 then still looking for first non-zero digit
	JNE  Store_Digit	; beyond leading zeros so store the digit
	
	; if here then upto now have only seen leading zeros
	CMP AL , '0'	;  if we are still reading leading zeros, and this digit is a zero
	JE	Set_Up_For_Next_Digit	; do not store this zero
	; if here, we have our first non-zero digit
	mov	CX , 1	; set flag to note we are beyond all leading zeros
	
    Store_Digit:	
	mov  String[esi] , AL	; store digit
	add esi , 1			; set up for next position
	
    Set_Up_For_Next_Digit:
	push CX		; temporarily store CX flag
	mov AX , DX	; AX is remainder to be dealt with
	; reduce power of 10 in BX to find next digit
	push AX		; save AX since AX is automatically used in division
	mov  AX , BX	; want to divide BX by 10, but div uses AX
	mov CX , 10
	mov DX , 0	; divide CX into DX:AX
	div  CX		;	quotient in AX , remainder in DX 
	mov  BX , AX	; AX is old BX / 10
	pop AX		; restore remainder to be deat with to AX
	pop CX		; restore CX flag
	jmp Next_Digit

    Done_Converting_Integer:	; done, so store a termination Null
	mov String[esi] , 0
	
	POPAD	; restore registers
EndM