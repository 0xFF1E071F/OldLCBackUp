; Yu Fu
;
; cs271 Lab 3 
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
	
	;Lab 3-1
	LabMsgOne byte "This is Lab 3 - 1 :",0
	TripHoursMsg byte "Enter the hours you drove > ",0
	TripSpeedMsg byte "Enter you speed > ",0
	TripHours word 0	;hours you drove
	TripSpeed word 0	;speed you drove
	TripMiles word 0	;hours*speed
	TripMsgOne byte "You drove ",0
	TripMsgTwo byte " Miles.",0
	;Lab 3-2
	LabMsgTwo byte "This is Lab 3 - 2 :",0
	RoomMsg byte "Pleast enter the square footage of the room > ",0
	GallonMsg byte "Pleast enter the square feet per gallon > ",0
	Room word 0	;room size
	Gallon word 0	;square feet per gallon
	Answer word 0	;room / gallon
	AnswerMsgOne byte "It will take ",0
	AnswerMsgTwo byte " gallons of paint.",0
	;lab 3-3
	LabMsgThr byte "This is Lab 3-3 :",0
	PenniesMsg byte "Please enter the number of pennies you have > ",0
	Pennies word 0	;pennies
	AnsCents word 0	;pennies / 100
	AnsDollors word 0;pennies % 100
	AnsMsgOne byte "You have ",0
	AnsMsgTwo byte " pennies.",0
	AnsMsgThr byte "This is ",0
	AnsMsgfor byte " dollars and ",0
	AnsMsgfiv byte " cents.",0
;**************************************************************
.DATA?	; uninitialized variables
	ExitCRLF	byte 10 DUP (?)		; to read in a CR at end of progra

;**************************************************************
.CODE

Start:
	Invoke Main			; run the Main procedure
	Invoke ExitProcess,0		; exit the program

Main Proc
	;lab 3-1
	Print_Text LabMsgOne ; print lab msg
	Print_Text CRLF		
	Get_Integer TripHoursMsg, TripHours	;get trip hours
	Get_Integer TripSpeedMsg, TripSpeed	;get trip speed
	
	mov AX, TripHours	;AX = TripHours
	imul AX, TripSpeed	;AX= AX * tripSpeed
	mov TripMiles, AX	;Miles = TripHours* TripSpeed = AX
	
	;Print result
	Print_Text TwoCRLFs	
	Print_Text TripMsgOne
	Print_Integer TripMiles	
	Print_Text TripMsgTwo
	Print_Text TwoCRLFs	
	
	;lab 3-2
	Print_Text LabMsgTwo ; print lab msg
	Print_Text CRLF	
	Get_Integer RoomMsg,Room	;get Suqare of Rooms
	Get_Integer GallonMsg,Gallon;get Suqare of Gallons
	
	XOR AX,AX ; AX = 0
	mov AX,Room	; AX = room size
	mov DX,0	; this necesary
	mov BX,Gallon;BX = gallon per feet
	DIV BX	;(DX:AX)/BX
	ADD AX,1; AX+1 = quotient +1
	mov Answer,AX ;Answer = AX
	
	;print answer
	Print_Text TwoCRLFs	
	Print_Text AnswerMsgOne
	Print_Integer Answer	
	Print_Text AnswerMsgTwo
	Print_Text TwoCRLFs	
 
	;lab 3-3
	Print_Text LabMsgThr ; print lab msg
	Print_Text CRLF
	Get_Integer PenniesMsg,Pennies
	
	mov AX,Pennies;AX = Pennies
	mov DX,0	; DX =0
	mov BX,100;BX =100, which is 1dollor =100cents
	DIV BX	;DX:AX/BX
	mov AnsCents,DX;DX remender
	mov AnsDollors,AX;AX = quioter
	
	;print answer
	Print_Text TwoCRLFs	
	Print_Text AnsMsgOne
	Print_Integer Pennies	
	Print_Text AnsMsgTwo
	Print_Text CRLF
	Print_Text AnsMsgThr
	Print_Integer AnsDollors
	Print_Text AnsMsgfor
	Print_Integer AnsCents
	Print_Text AnsMsgfiv
	
     ; pause screen	
     	Print_Text TwoCRLFs		; print some blank lines
	Get_String ExitMsg , ExitCRLF	; pause the screen

	RET
Main EndP

End Start
