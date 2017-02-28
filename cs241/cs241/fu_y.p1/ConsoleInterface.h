// Yu Fu & William Foley
// p1 CARDS
// CS 241
#ifndef CONSOLEINTERFACE_H
#define CONSOLEINTERFACE_H
#include <string>
#include <iostream>
#include "CardBuilder.h"
#include "CardComparatorIF.h"
#include "Hand.h"
using namespace std;
class ConsoleInterface
{
  // member data
 public:
  ConsoleInterface(Hand * hand);//constructor
  bool check(string input);	//check correct input
  void start();	//start running
private:
	Hand * hand_;
};

#endif /*CONSOLEINTERFACE_H*/
