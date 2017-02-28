// Yu Fu & William Foley
// p1 CARDS
// CS 241
#ifndef HAND_H
#define HAND_H

#include "LCVector.h"
#include "CardComparatorIF.h"
#include "CardComparator.h"
#include "Card.h"
#include <iostream>
using namespace std;

class Hand{
 public:
  Hand (CardComparatorIF* mode);	//constructor
  void addCard(const Card& card);	//add new card
  void removeCard(const Card& card);	//remove current card
  size_t size();					//retrun size
  void print(ostream& out) const;// print out
 private:
  CardComparatorIF * sortMode_;
  LCVector<Card> handVector_;
};

inline
ostream& operator <<(ostream& out, const Hand& hand)
{
  //  print  all  
	hand.print(out);
	return out;
}

#endif /*HAND_H*/
