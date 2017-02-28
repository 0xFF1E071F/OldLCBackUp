//Will Foley & Ryan Fu
//functions for KeyStream

#include "KeyStream.h"

//constructor and initializing the suit decks
KeyStream::KeyStream(int seed)
{
	clubs = 0;
	spades = 1;
	diamonds = 2;
	hearts = 3;
	int shuffle_count = 7;
	
	srand(seed);	//prompting srand with the seed for the random shuffle
	
	CryptCard::Rank r = CryptCard::ACE;
	
	//creates a deck of cards to be snuffled
	for (int suit = 0; suit < CryptCard::MAX_SUITS; ++suit)	//we used an array of suits in the order we needed them to be	
	{																//scroll to the bottom to look at the array
		r = CryptCard::ACE;
		for(int rank = 0; rank < CryptCard::MAX_RANKS; ++rank)
		{
			shuffled_deck_.push_back(CryptCard(suits[suit], r));
			CryptCard::incrementRank(r);	//increase the rank by one
		}
	}
	
	//shuffle the deck seven times 
	for (int i = 0; i < shuffle_count; ++i)
		random_shuffle(shuffled_deck_.begin(), shuffled_deck_.end());

	suit_ = new LCQueue<CryptCard>[CryptCard::MAX_SUITS];	//intialize array of LCQueues
	
	//organizes the cards into 4 decks with there respected suits
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
	
	//creating the first key
	for(int i = 0; i < CryptCard::MAX_SUITS; ++i)
	{
		first_key_+=(suit_[i].front()).convertToInt();
	}
	
}

//access function for the first key
unsigned int KeyStream::firstKey()
{
	return first_key_;
}

//generate keys for the encryption and decryption
unsigned int KeyStream::generateNextKey()
{
	int key = -10;
	
	cards_.push(suit_[clubs].pop()); //rotating the clubs deck
	suit_[clubs].push(cards_.pop());
	
	int index;
	int i = 0;
	
	if ((suit_[clubs].front()).getRank() == CryptCard::ACE)	//if the first card in the clubs deck is an ace then begin rotation
	{
		while((suit_[i].front()).getRank() == CryptCard::ACE && i < CryptCard::MAX_SUITS)
		{
			if(i == clubs)	//seperate case for rotating the spades deck
			{
				cards_.push(suit_[i+1].pop());
				suit_[i+1].push(cards_.pop());
			}
			else
			{
				index = i;
				if (index == hearts)	//if the ace is in the hearts then we will need to look at the clubs deck
				{
					index=-1;
				}
				if (index+1 != clubs)	//rotate the deck to the right as if its not the clubs deck
				{
					cards_.push(suit_[index+1].pop());
					suit_[index+1].push(cards_.pop());
				}
				
				//while the top card on the left does not = the one on the right pop the cards on the left on to a stack
				while((suit_[i-1].front()).getRank() != (suit_[index+1].front()).getRank())
				{
					cards_.push(suit_[i-1].pop());	
				}
				
				//then push them back onto the deck
				while(cards_.size() != 0)
				{
					suit_[i-1].push(cards_.pop());
				}
			}
			++i;
		}
			i = 0;
	}
	
	//calculates the key
	for(int n = 0; n < CryptCard::MAX_SUITS; ++n)
	{
		key+=(suit_[n].front()).convertToInt();
	}
	return key;
}

//suit array used when creating a deck of cards 
CryptCard::Suit KeyStream::suits[] = {CryptCard::HEARTS, CryptCard::CLUBS, CryptCard::DIAMONDS, CryptCard::SPADES };
