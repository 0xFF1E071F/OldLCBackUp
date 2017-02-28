; Yu Fu
; Lab 9
; 1.read in three integers, write a Adder Subroution to get the total 
; 2.read in two integers, use Subroutione Mixup to compare two numbers
; 	then add Larger number with smaller number, no change for smaller number, print them out
; 3.use adder subroution again , total = total + num 1 + num 2

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
	; lab 9
	firstMsg byte "1. Adder rountine: Total = num1 + num2 +num3",0
	secondMsg byte "2. Mixup rountine:for num1 and num2, larger Num += Smaller Num",0
	threeMsg byte "3.Adder rountine again: newTotal = Total +num1 + num2 ",0
	Num1Msg Byte "Input first number > ",0
	Num2Msg Byte "Input second number > ",0
	Num3Msg Byte "Input third number > ",0
	AnsMsg  Byte "Result is > ",0
	plusMsg byte " + ",0
	equalMsg byte " = ",0
	Num1Ans Byte "The first number is > ",0
	Num2Ans Byte "The sccond number is > ",0
	
	Num1 word 0
	Num2 word 0
	Num3 word 0
	Total word 0
	oldTotal word 0
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
	; lab 9
	; 1. adder subroutine to add 3 integer as total
	Get_Integer Num1Msg,Num1
	Get_Integer Num2Msg,Num2
	Get_Integer Num3Msg,Num3
	XOR EAX,EAX	; zero EAX
	;push three numbers in stack
	mov AX,Num1
	Push EAX
	mov AX,Num2
	Push EAX
	mov AX,Num3
	Push EAX
	mov EAX,offset Total;Push Total address in stack
	Push EAX
	
	Call Adder	; Adder subroutine to calculate
	; print out answer
	Print_Text CRLF	
	Print_Text firstMsg
	Print_Text CRLF	
	Print_Text AnsMsg	;print answer
	Print_Integer Num1
	Print_Text plusMsg	
	Print_Integer Num2
	Print_Text plusMsg	
	Print_Integer Num3
	Print_Text equalMsg
	Print_Integer Total
	Print_Text CRLF	
	Print_Text CRLF	
	; 2. Mixup subroutine to compare 2 numbers, add larger Number with smaller one, print them our
	;push two numbers in stack
	XOR EAX,EAX
	mov EAX,offset Num1
	Push EAX
	mov EAX,offset Num2
	Push EAX
	Call Mixup	; Mixup subrountine to calculate
	
	; print out answer
	Print_Text secondMsg
	Print_Text CRLF	
	Print_Text Num1Ans	;print num1
	Print_Integer Num1
	Print_Text CRLF	
	Print_Text Num2Ans	;print num2
	Print_Integer Num2
	Print_Text CRLF	
	; 3 adder subroutine again, add total = total + num1 + num2
	XOR EAX,EAX
	mov AX, Num1	;push num1
	Push EAX
	mov AX, Num2	;push num2
	Push EAX
	mov AX, Total	;push total
	mov oldTotal,AX ;set oldTotal = Total
	Push EAX
	mov EAX,offset Total	;push address of total
	Push EAX
	call Adder	; get new Total
	
	; print out answer
	Print_Text CRLF	
	Print_Text threeMsg
	Print_Text CRLF	
	Print_Text AnsMsg	;print answer
	Print_Integer Num1
	Print_Text plusMsg	
	Print_Integer Num2
	Print_Text plusMsg	
	Print_Integer oldTotal
	Print_Text equalMsg
	Print_Integer Total
	Print_Text CRLF	
	    ; pause screen	
     	Print_Text CRLF				; print some blank lines
	Get_String ExitMsg , ExitCRLF	; pause the screen

	RET
Main EndP

Adder Proc
	push EBP
	mov EBP, ESP	;set EBP pointer
	PUSHAD	;store all 
	
	mov AX,[EBP+20]	; first num
	mov BX,[EBP+16]	; second num
	mov CX,[EBP+12]	; third num
	
	;add these three numbers
	Add AX,BX
	Add AX,CX	
	Mov EBX,[EBP+8]		; EBX = address of total
	Mov [EBX], AX		; total = AX
	POPAD	;restore all 
	POP EBP
	RET 16 ; return four pushed before, so 4*4 =16a
Adder EndP	

Mixup Proc
	push EBP
	mov EBP, ESP	;set EBP pointer
	PUSHAD	;store all 

	mov EAX,[EBP+12]	; first num	address
	mov EBX,[EBP+8]		; second num address

	mov CX, [EAX]		; ECX = num1
	mov DX, [EBX]		; EDX = num2
	
	CMP CX,DX			; compare two numbers
	JL	firstSmaller
	ADD [EAX],DX		;num1+=num2
	JMP Done
	
firstSmaller:	; if num1 < num2
	ADD [EBX],CX	; num2 +=num1
	JMP Done
Done:
	POPAD	;restore all 
	POP EBP
	RET 8 ; return four pushed before

Mixup EndP	
End Start
