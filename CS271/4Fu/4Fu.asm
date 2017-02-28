; Yu Fu
;
; Lab 4, Loop function
;lab 4-1; read in two integer, and print out increasing order
;Lab4-2; Reads in three Integers and print out the largest
;Lab4-3; Reads in three Capital letters and print out the largest

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
	
	;lab 4-1; read in two integer, and print out increasing order
	LabMeg1 byte " Lab 4 -1: Get two integers, and print out in Increasing Order.",0
	IntMsg byte "Enter an integer> ",0
	IntOne word 0	; two integers
	IntTwo word 0
	IntMsgone byte "The numbers in Increasing order are ",0
	IntMsgtwo byte " and ",0
	Larger word 0
	Less word 0
	
	;Lab4-2; Reads in three Integers and print out the largest
	LabMeg2 byte " Lab 4 -2: Get three integers, and print out the Largest.",0
	FInt word 0; set three integers
	SInt word 0
	TInt word 0
	LargestInt word 0; set largest
	FinishMsg byte "The Largest is > ",0
	
	;Lab4-3; Reads in three Capital letters and print out the largest
	LabMeg3 byte " Lab 4 -3: Get three Capital Letters, and print out the Largest.",0
	LOne BYTE "   ",0
	LTwo BYTE "   ",0
	LThree BYTE "   ",0
	OutChar BYTE " ",0ah,0dh,0
;**************************************************************
.DATA?	; uninitialized variables
	ExitCRLF	byte 10 DUP (?)		; to read in a CR at end of progra

;**************************************************************
.CODE

Start:
	Invoke Main			; run the Main procedure
	Invoke ExitProcess,0		; exit the program

Main Proc

	;lab 4-1; read in two integer, and print out increasing order
	Print_Text LabMeg1
	Print_Text CRLF
	Get_Integer IntMsg, IntOne	;get two Integer
	Get_Integer IntMsg, IntTwo	;
	
	XOR AX,AX ;AX zero
	mov AX,IntOne ; AX = IntOne
	mov BX,IntTwo ; BX = IntOne
	mov Larger,AX ;AX=Larger
	mov Less, BX  ;BX=Less
	
	cmp AX, BX	;compare AX BX
	jl LessThan	;if AX <BX, go to LessThan

	JMP Done; Jump to Done
	
	LessThan:
		mov Less ,AX	;AX=less
		mov Larger,BX	;BX=Larger
	Done:	;Print less and larger out
		Print_Text CRLF
		Print_Text IntMsgone
		Print_Integer Less
		Print_Text IntMsgtwo
		Print_Integer Larger
		Print_Text TwoCRLFs
		
	;Lab4-2; Reads in three Integers and print out the largest
	Print_Text LabMeg2
	Print_Text CRLF
	Get_Integer IntMsg,FInt ; get each Ints
	Get_Integer IntMsg,SInt
	Get_Integer IntMsg,TInt
	
	XOR AX,AX
	Mov AX,FInt; mov first Int to AX
	Mov LargestInt,AX ; get Fint = largest
	XOR AX,AX
	Mov AX,SInt; mov 2 Int to AX
	CMP AX,LargestInt;compare 
	JG SLarger; if AX > Largest
	JMP Thr
	
	Thr:
		XOR AX,AX
		Mov AX,TInt ;AX = Three Int
		CMP AX,LargestInt;compare two
		JG TLarger ; if AX>Largest
		JMP DonePrint
	
	SLarger: ; if AX > 
		Mov LargestInt,AX ; LargestInt = AX;
		JMP Thr
		
	TLarger:
		Mov LargestInt,AX
		JMP DonePrint
		
	DonePrint:	;Print out message
		Print_Text CRLF
		Print_Text FinishMsg
		Print_Integer LargestInt
		Print_Text TwoCRLFs			
	
	;Lab4-3; Reads in three Capital letters and print out the largest
	Print_Text LabMeg3
	Print_Text CRLF
	
	XOR AX,AX;RETURN ZERO
	XOR BX,BX
	XOR CX,CX
	
	Get_String  IntMsg, LOne	;get three letter	
	MOV AH,LOne
	
	Get_String  IntMsg,LTwo
	MOV BH,LTwo
	
	Get_String  IntMsg, LThree
	MOV CH,LThree
	
	CMP AH,BH
	JL First ;if al>bl go First
	CMP AH,CH
	JL SecondL ;bl>cl go secondL
	
	mov OutChar,AH
	JMP PrintDone
	
	First:
		CMP BH,CH
		JL FirstL ;al>cl go firstL
		mov OutChar,BH
		JMP PrintDone
	
	FirstL:		;Cl is the largest
		mov OutChar,CH
		JMP PrintDone
		
	SecondL:
		mov OutChar,CH
		JMP PrintDone
		
	PrintDone:
		Print_Text CRLF
		Print_Text FinishMsg
		Print_Text OutChar;Print
     ; pause screen	
     	Print_Text TwoCRLFs		; print some blank lines
	Get_String ExitMsg , ExitCRLF	; pause the screen

	RET
Main EndP

End Start
