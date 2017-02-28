; Yu Fu
;
; Lab2
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
	;Lab2-1
	LabMsgOne byte "This is Lab 2 - 1 : Enter Two Integer, It will give the Sum & Product",0
	FirstIntMsg byte "Enter the first integer >",0
	SecondIntMsg byte "Enter the first integer >",0
	SumMsg byte "Their sum is >",0
	ProductMsg byte "Their product is >",0
	IntegerOne word 0
	IntegerTwo word 0
	Sum word ?
	Product word ?
	;Lab2-3
	LabMsgTwo byte "This is Lab 2 - 2 : Enter Interger A,B,D,X to evaluae AX^2+BX+D",0
	AMsg byte "Enter the A >",0
	BMsg byte "Enter the B >",0
	DMsg byte "Enter the D >",0
	XMsg byte "Enter the X >",0
	IntA word 0
	IntB word 0
	IntD word 0
	IntX word 0
	IntAnswer word 0
	;Lab2-3
	LabMsgThree byte "This is Lab 2 - 3 : Enter two char, it will give a reversed what you type in",0
	CharMsg byte "Type in two chars that you want be reversed >",0
	TwoChars byte "    ",0
	Reversed byte 0
;**************************************************************
.DATA?	; uninitialized variables
	ExitCRLF	byte 10 DUP (?)		; to read in a CR at end of progra

;**************************************************************
.CODE

Start:
	Invoke Main			; run the Main procedure
	Invoke ExitProcess,0		; exit the program

Main Proc
	; lab 2 - 1
	Print_Text LabMsgOne
	Print_Text CRLF
	Get_Integer FirstIntMsg, IntegerOne
	Get_Integer SecondIntMsg, IntegerTwo
	mov AX,IntegerOne
	add AX,IntegerTwo
	mov Sum,AX
	;sum
	Print_Text SumMsg
	Print_Integer Sum
	Print_Text CRLF
	;product
	mov AX,IntegerOne
	IMul AX,IntegerTwo
	mov Product,AX
	Print_Text ProductMsg;Print
	Print_Integer Product
	Print_Text TwoCRLFs	;Print
	
	; lab 2 - 2
	Print_Text LabMsgTwo
	Print_Text CRLF
	;get A B D X
	Get_Integer AMsg, IntA
	Get_Integer BMsg, IntB
	Get_Integer DMsg, IntD
	Get_Integer XMsg, IntX	
	;GET B*X
	Mov AX, IntB
	IMul AX,IntX
	Mov IntAnswer,AX ;IntAnswer = B*X
	;GET A*X*X
	Mov BX, IntA
	IMul BX, IntX
	IMul BX, IntX
	Add IntAnswer,BX;IntAnswer = B*X+ A*X*X
	Mov CX,IntD
	Add IntAnswer,CX;IntAnswer = B*X+ A*X*X +D
	Print_Integer IntAnswer
	Print_Text TwoCRLFs	;Print IntAnswer
	
	; lab 2 - 3
	Print_Text LabMsgThree
	Print_Text CRLF
	Get_String CharMsg, TwoChars
	mov esi, OffSet TwoChars;TwoChars[0]=esi
	mov AL, [esi]		;esi[0]=AL
	mov esi, offset TwoChars +2;TwoChars[1]=esi
	add esi,1			;esi[0+1]
	mov BL, [esi]		;esi[1]= BL
	
	mov esi, offset TwoChars	;twoChar[0] = esi
	mov [esi],bl	;esi =bl
	mov esi,offset TwoChars + 2	;twoChar[1] = esi
	mov [esi],al	;esi =al
	Print_Text TwoChars;Print
	
	;end
     ; pause screen	
     	Print_Text TwoCRLFs		; print some blank lines
	Get_String ExitMsg , ExitCRLF	; pause the screen

	RET
Main EndP

End Start
