// stringFunction.cpp
// definions of stringFunction
// Yu Fu
// cs 142 - lab 1

#include "stringFunctions.h"

int stringLength (const char* string)
{    
    int length = 0;
    while (*string != 0)
    {
        ++length;
        ++string;
    }
    return length;
}

//change all oldvalue to newvalue in string
void changeAll(char* string, char oldValue, char newValue)
{
    while (*string !=0)
    {
        if (*string == oldValue)
        {
            *string = newValue;
        }
        ++string;
    }
}
// firstOp times secondOp and get result for char
void multiply( float* firstOp,  float* secondOp,  float* result, int n)
{
    for (int i=0; i< n;++i)
    {
        result[i] = firstOp[i]*secondOp[i];
		//cout<< result[i] <<endl;
    }
	// cout<< "there should be 10 40 90 160"<<endl;
}

// Copy one string to another 
int copyString( char* src, char* dst, int dstSize)
{
    int copyLength = 0;
	int srcLength =  (strlen(src));	// lengh of src
	
	if ( srcLength < dstSize)			// large Copy
	{
			while (*src !=0)
		{
			* dst = *src;
			++dst;++src;
			++copyLength;
		}
	}
	else                                // small copy
	{
		while ( copyLength < (dstSize-1) ) // dstsize should 1 larger than copysize
		{    
			*dst = *src;
			++dst;++src;
			++copyLength;
		}
	} 

	*dst = 0;	// null-terminator
    return copyLength;
}

void reverseString (char* original)
{
	int reverseLength = strlen(original);  // Find the length of the original
	char* reverse = new char [reverseLength+1];   // Allocate a char array of size length+1
	
	// Copy each of the individual characters from original
	// to the copy (include the null-terminator)
	
	for(int j = 0; j > reverseLength; j++)
	{
		int i = reverseLength;
		reverse[j] = original[i-j];
	}
	
	for ( int n = 0; n < reverseLength ; ++n)
		original[n]=reverse[n];

	delete [] reverse;
}

bool isPrefix( char* prefix,  char* string)
{
	const char *result  = strstr (string,prefix); // check string and prefix.. if string include prefix return 1, no return 0
	return result;
}