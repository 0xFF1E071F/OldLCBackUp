# Yu Fu - p3
# head
CC=g++
CFLAGS= -g -Wall

all:main

#all
main:main.o KeyStream.o decrypt.o CryptCard.o
	$(CC) $(CFLAGS) -o main main.o KeyStream.o decrypt.o CryptCard.o

#decrypt
decrypt.h:KeyStream.h
decrypt.o:decrypt.h decrypt.cpp
	$(CC) $(CFLAGS) -c decrypt.cpp	
#CryptCard
CryptCard.o:CryptCard.h CryptCard.cpp
	$(CC) $(CFLAGS) -c CryptCard.cpp	
#KeyStream
LCStack.h:Node.h
KeyStream.h:LCStack.h LCQueue.h CryptCard.h

main.o:main.cpp KeyStream.h decrypt.h
	$(CC) $(CFLAGS) -c main.cpp		
#Clean
clean:
	rm -f main *.o
