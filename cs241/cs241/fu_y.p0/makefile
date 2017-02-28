# Yu Fu - p0
# head
CC=g++
CFLAGS= -g -Wall

# special default Dependency
all:spaghetti


#all
spaghetti: print_it.o spaghetti_lottery.o generate.o 
	$(CC) $(CFLAGS) -o spaghetti print_it.o spaghetti_lottery.o generate.o

#data_structures
spaghetti_lottery.o:data_structures.h generate.h print_it.h spaghetti_lottery.cpp 
	$(CC) $(CFLAGS) -c spaghetti_lottery.cpp

#print_it
print_it.h:data_structures.h
print_it.o: print_it.h print_it.cpp 
	$(CC) $(CFLAGS) -c print_it.cpp

#generate
generate.h:data_structures.h
generate.o: generate.h generate.cpp 
	$(CC) $(CFLAGS) -c generate.cpp

#Clean
clean:
	rm -f spaghetti *.o
