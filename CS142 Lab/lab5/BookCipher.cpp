#include "BookCipher.h"

#include <sstream>
#include <fstream>
#include <string>

int stringLength(char* theString)
{
	int length = 0;
	while(*theString != 0)
	{
		++theString;
		++length;
	}
	return length;
}
BookCipher::BookCipher()
{
	filename_;
	wordCount = 0;
}

BookCipher::~BookCipher()
{
	filename_;
	wordCount=0;
}

BookCipher::BookCipher (string& filename)
{
	filename_= filename;
	wordCount = 0;
}

int BookCipher::readKeyDocument(const string& fileName)
{
	// Read the declaration of independence
    ifstream inputFile (fileName);

	string nextString;

	// Read one word from the file

	// While there are still words in the file
	// Read the word and print it out.
	// Count the words in doi.
	wordCount = 0;
	while ( inputFile >> nextString)
	{
	  ++wordCount;
	}

	// After we are done reading we need to close the object.
	inputFile.close();

	// Allocate an array that is the right size
	documentWords = new string[wordCount];
	// Re-read the words into the array.

	ifstream inputForArray(fileName);
	for(int i=0;i<wordCount;i++)
	{
		inputForArray >> documentWords[i]; 
	}

	inputForArray.close();

	// Create a new file stream that make array of doi
	ofstream outputFile("doiAfter.txt");

	for(int i=0;i<wordCount;i++)
	{
		outputFile<<documentWords[i] << endl;
	}

	outputFile.close();

	return wordCount; // return the counts of words.
}

// inputFile to get number of location, and use read key document to return word
void BookCipher::decodeDocument(const string& inputFile, const string outputFile, 
						int wordOffset, int charOffset) 
{
	int nextInt;

	ifstream inputForArray(inputFile);
	ofstream output(outputFile);

	while(inputForArray >> nextInt)
	{
		int documentIndex =  nextInt - wordOffset;

		// read original file
        // Check to make sure that documentIndex is in the range [0,wordCount-1]

		if (documentIndex>= 0)
		{
			documentIndex = documentIndex%wordCount;
		}
		else if (documentIndex < 0)
		{
			documentIndex = documentIndex +wordCount;
		}

		int wordCharOffset = charOffset % documentWords[documentIndex].length();

		// The word that was used to encode this character is
		//. documentWords[documentIndex]
	
		cout<< documentWords[documentIndex][wordCharOffset]<<" ";
		output<< documentWords[documentIndex][wordCharOffset] << " ";
		// print out word from string location and char location
	}

	inputForArray.close();
	output.close();
	
}

// encode words, find specified word in document 
	// and return value ( the Document Index) 
	// which means the location of this word in this document
void BookCipher::encodeDocument(const string& inputFile, const string outputFile, 
								int wordOffset, int charOffset) 
{
	char nextWord;
	int wordIndex;
	int documentIndex;

	// open files
	ifstream input(inputFile); // the word  u want find in document, i use example "good job."
	ofstream output(outputFile); // out put result
	
	// until the last word we want check
	while (input >> nextWord)
	{
		if (wordOffset>= 0)	// set wordOffSet value
		{
			wordOffset = wordOffset % wordCount;
		}
		else if (wordOffset < 0)
		{
			wordOffset = wordOffset +wordCount;
		}

		int wordRandom = rand() % wordCount;         // random from 1 to last word

		documentIndex = wordRandom; // document location = word location - offset -1

		int wordCharOffSet = charOffset%documentWords[documentIndex].length();	// get location
		
		while (documentWords[documentIndex][wordCharOffSet] != nextWord) // if not same go to next
		{
			++documentIndex;
		}

		// get result, give the location
		cout << documentIndex+wordOffset << endl;
		documentWords[documentIndex] = "--"; // used ,Null

		output<< documentIndex+wordOffset <<" ";
	}
	//close files
	input.close();
	output.close();
}
