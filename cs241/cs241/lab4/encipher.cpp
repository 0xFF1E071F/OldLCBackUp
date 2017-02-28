//Will Foley & Ryan Fu
//Launches program to encipher a file

#include <iostream>
#include <string>
#include <stdio.h>      
#include <stdlib.h>
#include "encrypt.h"

using namespace std;

int main(int argc, char* argV[])
{	
	int seed = 1;
	int txt_file = 2;
	
	if (argc == 3)		//you need the name of the program, a seed and a file to encrypt
	{
		Encrypt e(atoi(argV[seed]), argV[txt_file]);
		e.encipher(); 
	}
	else
		cout << "You need to have a seed followed by a file you want to encrypt." << endl;
	
	
	return 0;
}