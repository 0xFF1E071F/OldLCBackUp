; The following program works with an array of (upto) 10 integers-words.
;	Could work with more by changing the MaxElems statement:
;	Note: parameters (info passed into and out of the procedure are passed in Registers)
; Currently the user is alowed to fill the Array and then the program prints the array out.
;******************
; Yu Fu
; 1. adder proc, which find the sum of all number in array and print out, if no number in array, sum = 0
; 2. Largest proc, find the largest number in arrray and print it out, if no number in array, largest = 0
;******************
Include ConsoleIO.inc
.CONST  
     MaxElems = 10	; if want more than 10 then just change this number
;*************************************************************
.DATA	; initialized variables
	ExitMsg  byte "Press Enter to Exit > " , 0
	CRLF  byte 0DH,0AH,0
	TwoCRLFs  byte 0DH,0AH,0DH,0AH,0

	Array WORD MaxElems DUP(0)	; note use of constant
	NumInArray BYTE 0
	
	Sum word 0 ; the result of Adder proc
	SumMsg  byte "The Sum of numbers in array is > ",  0
	
	Largest_Num word 0 ; the result of Largest proc
	LargestMsg  byte "The Largest number in array is > ",  0
;**************************************************************
.DATA?	; uninitialized variables
	ExitCRLF	byte 10 DUP (?)		; to read in a CR at end of progra
;**************************************************************
.CODE
    Start:
	Invoke Main			; run the Main procedure
	Invoke ExitProcess,0		; exit the program
     Main Proc
  ; Fill the array with user input - The addresses of the Array and NumInArray are put on the stack
	MOV EAX , OffSet Array	; put address of array on stack
	PUSH EAX	
	MOV EAX , OffSet NumInArray	; put address of Number InArray on stack
	PUSH EAX
	CALL Fill_Array  

    ; Print array - The address of the Array and the NumInArray are put on the Stack
	MOV EAX , OffSet Array	; put address of array on stack
	PUSH EAX	
	MOVZX EAX , NumInArray	; put NumberInArray on stack
	PUSH EAX
	CALL Print_Array
	
	; adder proc- to get the sum of all numbers in array
	Mov EAX, OffSet Sum
	push EAX
	MOV EAX, OffSet Array
	Push EAX
	MOVZX EAX,NumInArray
	Push EAX
	CALL Adder

	; print Sum 
	Print_Text TwoCRLFs	; new line
	Print_Text SumMsg
	Print_Integer Sum

	; Largest proc- to get the largest number in array
	Mov EAX, OffSet Largest_Num
	push EAX
	Mov EAX, OffSet Array
	Push EAX
	MOVZX EAX, NumInArray
	Push EAX
	CALL Largest
	; print Largest number  
	Print_Text TwoCRLFs	; new line
	Print_Text LargestMsg
	Print_Integer Largest_Num
	
     	    ; pause screen	
     	Print_Text TwoCRLFs		; print some blank lines
	Get_String ExitMsg , ExitCRLF	; pause the screen

	    RET
     Main EndP
;*************************************************************
; This procedure gets up to maxElems positive integers from the user. 
; The user ends entering with a -1
; The address of the Array and the Address of NumInArray are on the stack
	Fill_Array  PROC
	.DATA
		InputPromptMsg BYTE "Enter an integer. Quit with -1 > " ,0
		InputInt	WORD  0
	.CODE
		PUSH EBP
		MOV EBP ,ESP
		PUSHAD
		
		; get array from stack (its address)
		MOV ESI , [EBP+12]	; address of array
		MOV  BX , 0	; there are 0 elements to start
		
	; add elemenst until user types -1 as long as there is room
     Input_Loop:
       	CMP BL , MaxElems
       	JL Get_Next_Int
       	JMP Done_Inputting	; array full so quit
       	
       	; room in array so get next integer from user
 	 Get_Next_Int:
		Get_Integer InputPromptMsg , InputInt	; read integer
		CMP InputInt , -1	; if ,= -1, quit
		JNE Put_In_Array	; else put in array
		
		; if here, user entered -1 so done inputting
		JMP Done_Inputting  ; quit
		
		; good integert (not -1) so put it in the array
     Put_In_Array:
		MOV  AX , InputInt	; move integer to register 
		MOV [ESI] , AX	; so can move to memory
		Add ESI , 2		; go to next address in array, word = 2 bytes
		Add BX , 1			; 1 more element in array
	       JMP Input_Loop		; go back and try again
	       
	      ; done inputting so return Number in array
	 Done_Inputting:	 
	 	MOV EAX , [EBP+8]	; address of NuberInArray
	 	MOV [EAX], BX		; BX = count, return to NumInArray	
	       
	     POPAD
	     POP EBP
  		 RET 8 
	Fill_Array ENDP
