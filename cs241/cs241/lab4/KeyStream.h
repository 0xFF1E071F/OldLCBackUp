//Will Foley & Ryan Fu
//KeyStream class

#ifndef KEYSTREAM_H
#define KEYSTREAM_H

#include <iostream>
#include <algorithm>
#include <stdlib.h>
#include <vector>
#include "CryptCard.h"
#include "LCQueue.h"
#include "LCStack.h"

using namespace std;

class KeyStream
{

public:
  
  KeyStream(int seed);
  virtual ~KeyStream(void)
  {
	delete [] suit_;
  }

  unsigned int generateNextKey(); //generates stream of integers
  unsigned int firstKey();		//access function to return the first key
  
  static CryptCard::Suit suits[]; 
private:
  //shuffled deck of cards 
  vector<CryptCard> shuffled_deck_;	
  
  //going to be an array of LCQueues to represent the suit decks
  LCQueue<CryptCard>* suit_;		
  
  //index locations of the suit decks
  int clubs;
  int spades;
  int diamonds; 
  int hearts;
  
  //stack for the algorithm
  LCStack<CryptCard> cards_;
  
  //first key
  unsigned int first_key_;
};

#endif

	
	