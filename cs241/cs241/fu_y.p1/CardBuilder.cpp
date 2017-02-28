// Yu Fu & William Foley
// p1 CARDS
// CS 241
#include "CardBuilder.h"
Card CardBuilder::buildCard(const std::string& cardString)
{
	switch(cardString[0])
	{
	case '2':
		rank=Card::TWO;
		break;
	case '3':
		rank=Card::THREE;
		break;	
	case '4':
		rank=Card::FOUR;
		break;	
	case '5':
		rank=Card::FIVE;
		break;	
	case '6':
		rank=Card::SIX;
		break;	
	case '7':
		rank=Card::SEVEN;
		break;	
	case '8':
		rank=Card::EIGHT;
		break;	
	case '9':
		rank=Card::NINE;
		break;	
	case 'T':
		rank=Card::TEN;
		break;	
	case 'J':
		rank=Card::JACK;
		break;	
	case 'Q':
		rank=Card::QUEEN;
		break;	
	case 'K':
		rank=Card::KING;
		break;	
	case 'A':
		rank=Card::ACE;
		break;
	default:
		rank=Card::NO_RANK;
		break;

		}

	switch(cardString[1])
	{
	case 'H':
		suit=HEARTS;
		break;
	case 'C':
		suit=CLUBS;
		break;
	case 'D':
		suit=DIAMONDS;
		break;
	case 'S':
		suit=SPADES;
		break;	
	default:
		suit=Card::NO_SUIT;
		break;	
	}
	
	Card newCard(suit,rank);
	return newCard;
}	
