#include <iostream>
#include <fstream>
#include <string>

using namespace std;
#include "BookCipher.h"

int main()
{
	string originFileName = "doi.txt";

	//decode example 
	string decodeFile = "beale2.txt"; // decode input file
	string decodeResult = "decodeResult.txt";// decode out file
	int decodeWordOffSet = 1;
	int decodeCharOffSet = 1;

	BookCipher a;
	a.readKeyDocument(originFileName);
	a.decodeDocument(decodeFile,decodeResult,decodeWordOffSet,decodeCharOffSet);
	
	//encode example 
	string encodeFileName = "encodeFile.txt"; // encode input file
												// good job in this file as example
	string encodeResult = "encodeResult.txt"; // encode out file
	int encodeWordOffSet = 1;
	int encodeCharOffSet = 1;

	BookCipher b;
	b.readKeyDocument(originFileName);
	b.encodeDocument(encodeFileName,encodeResult, encodeWordOffSet, encodeCharOffSet);

	system("pause");
}
