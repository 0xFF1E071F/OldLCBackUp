# Yu Fu - p1
# head
CC=g++
CFLAGS= -g -Wall

all:Cards

#all
Cards: Hand.o Card.o CardComparator.o ConsoleInterface.o CardBuilder.o Cards.o
	$(CC) $(CFLAGS) -o Cards Hand.o Card.o CardComparator.o ConsoleInterface.o CardBuilder.o Cards.o

#Hand
Hand.h:LCVector.h 
Hand.o:Hand.h Hand.cpp 
	$(CC) $(CFLAGS) -c Hand.cpp
	
#Card
Card.o: Card.h Card.cpp 
	$(CC) $(CFLAGS) -c Card.cpp
	
#CardComparator
CardComparator.h: CardComparatorIF.h Card.h
CardComparator.o: CardComparator.h CardComparator.cpp
	$(CC) $(CFLAGS) -c CardComparator.cpp
	
#ConsoleInterface
ConsoleInterface.h:CardBuilder.h
ConsoleInterface.o: ConsoleInterface.h ConsoleInterface.cpp 
	$(CC) $(CFLAGS) -c ConsoleInterface.cpp
	
#CardBuilder	
CardBuilder.h: Card.h
CardBuilder.o: CardBuilder.h CardBuilder.cpp 
	$(CC) $(CFLAGS) -c CardBuilder.cpp
	
#main
Cards.o:CardComparator.h Hand.h ConsoleInterface.h Cards.cpp  
	$(CC) $(CFLAGS) -c Cards.cpp
	
#Clean
clean:
	rm -f Cards *.o
