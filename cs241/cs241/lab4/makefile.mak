#Will Foley & Ryan Fu
CC = g++
CFLAGS = -g -Wall

all: qtest

qtest: test.o
	$(CC) $(CFLAGS) -o qtest test.o
test.o: test.cpp LCQueue.h
	$(CC) $(CFLAGS) -c test.cpp
clean:
	rm -f qtest *.o