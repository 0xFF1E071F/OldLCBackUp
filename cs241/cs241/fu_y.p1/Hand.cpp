// Yu Fu & William Foley
// p1 CARDS
// CS 241
#include "Hand.h"

Hand::Hand(CardComparatorIF* mode)
{
	sortMode_= mode;	// point cmp
}

//add a new card
void Hand::addCard(const Card& card)
{
	int pos=0;
	int size=handVector_.size();
	if (size==0)
	{
		handVector_.push_back(card);
	}
	else if (size!=0)
	{
		bool insert = false;		// if correct insert
		while (insert==false)
		{
			if ((*sortMode_)(card,handVector_[pos]))	// if find insert loc
			{
				handVector_.insertAt(card,pos);
				insert=true;
			}
			else	// or push back
			{
				++pos;
				if (pos ==size)
				{
					handVector_.push_back(card);
					insert=true;
				}
			}
		}
	}
}

//remove card from hand
void Hand::removeCard(const Card& card)
{
	int size=handVector_.size();
	int pos=0;	// card position
	bool find =false;
	while (find!=true && pos < size)
	{
		if (card==handVector_[pos])
		{
			find= true;
		}
		else{
			pos++;
		}
	}
	handVector_.removeAt(pos);
}
//retrun size of hand vector
size_t Hand::size()
{
	return handVector_.size();
}
//ptint
void Hand::print(ostream& out) const
{	
	for(size_t i =0;i<handVector_.size();i++)
		out<<handVector_[i]<<endl;
}

