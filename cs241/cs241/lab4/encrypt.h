//Will Foley & Ryan Fu
//encrypt class

#ifndef ENCRYPT_H
#define ENCRYPT_H

#include <fstream>
#include <string>
#include <stdio.h>      
#include <stdlib.h>
#include "KeyStream.h"

using namespace std;

class Encrypt
{
public:
	const static int ASCII_RANGE = 128;
	Encrypt(int seed, char* file);
	void encipher();
private:
	char* file_;
	int seed_;
	
};
#endif