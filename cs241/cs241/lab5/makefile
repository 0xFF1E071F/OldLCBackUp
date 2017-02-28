#Will Foley & Ryan Fu

CC = g++
CFLAGS = -g -Wall

all: p4

p4: main.o ConsoleInterface.o Hangman.o
	$(CC) $(CFLAGS) -o p4 main.o ConsoleInterface.o Hangman.o
	
main.o: main.cpp
	$(CC) $(CFLAGS) -c main.cpp

ConsoleInterface.o: ConsoleInterface.cpp ConsoleInterface.h
	$(CC) $(CFLAGS) -c ConsoleInterface.cpp
ConsoleInterface.h: Hangman.h

Hangman.o: Hangman.cpp Hangman.h LCMap.h
	$(CC) $(CFLAGS) -c Hangman.cpp

clean:
	rm -f p4 *.o