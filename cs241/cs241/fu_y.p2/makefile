# Yu Fu - p2
# head
CC=g++
CFLAGS= -g -Wall

all:main

#all
main:  main.o UserCodeBreaker.o UserCodeMaker.o ConsoleInterface.o Mastermind.o ComputerCodeBreaker.o ComputerCodeMaker.o
	$(CC) $(CFLAGS) -o main main.o Mastermind.o UserCodeBreaker.o UserCodeMaker.o ConsoleInterface.o ComputerCodeBreaker.o ComputerCodeMaker.o

#UserCodeBreaker
UserCodeBreaker.h:CodeBreakerIF.h 
UserCodeBreaker.o:UserCodeBreaker.h UserCodeBreaker.cpp 
	$(CC) $(CFLAGS) -c UserCodeBreaker.cpp
	
#ComputerCodeBreaker	
ComputerCodeBreaker.h:CodeBreakerIF.h 
ComputerCodeBreaker.o:ComputerCodeBreaker.h ComputerCodeBreaker.cpp 
	$(CC) $(CFLAGS) -c ComputerCodeBreaker.cpp
	
#UserCodeMaker
UserCodeMaker.h: CodeMakerIF.h
UserCodeMaker.o: UserCodeMaker.h UserCodeMaker.cpp
	$(CC) $(CFLAGS) -c UserCodeMaker.cpp
#ComputerCodeMaker
ComputerCodeMaker.h: CodeMakerIF.h
ComputerCodeMaker.o: ComputerCodeMaker.h ComputerCodeMaker.cpp
	$(CC) $(CFLAGS) -c ComputerCodeMaker.cpp
	
#ConsoleInterface
ConsoleInterface.h:CodeBreakerIF.h CodeMakerIF.h UserCodeMaker.h UserCodeBreaker.h ComputerCodeBreaker.h
ConsoleInterface.o: ConsoleInterface.h ConsoleInterface.cpp 
	$(CC) $(CFLAGS) -c ConsoleInterface.cpp
	
#Mastermind
Mastermind.o: Mastermind.h Mastermind.cpp 
	$(CC) $(CFLAGS) -c Mastermind.cpp
	
#main
main.o:ConsoleInterface.h main.cpp  
	$(CC) $(CFLAGS) -c main.cpp
	
#Clean
clean:
	rm -f main *.o