;*************************************************************
; This procedure prints out the array.
; The address of the Array and NumInArray are on the stack
	Print_Array PROC
	.DATA
		OutputInt WORD 0
		OutPutMsg BYTE "The elements of the array are:" , 0AH , 0DH ,0
		NoIntsMsg BYTE "No elements in array:" , 0AH , 0DH ,0
		BlankSpace BYTE "  " , 0
	.CODE
		PUSH EBP
		MOV EBP ,ESP
		PUSHAD
		; get input variables from Frame on Stack
		MOV ESI , [EBP+12]	; address of array
		MOV EAX , [EBP+8]	;EAX = number in array

		; check for empty array
		CMP EAX , 0  ; if 0, no elements in array and nothing to print
		JNE Print_Setup	; some things to print
			
		; if fall through to here., teh array is empty	
		Print_Text TwoCRLFs	; print some blank lines
		Print_Text NoIntsMsg	; array empty message
		JMP Done_Printing	; no elements in array

     Print_Setup:
		Print_Text TwoCRLFs	; skip some lines
		Print_Text OutPutMsg	; print output message

	; the following loop prints out the elements of the array     
     Print_Loop:
		MOV BX , [ESI]		; get next integer from array
		MOV OutputInt , BX		; move to variable to print out
		Print_Integer OutputInt	; print it
		Print_Text BlankSpace		; print a few spaces
		Add ESI , 2			; go to next address in array
		SUB EAX , 1			; one less thing to print
		CMP EAX , 0			; if EAX = 0 then have printed them all
		JNE Print_Loop
		; if EAX = 0 then we fall through to here and are done
		
     Done_Printing:
         POPAD
	     POP EBP
    	 RET 8
	Print_Array ENDP
	;*************************************************************
;*************************************************************
; This procedure add up to maxElems positive integers and give a sum
; The user ends entering with a -1
; The address of the Array ,NumInArray and address of Sum are on the stack
	Adder  PROC

	.CODE
		PUSH EBP
		MOV EBP ,ESP
		PUSHAD
		
		; get array from stack (its address)
		MOV ESI , [EBP+12]	; address of array
		MOV EBX , [EBP+8]	; EBX = NumInArray
		MOV EAX , [EBP+16]  ; address of Sum
		MOV CX , 0			; sum
		ADD_Start:
			CMP EBX, 0  		; if 0, no elements in array and nothing to add
			JE Sum_Done
			ADD CX,[ESI]	;add the number to SUM
			SUB EBX,1		; the left number to add -1
			Add ESI,2		; jump to next number in array
			JMP ADD_Start	; loop
		; Done
		Sum_Done:
			MOV [EAX], CX	; CX = sum of numbers, return to Sum	
			POPAD
	    	POP EBP
  		 	RET 12 	 	
	Adder ENDP
;*************************************************************
; This procedure find the Largest number in the array
; The user ends entering with a -1
; The address of the Array , and address of Largest are on the stack
	Largest  PROC
	.CODE
		PUSH EBP
		MOV EBP ,ESP
		PUSHAD
		
		; get array from stack (its address)	
		MOV EAX , [EBP+16]  ; address of Largest
		MOV ESI , [EBP+12]	; address of array
		MOV EBX , [EBP+8]	; EBX = NumInArray
		MOV CX , [ESI]		; Largest number = first number in array
		;start compare
		Compare_Start:
			CMP EBX, 0  	; if 0, no elements in array and nothing to compare
			JE Largest_Done
			CMP CX,[ESI]	; compare largest and the number in array
			JL find_Larger	; if find a larger one
			JMP Next_Number
			
		Next_Number:		; next number in array
			SUB EBX,1		; the left numbers -1
			Add ESI,2		; next number in array
			JMP Compare_Start	; compare again
			
		; find one larger number than current Largest
		find_Larger:
			Mov CX,[ESI]	;put the larger number in Largest
			JMP Next_Number
		
		; Done	
		Largest_Done:
			MOV [EAX], CX	; DX = largest number, return to Largest	
			POPAD
	    	POP EBP
  		 	RET 12 
  		 	
	Largest ENDP
;*************************************************************
     End Start