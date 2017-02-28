//Will Foley & Ryan Fu
//Encrypt class functions 

#include "encrypt.h"

//constructor
Encrypt::Encrypt(int seed, char* file)
{
	seed_ = seed;
	file_ = file;
}

//encipher a file
void Encrypt::encipher()
{	
	ifstream encr(file_);	//get the file

	if (encr.is_open())
	{
		unsigned int letter;	
		KeyStream keys(seed_);
		letter = encr.get();
		if (letter < ASCII_RANGE)
		{
			letter += keys.firstKey();
			letter %= ASCII_RANGE;
			cout << (unsigned char)letter;
		
			letter = encr.get();
			while(encr.good() && letter < ASCII_RANGE)
			{			
				letter += keys.generateNextKey();
				letter %= ASCII_RANGE;
				cout << (unsigned char)letter;
				letter = encr.get();
			}
		}
		if (!encr.eof())
		{
			if (letter >= ASCII_RANGE)
				cout << "Error character found that it is outside ASCII_RANGE" << endl;
		}
	}	
	encr.close();

}