//Will Foley & Ryan Fu
//CS 241 Fall 2014
//driver program

#include <iostream>
#include <string>
#include "ConsoleInterface.h"

using namespace std;


int main()
{
	ConsoleInterface a;
	string play_again;
	do
	{
		a.initialize();		//will begin a game of Hangman
		do
		{
			cout << "Would you like to play again?  y - yes or n - no:";	
			cin >> play_again;
		}
		while(play_again != "n" && play_again != "y");
	}while (play_again != "n");	//will play again if the user wants to otherwise it will just close.
	


	return 0;
}

