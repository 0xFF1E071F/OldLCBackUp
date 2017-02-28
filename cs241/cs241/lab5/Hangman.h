//Will Foley & Ryan Fu
//Hangman class

#ifndef HANGMAN_H
#define HANGMAN_H

#include <iostream>
#include <vector>
#include "LCMap.h"


using namespace std;

class Hangman
{
public:
	Hangman(int guesses, int length, vector<string> words, char var);
	void adjustWordList();
	void getLetter();
	void partitionWords();
	void chooseLargest();
	void results();
	string generateKey(int cursor);
	bool newKey(string key);
	bool lost();
	bool won();
	bool gameComplete();
	void print();
	
private:
	const static int LWR_ASCII = 97;
	const static int UPR_ASCII = 122;
	int guesses_;
	int length_;
	bool word_number;
	LCMap<string, vector<string> > possible_words_;   //map of family of words 
	vector<string> keys_;
	string letters_used_;
	string current_word_;
	string current_key_;
	char current_letter_;
	int win_count_;
};

#endif