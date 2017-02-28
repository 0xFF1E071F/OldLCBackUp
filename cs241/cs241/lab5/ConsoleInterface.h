//Will Foley & Ryan Fu
//Console Interface header file
//controls the game of hangman and sets it up

#ifndef	CONSOLEINTERFACE_H
#define CONSOLEINTERFACE_H

#include <iostream>
#include <fstream>
#include <string>
#include <stdio.h>
#include <ctype.h>
#include <cstdio>
#include <stdlib.h> 
#include <cstring>
#include <vector>
#include "Hangman.h"
using namespace std;

class ConsoleInterface
{
public:
	ConsoleInterface(){}
	void initialize();
	int get_word_length();
	void play();
private:
	vector<string> words_; //list of words to be passed into the hangman game
	int guesses_;
	int length_;
};

#endif
