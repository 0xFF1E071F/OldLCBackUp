// Lab 2
// Yu Fu
// cs 142 - Dr. Ribler

#include "stringFunctions.h"

void rotateRight(char* stringToRotate, int nCharsToRotate)
{    
    int n;
    int length = strlen(stringToRotate);
    char* result = new char [length+1];

    for (int i =0; i <length; ++i)
    {
        if (i+nCharsToRotate > length-1)
            n =  i + nCharsToRotate - length;
        else if (i+nCharsToRotate <0)
            n=i + nCharsToRotate + length;
        else
            n=i+nCharsToRotate;

        result[n] = stringToRotate[i];
    }
     result[length]=0;

    for(int j = 0;j<length;++j)
            stringToRotate[j] = result[j];

     delete [] result;
}

char findSmallestChar(const char* string)
{
    int length = strlen(string);

    char smallest = string[0];

    for ( int i =0;i<length;++i)
        if(string[i] < smallest && string[i]>='a'&& string[i] <= 'z') // always change the smallest char
                                                                // and always find the smallest from a to z;
            smallest= string[i];   

    return smallest;
}


AlphabetizeString(char* stringToAlphabetize)
{
	int length = strlen(stringToAlphabetize);

}

void changeString(char* original,  const char* oldWord, const char* newWord, int originalSize)
{
    int length = strlen(original);
    int oldLength = strlen(oldWord);
    int newLength = strlen(newWord);
	int plcaeLength = newLength - oldLength;

    int i = 0;
	int o = 0;
    char* originalPtr = new char [originalSize];

    while (i!=length)					// loop untile scan to the orginal's last word
    {
        if (original[i] == oldWord[0])   // if we find first same word
        {
            for (int n =0; n<oldLength;++n)	// check next words are same as old?
			{
				if (original[i+n] == oldWord[n])	// if same
				{
					for (int m = 0; m < newLength+1; ++m)	//replace
						originalPtr[i+m+o] = newWord[m];  
				}   
			}
			o += plcaeLength;	// replace the length between new and old
			i += plcaeLength + 1; // repostion new place		
		} 

		else	// if not same just copy 
		{
			originalPtr[i+o] = original[i]; // copy. o is the length that new word added
			++i; // go to next word
		}
	}

	originalPtr[length+o] = 0;// last one is NULL

	int newLengthOriginalPtr = strlen(originalPtr);//new length

	for (int k=0;k<newLengthOriginalPtr;++k) // copyback
		original[k] = originalPtr[k];

	delete [] originalPtr; //delocated
}
