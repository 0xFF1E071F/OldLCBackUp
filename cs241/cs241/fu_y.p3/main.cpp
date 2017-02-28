#include <iostream>
#include "KeyStream.h"
#include "decrypt.h"
using namespace std;
int main(int argc, char* argV[])
{
	decrypt a(atoi(argV[1]),argV[2]);
	a.decipher();
	return 0;
}