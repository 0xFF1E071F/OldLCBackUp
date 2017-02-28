# Yu Fu - p4
# head
CC=g++
CFLAGS= -g -Wall

all:main

#all
main:test.o 
	$(CC) $(CFLAGS) -o main test.o 

test.o:test.cpp LCMap.h 
	$(CC) $(CFLAGS) -c test.cpp		
#Clean
clean:
	rm -f main *.o
