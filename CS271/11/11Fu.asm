; 	Yu Fu
; 	Lab 11
;	Input three integers, converts and manipulates them as floats, 
;	and then convert them back to intgers to be print out
; 	Then use the result of first part, to print the float number with 3 decimals
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
	; three intgers	
	InteOne	word 0
	InteTwo	word 0
	InteThree word 0
	;result
	ResFloat Real4   0.0
	ResRd Word 0
	ResTr Word 0
	DecimalPart Word 0
	;get the decimal part
	ThousandPart Real4 1000.0
	; msg
	InteOneMsg byte "Input your first integer > " , 0
	InteTwoMsg byte "Input your second integer > " , 0
	InteThreeMsg byte "Input your third integer > " , 0
	ResRdMsg byte "The Result Rounded is " , 0
	ResTrMsg byte "The Result Thruncated is " , 0
	DecimalMsg byte "The Result with 3 decimal is " , 0
	DotMsg byte "." , 0
;**************************************************************
.DATA?	; uninitialized variables
	ExitCRLF	byte 10 DUP (?)		; to read in a CR at end of progra

;**************************************************************
.CODE

Start:
	Invoke Main			; run the Main procedure
	Invoke ExitProcess,0		; exit the program

Main Proc
	;Part 1 - user three input integer get N1*N2/N3, save the result in Float, around number trunted number
		;input three intgers
		Get_Integer InteOneMsg,InteOne
		Get_Integer InteTwoMsg,InteTwo
		Get_Integer InteThreeMsg,InteThree
		Print_Text CRLF
		Print_Integer InteOne
		;push into st stack 
		FINIT	; initialize floating point unit
		FILD InteThree
		FILD InteTwo
		FILD InteOne
		FMUL ST(0),ST(1) ;st(0)=st(0)*st(1)	N1*N2
		FDIV ST(0),ST(2) ;st(0)=N1*N2/N3
		FST ResFloat	; save float
		FIST ResRd 		; save around from st0
			;save truncate numbe from st(0)
		MOV EAX , Offset ResTr  ; we will store the truncated vale at ResTr
	    BYTE 0DFH , 8	; reserve a byte of storage to hold a legal machine operation

	   	; print the result
	   	Print_Text CRLF
	   	Print_Text ResRdMsg
		Print_Integer ResRd
		Print_Text CRLF
		Print_Text ResTrMsg
		Print_Integer ResTr
		Print_Text CRLF
		 ;Part 2 -use the reslut of above to print the number with the first 3 digits of the decimal part
		;FINIT	; initialize floating point unit
		FLD ResFloat
		FILD ResTr
		FSUB	;ST(1) = ST(1) - ST(0) , pop Stack, ST(1) is now ST(0)
		FMUL ThousandPart ; decimal part * 1000.0
		MOV EAX , Offset DecimalPart  ; we will store the truncated vale at DecimalPart
	  	BYTE 0DFH , 8	; reserve a byte of storage to hold a legal machine operation
	    ;Print result
	  	Print_Text  DecimalMsg
	  	Print_Integer ResTr
	   	Print_Text DotMsg
	   	Print_Integer DecimalPart
     ; pause screen	
     	Print_Text TwoCRLFs		; print some blank lines
	Get_String ExitMsg , ExitCRLF	; pause the screen

	
	RET
Main EndP

End Start
