//Console Interface functions 

#include "ConsoleInterface.h"

//gets the number of guesses you would like to have 
void ConsoleInterface::initialize()
{
	guesses_=0;
	string guesses;
	length_ = get_word_length();	//getting word length
	unsigned int i = 0;
	while(guesses_ <=  0)	//loop to make sure that the user enters in a number
	{
		do
		{
			cout << "Please enter in the number of guesses you would like to have: ";
			cin >> guesses;
			i = 0;
			char temp = guesses[i];
			while (isdigit(temp) && i < guesses.size()-1)	//check each character in the string for a digit
			{
				++i;
				temp = guesses[i];
			}
		}while (!(isdigit(guesses[i])));	//if the current character isn't a digit get a new one
		
		// CONVERTING STRING TO INT  //
		char* guess_char = new char[guesses.size()+1];		
		strcpy(guess_char, guesses.c_str());	
		guesses_ = atoi(guess_char);
		delete [] guess_char;
	}
	i = 0;

	play();		//plays a game
}

//plays a game of hangman
void ConsoleInterface::play()
{
	char var;
	do
	{
		cout << "Would you like to to see the number of possible words.  Enter y or n. ";
		cin >> var;
	}while (var != 'n' && var != 'y');
	Hangman game(guesses_, length_, words_, tolower(var));		//constructing a game of hangman 
	do 
	{
		game.print();		//outputs info to screen
		game.getLetter();	//getting a letter from the user
		game.chooseLargest();	//choose the largest family of words
		game.results();		//calculate the results with the largest family
	}while(!game.gameComplete());
	
	words_.erase(words_.begin(), words_.end());
}

//getting the length of the word the user wants to guess and creates a list of words
int ConsoleInterface::get_word_length()
{
	string word;
	int size;
	ifstream file;
	string length;
	unsigned int i = 0;
	int lngt;
	do 
	{
		i = 0;
		file.open ("lexicon.txt");
		if (file.is_open())
		{
			cout << "Please enter in an acceptable word length: ";
			cin >> length;
			
			while(i < length.size() && isdigit(length[i]) )	//checking to make sure that the input is a number
			{
				++i;
			}
			if (i == length.size())
				--i;
			if (isdigit(length[i]))
			{
				//converting string to int
				char* guesses_char = new char[length.size()+1];		
				strcpy(guesses_char, length.c_str());	
				lngt = atoi(guesses_char);
				
				//this will go through the file of words and add any words of that length and push it into a vector
				while (file.good())
				{
					file >> word;
					size = word.size();
					if (size == lngt)
						words_.push_back(word);
				}
			}
		}
		file.close();			
	}while(!isdigit(length[i]) || words_.empty());	//while there is a non digit in the input or there are no words in the vector
	return lngt;
}
