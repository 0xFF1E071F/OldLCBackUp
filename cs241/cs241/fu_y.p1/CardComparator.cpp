// Yu Fu & William Foley
// p1 CARDS
// CS 241
#include "CardComparator.h"
bool CardComparatorHearts::operator()(const Card& first , const Card& second)
{  
  //each cards' suits and ranks location from array
  int firstSuitLoc =0;
  int secondSuitLoc=0;
  int firstRankLoc =0;
  int secondRankLoc=0;
  int firstLevel;	//compare Card level
  int secondLevel;
  for(int i =0;i<Card::MAX_SUITS;i++)	//check suits location
  {
    if (first.getSuit()==suit[i])
    {
      firstSuitLoc=i;
    }
    if (second.getSuit()==suit[i])
    {
      secondSuitLoc=i;
    }
  }
  for(int i =0;i<Card::MAX_RANKS;i++)	// check Ranks
  {
    if (first.getRank()==rank[i])
    {
      firstRankLoc=i;
    }
    if (second.getRank()==rank[i])
    {
      secondRankLoc=i;
    }
  }
  firstLevel = 100*firstSuitLoc + firstRankLoc;	// get CardLevel
  secondLevel =100*secondSuitLoc + secondRankLoc;
  if(first.getSuit()==Card::SPADES && first.getRank()==Card::QUEEN)	//specific (Spades Queen always go last)
  {
    firstLevel=999;	//largest
  }
  if (second.getSuit()==Card::SPADES && second.getRank()==Card::QUEEN)
  {
     secondLevel=999;//largest
  }  
  
  return firstLevel < secondLevel;
}
  
 bool CardComparatorSpades::operator()(const Card& first, const Card& second)
 {  
  //each cards' suits and ranks location from array
  int firstSuitLoc =0;
  int secondSuitLoc=0;
  int firstRankLoc =0;
  int secondRankLoc=0;
  int firstLevel;	//compare Card level
  int secondLevel;
  for(int i =0;i<Card::MAX_SUITS;i++)	//check suits location
  {
    if (first.getSuit()==suit[i])
    {
      firstSuitLoc=i;
    }
    if (second.getSuit()==suit[i])
    {
      secondSuitLoc=i;
    }
  }
  for(int i =0;i<Card::MAX_RANKS;i++)	// check Ranks
  {
    if (first.getRank()==rank[i])
    {
      firstRankLoc=i;
    }
    if (second.getRank()==rank[i])
    {
      secondRankLoc=i;
    }
  }
  firstLevel = 100*firstSuitLoc + firstRankLoc;	// get CardLevel
  secondLevel =100*secondSuitLoc + secondRankLoc;
 
  return firstLevel < secondLevel;
}  
  
bool CardComparatorGoFish::operator()(const Card& first, const Card& second)
{  
  //each cards' suits and ranks location from array
  int firstSuitLoc =0;
  int secondSuitLoc=0;
  int firstRankLoc =0;
  int secondRankLoc=0;
  int firstLevel;	//compare Card level
  int secondLevel;
  
  for(int i =0;i<Card::MAX_RANKS;i++)	//check ranks
  {
    if (first.getRank()==rank[i])
    {
      firstRankLoc=i;
    }
    if (second.getRank()==rank[i])
    {
      secondRankLoc=i;
    }
  }
  for(int i =0;i<Card::MAX_SUITS;i++)//check suits
  {
    if (first.getSuit()==suit[i])
    {
      firstSuitLoc=i;
    }
    if (second.getSuit()==suit[i])
	{
      secondSuitLoc=i;
    }
  }
  firstLevel = 10*firstRankLoc + firstSuitLoc;	// get CardLevel
  secondLevel =10*secondRankLoc + secondSuitLoc;
    
  return firstLevel < secondLevel;
}
          
Card::Suit CardComparatorHearts::suit[]={Card::CLUBS ,Card::DIAMONDS, Card::SPADES, Card::HEARTS};
Card::Rank CardComparatorHearts::rank[]={Card::TWO, Card::THREE, Card::FOUR,Card::FIVE, Card::SIX, Card::SEVEN, Card::EIGHT,Card::NINE, Card::TEN, Card::JACK, Card::QUEEN,Card:: KING, Card::ACE};
 
Card::Suit CardComparatorSpades::suit[]={Card::HEARTS ,Card::CLUBS, Card::DIAMONDS, Card::SPADES};
Card::Rank CardComparatorSpades::rank[]={Card::TWO, Card::THREE, Card::FOUR, Card::FIVE, Card::SIX, Card::SEVEN, Card::EIGHT,Card::NINE, Card::TEN, Card::JACK, Card::QUEEN,Card:: KING, Card::ACE};          

Card::Suit CardComparatorGoFish::suit[]={Card::CLUBS,Card::SPADES,Card::HEARTS,Card::DIAMONDS};
Card::Rank CardComparatorGoFish::rank[]={Card::ACE, Card::TWO, Card::THREE, Card::FOUR,Card::FIVE, Card::SIX, Card::SEVEN, Card::EIGHT,Card::NINE, Card::TEN, Card::JACK, Card::QUEEN,Card:: KING};
         