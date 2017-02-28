//Will Foley & Ryan Fu
//Hangman functions 

#include "Hangman.h"

//constructor
Hangman::Hangman(int guesses, int length, vector<string> words, char var)
{
	guesses_ = guesses;
	length_ = length;
	string key;
	int i = 0;
	while (i < length_)		//creates the word being guessed and the first key consisting of - 's 
	{
		key.push_back('-');
		current_word_.push_back('-');
		++i;
	}
	current_key_ = key;
	possible_words_[key] = words;	//assigning the key to have the list of words as its value
	if (var != 'y')
		word_number = false;
	win_count_ = 0;		//used to determine if the user has won
}

//organizes the words into families
void Hangman::partitionWords()
{
	string key;
	LCMap<string, vector<string> > newMap;
	
	for (unsigned int x =0; x < (possible_words_[current_key_]).size(); ++x)
	{
		key = generateKey(x);	//generate key for word
		(newMap[key]).push_back((possible_words_[current_key_])[x]); //add that the word from the current list of words to the new one
		if (newKey(key))
			keys_.push_back(key);
	}
	possible_words_ = newMap;	//replace new word list with old one
	newMap.clear();
}

//checks to see if the key is a new key
bool Hangman::newKey(string key)
{
	size_t i = 0;
	string match;
	while (match != key && i < keys_.size())
	{
		match = keys_[i];
		++i;
	}
	return match != key;
}
		
//chooses largest family of words 
void Hangman::chooseLargest()
{
	partitionWords();	//first group them up
	int size;
	int max = 0;
	for (size_t i =0; i < keys_.size(); ++i)	//go through with key list and find the largest 
	{
		size = (possible_words_[(keys_[i])]).size();
		if (size > max)
		{
			current_key_ = keys_[i];
			max = size;
		}
	}
	keys_.erase(keys_.begin(), keys_.end());	//erase the list of keys 
}

//calculate results and make changes to word being guessed 
void Hangman::results()
{
	int changes = 0;
	for(unsigned int i = 0; i < current_word_.size(); ++i)
	{
		if ((((possible_words_[current_key_])[0])[i]) == current_letter_)	//if the letter being guessed is in the family
		{																		//of words 
			current_word_[i] = current_letter_;		//modify the word
			++changes;
			++win_count_;
		}
	}
	if (changes == 0)	//if there are no changes then subtract from guesses
		--guesses_;
}

//generates a key based on the location of the letter			
string Hangman::generateKey(int cursor)
{
	string key;
	for(int i = 0; i < length_; ++i)
	{
		if (((possible_words_[current_key_])[cursor])[i] == current_letter_)
			key.push_back(current_letter_);				//if the letter is in the word then put add it to the key
		else
			key.push_back('-');		//otherwise just add -
	}
	return key;
}

//gets a letter from the user
void Hangman::getLetter()
{
	int letter;
	size_t pos = string::npos;	//npos used to determine if the letter has been used 
	string input;
	do 
	{
		cout << "Please enter in a lower case letter: ";
		cin >> input;	
		letter = input[0];
		pos = letters_used_.find_first_of(input[0]);	//looking for the position of input character	
		if (pos != string::npos)		
			cout << "You have already used that letter." << endl;
	}while((letter < LWR_ASCII || letter > UPR_ASCII) || pos != string::npos || input.size() != 1);
								//while its a lowercase letter or hasnt been used or the input was greater than 1
											//get another
	current_letter_ = input[0];
	letters_used_.push_back(current_letter_);
	
}

//outputting to the screen
void Hangman::print()
{
	cout << "You have " << guesses_ << " remaining." << endl;		//guesses
	cout << "You have used these letters: ";
	for (size_t i = 0; i < letters_used_.size(); ++i)				//letters used 
		cout << letters_used_[i] << " ";
	cout << endl;
	cout << "word: " << current_word_ << endl;						//current word
	if (word_number)												//number of words used
		cout << "There are " << (possible_words_[current_key_]).size() << " possible words." << endl;	
	cout << endl;
}

//determines if game has been lost
bool Hangman::lost()
{
	if (guesses_ == 0)
	{
		cout << "You have lost.  The word was " << (possible_words_[current_key_])[0] << endl;
		keys_.erase(keys_.begin(), keys_.end());
		possible_words_.clear();
	}
	return guesses_ == 0;
}

//determines if game has been won
bool Hangman::won()
{

	if (win_count_ == length_)
	{
		cout << "You have won" << endl;
		cout << "The word was: " << current_word_ << endl;
	}
	return win_count_ == length_;
}

//determines if game is complete
bool Hangman::gameComplete()
{
	return won() || lost();
}