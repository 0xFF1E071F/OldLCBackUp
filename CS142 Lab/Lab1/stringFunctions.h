// stringFunction.h
// String function file.
// Yu Fu
// cs 142 - lab 1

#include <iostream>
using namespace std;

// calculate the length of string
int stringLength (const char* string);

//change all oldvalue to newvalue in string
void changeAll(char* string, char oldValue, char newValue);
// firstOp times secondOp and get result for char
void multiply( float* firstOp,  float* secondOp,  float* result, int n);

// Copy one string to another 
int copyString( char* src, char* dst, int dstSize);

void reverseString (char* original);

bool isPrefix( char* prefix,  char* string);