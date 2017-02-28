#pragma once
#include <iostream>
using namespace std;

class BookCipher
{
public:
	BookCipher();
	BookCipher (string& filename);
	~BookCipher();
	// Read and store the words in the key document.  Return the total number of words.
	// save the result in KeyDocument.txt and return total numbers of words
	int readKeyDocument(const string& fileName);

	// Decode a document
	// Read the number in the inputFile and write the text to the outputFile.  The wordOffset provides the word 
	// to start counting from.  The charOffset provides the letter to use for each word (e.g., 0 for 1st letter,  1 for //2nd etc.)   If it is not possible to decode a letter, write a question mark.
	void decodeDocument(const string& inputFile, const string outputFile, 
						int wordOffset, int charOffset);

	// Encode a document
	void encodeDocument(const string& inputFile, const string outputFile, 
						int wordOffset, int charOffset);

private:
	string filename_;
    int wordCount;
	string* documentWords;

};
