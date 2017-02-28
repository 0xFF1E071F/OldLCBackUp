//Will Foley & Ryan Fu
//decrypt functions

#include "decrypt.h"

//constructor
Decrypt::Decrypt(int seed, char* fileName)
{ 
	seed_=seed;
	fileName_=fileName;
}

//decipher a file
void Decrypt::decipher()
{
	ifstream file;
	file.open (fileName_);	//open a file
	KeyStream keys(seed_);	//initialize keystream
	
	unsigned int letter;
	unsigned int currentKey;
	
	if (!file.is_open())
	{
		cout<<"ERROR: File was not opened!"<<endl;
	}
	else
	{
		letter = file.get();
		if (letter < ASCII_RANGE)	//if the letter is less than the ASCII_RANGE
		{
			currentKey=keys.firstKey();	//get the first key
			while(letter < currentKey)	
			{
				letter+=ASCII_RANGE;
			}
			letter-=currentKey;
			letter%=ASCII_RANGE;
			cout<<(unsigned char)letter;
			letter = file.get();
			while (file.good() && letter < ASCII_RANGE)
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
		if(!file.eof())
		{
			if (letter >= ASCII_RANGE)
				cout << "Error character found that it is outside ASCII_RANGE" << endl;
		}
	}
	file.close();
}
