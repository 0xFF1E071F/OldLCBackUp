; Yu Fu
; Lab 6
; Evaluate the polynomial 2x^2 -3x+4 at several different points 
; user should type X value,step value and end value
; x cannnot larger than end value
; this program will show the step from beginning to end  automaticly for each x
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
	; lab 6 Evaluate the polynomial 2x^2-3x+4 at several different points, x = beginning value
	; x + step value each, and x cannnot larger than end vlaue
	; this program will show he step from beginning to end 
	StartMsg byte "Type in your Start x value > ",0
	StepMsg byte "Type in your Step value > ",0
	EndMsg byte "Type in your End value > ",0
	StartMsgT byte "The Value of the polynomial at select points is: ",0
	XMsg byte "for x = ",0
	X word 0
	Step word 0
	EndValue word 0
	xAnswer word 0
	AnswerMsg byte "   Poly = ",0
;**************************************************************
.DATA?	; uninitialized variables
	ExitCRLF	byte 10 DUP (?)		; to read in a CR at end of progra

;**************************************************************
.CODE

Start:
	Invoke Main			; run the Main procedure
	Invoke ExitProcess,0		; exit the program

Main Proc

	; lab 6 Evaluate the polynomial 2x^2-3x+4 at several different points, x = beginning value
	; x + step value each, and x cannnot larger than end vlaue
	; this program will show he step from beginning to end 
	
	Get_Integer StartMsg,X	;get start value
	Get_Integer EndMsg,EndValue	;get end value
	Get_Integer StepMsg,Step;get step value

	mov DX,X
	Print_Text StartMsgT	;start msg
	Print_Text CRLF
	
	Begin:				; beginning of calculation
		Mov AX,DX		; put new DX to AX
		Mov BX,DX		;               BX
		Mov CX,4		; CX always be 4
		CMP AX,EndValue	; Compare if out of range
		JG outOfRange	; if out of range jump to exit
		Print_Text XMsg	
		Print_Integer DX
		
		IMul AX,BX		; x^2
		IMul AX,2		; 2*x^2
		IMul BX,-3		; x*(-3)
		Add AX ,BX		; 2x^2-3x
		ADD AX,4		; 2x^2-3x+4
		ADD DX,Step		; new start x = old x + Step value
			
		Mov xAnswer, AX		; move to answer
		Print_Text AnswerMsg	;print answer
		Print_Integer xAnswer
		Print_Text CRLF
		JMP Begin ;jump back to beginning
	outOfRange: ;exit
     ; pause screen	
     	Print_Text CRLF		; print some blank lines
	Get_String ExitMsg , ExitCRLF	; pause the screen

	RET
Main EndP

End Start
