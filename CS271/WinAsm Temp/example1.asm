;Example 1
.386
.Model flat,stdcall
OPTION CASEMAP:NONE
Include windows.inc
Include kernel32.inc
Include masm32.inc
IncludeLib kernel32.lib
IncludeLib masm32.lib

Main PROTO

.CONST

.DATA   ; initialized storage
	Msg1 byte "Hi There", 0AH, 0DH, NULL

.DATA?
	Buffer byte 10 Dup(?)
;********************************************
.CODE
Start:
	Invoke Main
	Invoke ExitProcess,0

    Main Proc
	;Print a Hi There message to the screen
	Invoke StdOut , ADDR Msg1
	
	; issue a read command to stop the screen
	Invoke StdIn, ADDR Buffer , Lengthof Buffer

	RET ; to line after Invoke Main
     Main EndP

End Start

