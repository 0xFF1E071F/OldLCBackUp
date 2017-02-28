// Lab 2
// Yu Fu
// cs 142 - Dr. Ribler

#include "stringFunctions.h"

int main()
{
	cout<< "------ 1 ------"<<endl;
    // Write the following functions that operate on strings
    char thingToRotate[] = "abcd";

    rotateRight(thingToRotate, 1);
    cout << thingToRotate << endl;    // prints “dabc”
    rotateRight(thingToRotate, -1);    
    cout << thingToRotate << endl;    // prints “abcd”
    rotateRight(thingToRotate, 2);     
    cout << thingToRotate << endl;    // prints “cdab”
    rotateRight(thingToRotate,2);   
    cout << thingToRotate << endl;    // prints “abcd”

	cout<< "------ 2 ------"<<endl;
    char* aplhaContent = "this is the sentence that is found a smallest char";
    cout<< AlphabetizeString (aplhaContent) << endl; // print smallest


	cout<< "------ 3 ------"<<endl;
    char* content = "qwerasdfzxcvtyuioplkjhgbnm";
    cout<<findSmallestChar(content)<<endl; 

	cout<< "------ 4 ------"<<endl;
    const int MAX_STRING_LENGTH = 256;
    char sentence[MAX_STRING_LENGTH] = "This is the sentence that is changed";
    cout<< sentence<<endl;
    char oldWord []  = "is";
    char newWord[] = "was";

    changeString(sentence, oldWord, newWord, MAX_STRING_LENGTH);

    cout << sentence << endl;  // This types “Thwas was the sentence that was changed.”

	cout<<""<<endl;
    system("pause");
}