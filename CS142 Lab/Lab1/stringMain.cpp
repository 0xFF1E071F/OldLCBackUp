// stringMain.cpp
// cs142 - lab1
// Yu Fu

#include "stringFunctions.h"

int main()
{
    // 1
	cout<< "------1-------"<<endl;
    char myString[] = "Test for lab#1" ;
    int length = stringLength(myString);
    cout << length << endl;     // This should print 14

    // 2
	cout<< "------2-------"<<endl;
    char testString [] = "Hello";
    changeAll(testString, 'l', 'x');
    cout << testString << endl; // This will print “Hexxo”

    // 3
	cout<< "------3-------"<<endl;
    int ARRAY_SIZE =4;
    float firstOperand [] = {1,2,3,4};
    float secondOperand [] = {10,20,30,40};
    float product[] = {0,0,0,0};
    multiply(firstOperand, secondOperand, product, ARRAY_SIZE); // prodoct will be 10 40 90 160

	for(int i=0;i<ARRAY_SIZE;i++)
	{
		cout << product[i] << endl;
	}
	
    // 4
	cout<<""<<endl;
	cout<< "------4-------"<<endl;
    const int MAX_STRING_SIZE = 256;
    char copy[MAX_STRING_SIZE];
    char testStringNew[] = "What's this?";
    int copyLength = copyString(testStringNew, copy, MAX_STRING_SIZE);
    cout <<endl<< copyLength << endl;   // This should print 12
    cout << copy << endl;         // This should print “What's this?”;

    const int SMALL_STRING_SIZE = 3;
    char smallCopy[SMALL_STRING_SIZE];
    copyLength = copyString(testStringNew, smallCopy, SMALL_STRING_SIZE);  
    cout << copyLength << endl;  // This should print 2
    cout << smallCopy << endl;   // This should print ‘Wh’

    // 5 
	cout<< "------5-------"<<endl;
	char className[] = "cs142";
	reverseString(className);
	cout << className << endl;  // This types “241sc”

	//6
	cout<< "------6-------"<<endl;
	char prefix[] = "abc";
	char stringA[] = "abcdefg";
	cout << "check two string A and B." <<endl;
	cout << "if B include or as same as A print 1, B not include A print 0." << endl;
	bool matchA = isPrefix(prefix, stringA);  // returns true =1
	cout<< matchA <<endl;

	char stringB[] = "abdefg";
	bool matchB = isPrefix(prefix, stringB);   // returns false = 0
	cout<< matchB <<endl;

	bool matchAB = isPrefix("ab", stringB);   // returns true =1
	cout<< matchAB <<endl;
 
    system("pause");
}