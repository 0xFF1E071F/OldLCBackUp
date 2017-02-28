#ifndef DECRYPT_H
#define DECRYPT_H

#include <iostream>
#include <fstream>
#include <sstream>
#include <string>
#include "KeyStream.h"
using namespace std;

class decrypt{
private:
	int seed_;
	char* fileName_;
	const static int ASCII_RANGE=128;
public:
	decrypt(int seed, char* fileName);
	void decipher ();
};
#endif