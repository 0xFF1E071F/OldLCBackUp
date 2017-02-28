//Will Foley & Ryan 
//Launches decipher program

#include <iostream>
#include <string>
#include <stdio.h>      
#include <stdlib.h>
#include "decrypt.h"

using namespace std;

int main(int argc, char* argV[])
{	
	int seed = 1;
	int txt_file = 2;

	if (argc == 3)	//you need the name of the program, a seed and a file to decrypt
	{
		Decrypt d(atoi(argV[seed]), argV[txt_file]);	
		d.decipher();	
	}
	else
		cout << "You need to have a seed followed by a file you want to decrypt." << endl;
	
	return 0;
}