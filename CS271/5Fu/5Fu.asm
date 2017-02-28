; Yu Fu
;
; ;lab 5 compare function
; 1. read in numbers a and b,compare it with thrid number x, if a<x<b inranger, if not out range
; 2. sorted two read in string
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
	;lab 5-1, read in a and b. compare it with thrid number x, if a<x<b inranger, if not out range
	aMsg byte "Enter a > ",0
	bMsg byte "Enter b > ",0
	xMsg byte "Enter x > ",0
	inRange byte "The given number is in the range.",0
	outRange byte "The given numer is not in the range",0 
	a word 0
	b word 0
	x word 0
	;lab 5-2 compare two string and sorted
	W1 BYTE "    ",0
	W2 BYTE "    ",0
	W1Msg byte "Enter you fisrt Input > ",0
	W2Msg byte "Enter you second Input > ",0
	SPACE byte " followd by ",0
	RESULT byte "The Result is : ",0
;**************************************************************
.DATA?	; uninitialized variables
	ExitCRLF	byte 10 DUP (?)		; to read in a CR at end of progra

;**************************************************************
.CODE

Start:
	Invoke Main			; run the Main procedure
	Invoke ExitProcess,0		; exit the program

Main Proc
	
	; lab 5-1
	;get three number
	Get_Integer aMsg,a
	Get_Integer bMsg,b
	Get_Integer xMsg,x	
	Mov AX,a	; move them into memory
	Mov BX,b
	Mov CX,x
	;compare a and x
	CMP AX,CX	;if a>x
	JG outOfRange
	CMP AX,CX;if a<X
	Jl nextCMP

	nextCMP: ;compare b and x
		CMP BX,CX ; if x<b
		JG	intheRange 
		CMP BX,CX	;if x>b
		JL  outOfRange
	
	intheRange: ;return if in range
		Print_Text inRange
		JMP EXIT
		
	outOfRange: ;return if out of range
		Print_Text outRange
		JMP EXIT
				
	EXIT:	;end loop
		Print_Text TwoCRLFs	
		
	;lab 5 -2 
	Get_String W1Msg,W1
	Get_String W2Msg,W2
			
	Mov ESI, OFFSET W1	
	Mov AX, [ESI]	; AX = W1 first letter
	Mov ESI, OFFSET W2
	Mov BX, [ESI]	;BX = W2 first letter
	Mov ESI, OFFSET W1 +2
	Mov CX,[ESI]	;CX = W1 Second letter
	Mov ESI, OFFSET W2 +2
	Mov DX,[ESI]	;DX = W2 Second letter
	
	CMP AX,BX
	JL inSorted	; AX<BX
	CMP AX,BX
	JG NotSored	;AX>BX
	CMP AX,BX
	JE inSorted		;AX=BX
	
	EQUAL:
		CMP CX,DX	;CX<DX
		JL inSorted
		CMP CX,DX	;CX>DX
		JG NotSored
		CMP CX,DX	;CX=DX
		JE inSorted
		
	inSorted:
		Print_Text RESULT
		Print_Text W1
		Print_Text SPACE
		Print_Text W2
		JMP DONE
		
	NotSored:
		Print_Text RESULT
		Print_Text W2
		Print_Text SPACE
		Print_Text W1
		JMP DONE
		
	DONE:	;exit
		Print_Text CRLF
		
     ; pause screen	
     	Print_Text TwoCRLFs		; print some blank lines
	Get_String ExitMsg , ExitCRLF	; pause the screen
	
	RET
Main EndP

End Start
