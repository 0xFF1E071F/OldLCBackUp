; Yu Fu
; Lab 7
;Reads in a line of text, and determines if it is a palindrome
;
;The ConsoleIO include file contains the following macros:
;   1.	Print_Text  Txt
;   2.	Get_String  Prompt , Buffer
;   3.	Print_Integer  Integ
;   4.	Get_Integer Prompt , Integ
;	NOTE: the integer must be between -32,768 AND 32,767
;
;	where the variables must be defined as follows:
;		DATA  Txt  byte  " whatever you want" , 0
;		DATA  Prompt byte "whatever you want" , 0    
;		DATA  Integ word 0
;		DATA?  Buffer byte Num DUP(?)
;			and Num is an integer which is two more than 
;			the actual bytes you intend to enter (store)
;*************************************************************************
Include ConsoleIO.inc

.CONST  

;*************************************************************************
.DATA	; initialized variables
	; Note that strings must be terminated with a NULL character = 0
	; You can either use NULL (a built in constant), or type a 0
	
	ExitMsg  byte "Press Enter to Exit > " , 0
	CRLF  byte 0DH,0AH,0
	TwoCRLFs  byte 0DH,0AH,0DH,0AH,0
	; lab 7
	couts word 0		; couts for stack
	typeMsg byte "Input a line of text>  ",0
	NotPalinedromeMsg  byte "It is not a palindrome." , 0
	isPalinedromeMsg byte "It is a palindrome." , 0
;**************************************************************
.DATA?	; uninitialized variables
	ExitCRLF	byte 10 DUP (?)		; to read in a CR at end of progra
	Line Byte 23 DUP(?)
	
;**************************************************************
.CODE

Start:
	Invoke Main			; run the Main procedure
	Invoke ExitProcess,0		; exit the program

Main Proc

	; lab 7 
	;Reads in a line of test, and determines if it is a palindrome
	
	SetupStart:					; set up start, 
		Get_String typeMsg,Line	; get input
		Mov ESI, OFFSET Line	; set esi to input
		
	nextChar:
		XOR EAX,EAX			; zero eax
		Mov al,[ESI]		; mov esi char to al
		; check if the end of line
		; if end of line jump to setupCheck
		cmp al,0dh	
		JE setupCheck	
		cmp al,0ah
		JE setupCheck
		cmp al,0
		JE setupCheck	
		;if not end
		Push EAX			;push char in stack
		add couts,1			;numbers of char in stacks +1
		add ESI,1			;esi go next
		JMP nextChar  	 	; do again
		
	setupCheck:				;everything back to 0
		Mov ESI,0
		Mov ESI, OFFSET Line
		JMP Check			; jump to check
		
	Check:					; check each char from line and stack
		CMP couts,0			; last one in stack, 
		JE	isPalinedrome	; if end and everything same, jump isPalinedrome
		POP EAX				; pop top char from stack
		sub couts,1			; num char in stack  -1
		CMP	al,[ESI]		; compare two chars
		JNE NotPalinedrome	; if not same, jump NotPalinedrome
							; else continue
		add ESI,1       	; next char in line
		JMP Check			; check again
		
	NotPalinedrome:
		Print_Text NotPalinedromeMsg	;print not palinedrome
		JMP CleanStack
		
	isPalinedrome:
		Print_Text isPalinedromeMsg		;print it is palinedrome
		JMP CleanStack
     
    CleanStack:			; clean left in stack 
    	CMP couts,0		; if couts zero, nothing left
		JE DONE			; jump done
		pop EAX			; else pop stack
		sub couts,1		; couts -1
		JMP CleanStack	; do again
		
    DONE:	; finish
    ; pause screen	
     	Print_Text CRLF				; print some blank lines
	Get_String ExitMsg , ExitCRLF	; pause the screen

	RET
Main EndP

End Start
