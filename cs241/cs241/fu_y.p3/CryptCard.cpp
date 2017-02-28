#include "CryptCard.h"
#include <string>

using namespace std;

CryptCard::CryptCard() : suit_(NO_SUIT), rank_(NO_RANK){}

CryptCard::CryptCard(Suit suit, Rank rank) : suit_(suit), rank_(rank){}


CryptCard::~CryptCard(void){
  // nothing yet
}

CryptCard::Rank CryptCard::getRank() const{
  return rank_;
}

CryptCard::Suit CryptCard::getSuit() const{
  return suit_;
}

void CryptCard::incrementRank(Rank& rank){
  //rank = (Rank)(rank + 1);
  int higher_rank = static_cast<int>(rank) + 1;
  rank = static_cast<Rank>(higher_rank);
}

int CryptCard::convertToInt()
{
  int i_suit = static_cast<int>(suit_) + SUIT_OFFSET;
  int i_rank = static_cast<int>(rank_) + RANK_OFFSET;
  return (i_suit * i_rank);

}

ostream& operator << (ostream& os, const CryptCard& card){
  os << CryptCard::rank_symbols_[card.rank_] << CryptCard::suit_symbols_[card.suit_];
  return os;
}

char * CryptCard::initSuitSymbols(){
  char * dynTmp = new char[MAX_SUITS];
  dynTmp[HEARTS] = 'H';
  dynTmp[DIAMONDS] = 'D';
  dynTmp[CLUBS] = 'C';
  dynTmp[SPADES] = 'S';
  return dynTmp;
}

string * CryptCard::initRankSymbols(){
  const char * tmpRankSymbols[] = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
  string * dynTmp = new string[MAX_RANKS];
  for(int i = 0; i < MAX_RANKS; i++){
    dynTmp[i] = string(tmpRankSymbols[i]);
  }

  return dynTmp;
}

char * CryptCard::suit_symbols_ = CryptCard::initSuitSymbols();
string * CryptCard::rank_symbols_ = CryptCard::initRankSymbols();
