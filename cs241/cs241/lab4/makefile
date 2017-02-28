#Will Foley & Ryan Fu
CC = g++
CFLAGS = -g -Wall

all: encipher
all: decipher

#encode a file
encipher: encipher.o KeyStream.o CryptCard.o encrypt.o 
	$(CC) $(CFLAGS) -o encipher encipher.o KeyStream.o CryptCard.o encrypt.o
	
#decode a file
decipher: decipher.o KeyStream.o CryptCard.o decrypt.o 
	$(CC) $(CFLAGS) -o decipher decipher.o KeyStream.o CryptCard.o decrypt.o
	
decipher.o: decipher.cpp decrypt.h
	$(CC) $(CFLAGS) -c decipher.cpp
	
decrypt.o: decrypt.cpp decrypt.h
	$(CC) $(CFLAGS) -c decrypt.cpp
decrypt.h: KeyStream.h
	
encipher.o: encipher.cpp encrypt.h
	$(CC) $(CFLAGS) -c encipher.cpp

encrypt.h: KeyStream.h	
encrypt.o: encrypt.cpp encrypt.h
	$(CC) $(CFLAGS) -c encrypt.cpp

	
KeyStream.o: KeyStream.cpp KeyStream.h
	$(CC) $(CFLAGS) -c KeyStream.cpp
KeyStream.h: LCStack.h LCQueue.h CryptCard.h 

CryptCard.o: CryptCard.cpp CryptCard.h 
	$(CC) $(CFLAGS) -c CryptCard.cpp

clean:
	rm -f encipher decipher *.o

	