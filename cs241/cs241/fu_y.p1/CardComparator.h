// Yu Fu & William Foley
// p1 CARDS
// CS 241
#ifndef CARD_COMPARATOR_H
#define CARD_COMPARATOR_H

#include "CardComparatorIF.h"
#include "Card.h"
using namespace std;
class CardComparatorHearts: public CardComparatorIF{
 public:
  // returns true if the first card should be ordered before the second
	bool operator()(const Card& first,const Card& second);

	static Card::Rank rank[];
	static Card::Suit suit[];
};

class CardComparatorSpades: public CardComparatorIF{
 public:
	bool operator()(const Card& first,const Card& second);

	static Card::Rank rank[];
	static Card::Suit suit[];
};

class CardComparatorGoFish: public CardComparatorIF{
 public:
	bool operator()(const Card& first,const Card& second);
	static Card::Rank rank[];
	static Card::Suit suit[];
};

#endif	/*CARD_COMPARATOR_H*/
