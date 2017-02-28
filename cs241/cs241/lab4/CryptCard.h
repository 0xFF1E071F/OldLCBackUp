//Will Foley & Ryan 
//CryptCard Class 


#ifndef CRYPT_CARD_H
#define CRYPT_CARD_H

#include <ostream>

class CryptCard
{
public:
  enum Suit{HEARTS = 0, CLUBS, DIAMONDS, SPADES, NO_SUIT};
  enum Rank{ACE = 0, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, NO_RANK};
  const static int MAX_RANKS = 13;
  const static int MAX_SUITS = 4;
  // Number of cards in a deck
  const static int CARDS_PER_DECK = 52;
  
  static const int SUIT_OFFSET = 1;
  static const int RANK_OFFSET = 1;

private:
  Suit suit_;
  Rank rank_;
  
  static std::string *rank_symbols_;
  static char *suit_symbols_;
  
  static std::string * initRankSymbols();
  static char * initSuitSymbols();
  
public:
  CryptCard();
  CryptCard(Suit suit, Rank rank);
  virtual ~CryptCard(void);
  
  Suit getSuit() const;
  Rank getRank() const;

  // convert card to an integer by multiplying rank by suit
  int convertToInt();
  
  //Increment the rank using the standard formula, e.g., A->2, 2->3, 3->4, ..., Q->K.
  static void incrementRank(Rank& rank);
  
  friend std::ostream& operator << (std::ostream& os, const CryptCard& card);
};

#endif //CRYPT_CARD_H
