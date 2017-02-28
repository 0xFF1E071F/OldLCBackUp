#ifndef KEYSTREAM_H
#define KEYSTREAM_H

#include <iostream>
#include <algorithm>
#include <stdlib.h>
#include "CryptCard.h"
#include "LCQueue.h"
#include "LCStack.h"

#include <vector>

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
  static CryptCard::Suit suits[];
  unsigned int firstKey();
private:
  //shuffeled deck of cards 
  vector<CryptCard> shuffled_deck_;
  
  LCQueue<CryptCard>* suit_;
  int clubs;
  int spades;
  int diamonds; 
  int hearts;
  
  LCStack<CryptCard> cards_;
  
  unsigned int first_key_;
};

#endif