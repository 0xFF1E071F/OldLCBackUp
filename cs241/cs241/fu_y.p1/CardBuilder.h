// Yu Fu & William Foley
// p1 CARDS
// CS 241
#ifndef CARDBUILDER_H
#define CARDBUILDER_H
#include "Card.h"

class CardBuilder : public Card{
 public:
	Card::Rank rank;
	Card::Suit suit;
	Card buildCard(const std::string& cardString);
};

#endif /*CARDBUILDER_H*/