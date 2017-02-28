// Yu Fu & William Foley
// p1 CARDS
// CS 241
#include "ConsoleInterface.h"

ConsoleInterface::ConsoleInterface(Hand* hand)
{
	hand_=hand;
}

bool ConsoleInterface::check(string input)
{
	bool result=false;	//set default bad input
	if (input.size()==3)
	{
		if (input[0]=='+'||input[0]=='-')
		{
			if (input[1]=='2'||input[1]=='3'||input[1]=='4'||input[1]=='5'||input[1]=='6'||input[1]=='7'||input[1]=='8'||input[1]=='9'||input[1]=='T'||input[1]=='Q'||input[1]=='K'||input[1]=='J'||input[1]=='A')
			{
				if (input[2]=='H'||input[2]=='C'||input[2]=='D'||input[2]=='S')
					result=true;
			}
		}
	}
	else if(input.size()==1)
	{
		if (input[0]=='p'||input[0]=='q')
		{
			result=true;
		}
	}
	return result;
}

void ConsoleInterface::start()
{
	cout<<"Program started!"<<endl;
	cout<<"Please use '+'addCard,'-'RemoveCard,'p'Print,'q'Quit:"<<endl;
	string input;
	bool exit =false;
	while(exit!=true)	//while do not exit
	{
		cin>>input;
		if(check(input))	//check input every time
		{
			CardBuilder newCardBuilder;
			string newString(input,1);	//copy Card input
			Card newCard(newCardBuilder.buildCard(newString).getSuit(),
						newCardBuilder.buildCard(newString).getRank());	//build impur to Card
			switch(input[0])	// choose commond
			{
				case 'q': //exit
					exit=true;
					break;	
				case '+':	// add a card
					hand_->addCard(newCard);
					break;
				case '-':	// remove a card
					hand_->removeCard(newCard);
					break;
				case 'p':	// remove a card
					cout << *hand_;
					break;
			}
		}
	}
}

