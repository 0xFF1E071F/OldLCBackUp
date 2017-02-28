#include "KeyStream.h"

KeyStream::KeyStream(int seed)
{
//hearts, clubs, diamonds, and spades.
	
	//CryptCard card(suits[suit], CryptCard::ACE);

	clubs = 0;
	spades = 1;
	diamonds = 2;
	hearts = 3;
	srand(seed);
	CryptCard::Rank r = CryptCard::ACE;
	for (int suit = 0; suit < CryptCard::MAX_SUITS; ++suit)
	{
		r = CryptCard::ACE;
		for(int rank = 0; rank < CryptCard::MAX_RANKS; ++rank)
		{
			shuffled_deck_.push_back(CryptCard(suits[suit], r));
			CryptCard::incrementRank(r);
			
			
		}
	}
	
	//shuffle the deck seven times 
	for (int i = 0; i < 7; ++i)
		random_shuffle(shuffled_deck_.begin(), shuffled_deck_.end());
	/*for (size_t i = 0; i < shuffled_deck_.size(); ++i)
		cout << shuffled_deck_[i] << endl;	*/
	suit_ = new LCQueue<CryptCard>[CryptCard::MAX_SUITS];
	for (size_t i = 0; i < shuffled_deck_.size(); ++i)
	{
		if((shuffled_deck_[i]).getSuit() == CryptCard::CLUBS)
			suit_[clubs].push(shuffled_deck_[i]);
		if((shuffled_deck_[i]).getSuit() == CryptCard::SPADES)
			suit_[spades].push(shuffled_deck_[i]);
		if((shuffled_deck_[i]).getSuit() == CryptCard::DIAMONDS)
			suit_[diamonds].push(shuffled_deck_[i]);
		if((shuffled_deck_[i].getSuit()) == CryptCard::HEARTS)
			suit_[hearts].push(shuffled_deck_[i]);
	}
	first_key_ = -10;
	for(int i = 0; i < CryptCard::MAX_SUITS; ++i)
	{
		first_key_+=(suit_[i].front()).convertToInt();
	}
	
}
unsigned int KeyStream::firstKey()
{
	return first_key_;
}

unsigned int KeyStream::generateNextKey()
{
	//divide the cards into suit decks
	int key = -10;
	cards_.push(suit_[clubs].pop());
	suit_[clubs].push(cards_.pop());
	int index;
	int i = 0;
	if ((suit_[clubs].front()).getRank() == CryptCard::ACE)
	{
		while((suit_[i].front()).getRank() == CryptCard::ACE && i < CryptCard::MAX_SUITS)
		{
			if(i == clubs)
			{
				cards_.push(suit_[i+1].pop());
				suit_[i+1].push(cards_.pop());
			}
			else
			{
				index = i;
				if (index == hearts)
				{
					index=-1;
				}
				if (index+1 != clubs)
				{
					cards_.push(suit_[index+1].pop());
					suit_[index+1].push(cards_.pop());
				}
				while((suit_[i-1].front()).getRank() != (suit_[index+1].front()).getRank())
				{
					cards_.push(suit_[i-1].pop());	
				}
				while(cards_.size() != 0)
				{
					suit_[i-1].push(cards_.pop());
				}
			}
			++i;
		}
			i = 0;
	}
	for(int n = 0; n < CryptCard::MAX_SUITS; ++n)
	{
		key+=(suit_[n].front()).convertToInt();
	}
	return key;
}

CryptCard::Suit KeyStream::suits[] = {CryptCard::HEARTS, CryptCard::CLUBS, CryptCard::DIAMONDS, CryptCard::SPADES };

	
		//clubs spades diamonds hearts