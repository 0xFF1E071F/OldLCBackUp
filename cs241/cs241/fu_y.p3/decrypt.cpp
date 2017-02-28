#include "decrypt.h"

decrypt::decrypt(int seed, char* fileName)
{ 
	seed_=seed;
	fileName_=fileName;
}

void decrypt::decipher()
{
	ifstream file;
	file.open (fileName_);
	KeyStream keys(seed_);
	unsigned int letter;
	unsigned int currentKey;
	if (!file.is_open())
	{
		cout<<"ERROR: File was not opened!"<<endl;
	}
	else
	{
		letter = file.get();
		currentKey=keys.firstKey();
		while(letter < currentKey)
		{
			letter+=ASCII_RANGE;
		}
		letter-=currentKey;
		letter%=ASCII_RANGE;
		cout<<(unsigned char)letter;
		letter = file.get();
		while (file.good())
		{
			currentKey=keys.generateNextKey();
			while(letter <currentKey)
			{
				letter+=ASCII_RANGE;
			}
			letter-=currentKey;
			letter%=ASCII_RANGE;
			cout<<(unsigned char)letter;
			letter = file.get();
		}
	}
	file.close();
}
