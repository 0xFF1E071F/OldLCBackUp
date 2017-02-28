// Yu Fu & William Foley
// p1 CARDS
// CS 241
#include <iostream>
#include "CardComparator.h"
#include "Hand.h"
#include "ConsoleInterface.h"
#include <string>
#include <stdio.h>
#include <string.h>
using namespace std;

int main(int argc, char*argv[])
{
	string argvString (argv[1]);
	if (argvString=="--hearts")
	{
		CardComparatorHearts * cmpHearts = new CardComparatorHearts();
		CardComparatorIF * cmp; 
		cmp = cmpHearts;
		Hand * hand = new Hand(cmp);
		Hand * newhand;
		newhand = hand;
		ConsoleInterface console(newhand);
		console.start();
	}
	else if (argvString=="--spades")
	{
		CardComparatorSpades * cmpSpades = new CardComparatorSpades();
		CardComparatorIF * cmp; 
		cmp= cmpSpades;
		Hand * hand = new Hand(cmp);
		Hand * newhand;
		newhand = hand;
		ConsoleInterface console(newhand);
		console.start();
	}
	else if (argvString=="--gofish")
	{
		CardComparatorGoFish * cmpGoFish = new CardComparatorGoFish();
		CardComparatorIF *cmp; 
		cmp = cmpGoFish;
		Hand * hand = new Hand(cmp);
		Hand * newhand;
		newhand = hand;
		ConsoleInterface console(newhand);
		console.start();
	}
	else {
		cout<<argv[1]<<endl;
		cout<<"Please type in correct mode name in lower case --hearts/--spades/--gofish"<<endl;
	}
}
