#include <iostream>
using namespace std;

#include "Collection.h"

template <typename Type>
Collection<Type>::Collection():Vector
{
}

template <typename Type>
Collection<Type>::Collection(const Collection<Type>& orig): Vector
{
}

template <typename Type>
Collection<Type>::~Collection()
{
	delete [] theThing_; //deallocate
}

template <typename Type>
void Collection::print(ostream Collection<Type>& out) const
{
	for (int i=0,i<nElements_;++i)
	{
		out << theThing_[i];
	}
	
}

template <typename Type>
ostream& operator<<(ostream& out, const Collection<Type>& thingToPrint)
{
	thingToPrint.print(out);
	return out;
}

template <typename Type>
void Collection<Type>::addThing(const Collection<Type>& thingToAdd)
{
	Collection.push_back(thingToAdd);
}

template <typename Type>
void Collection<Type>::removeThing(Collection<Type>& thingToRemove) 
{

}

template <typename Type>
void Collection<Type>::findSmallest (const Collection<Type>& thing)
{

}

template <typename Type>
Collection<Type>& Collection<Type>:: operator=(const Collection<Type>& rhs)
{
	// Check for self-assignment
	if (this != &rhs)
	{
		// Deallocate the lhs memory
		delete [] theThing_;

		// Allocate new memory for the lhs
		theThing_ = new Type[rhs.nElements_];

		// make nElements_ for lhs = nElements_ for rhs
		nElements_ =rhs.nElements_

		// copy elements from rhs to lhs
		for(int i=0;i<nElements_;i++)
		{
			theThing_[i] = rhs.theThing_[i];
		}

	}
	// return a reference to the lhs
	return *this;
}

template <typename Type>
Collection<Type>& Collection<Type>:: operator<(const Collection<Type>& rhs)
{
	return strcmp(theThing_,rhs.theThing_) < 0;
} 

template <typename Type>
Collection<Type>& Collection<Type>::operator>(const Collection<Type>& rhs)
{
	return strcmp(theThing_,rhs.theThing_) > 0;
}
template <typename Type>
Collection<Type>& Collection<Type>::operator<=(const Collection<Type>& rhs)
{
	return strcmp(theThing_,rhs.theThing_) <= 0;
}
template <typename Type>
Collection<Type>& Collection<Type>::operator>=(const Collection<Type>& rhs)
{
	return strcmp(theThing_,rhs.theThing_) >= 0;
}

template <typename Type>
Collection<Type>& Collection<Type>::operator==(const Collection<Type>& rhs)
{
	const char* firstPtr = theThing_;
	const char* secondPtr = rhs.theThing_;

	while(*firstPtr != 0 && 
		*firstPtr == *secondPtr)
	{
		++firstPtr;
		++secondPtr;
	}

	return *firstPtr == *secondPtr;
}

template <typename Type>
Collection<Type>& Collection<Type>::operator!=(const Collection<Type>& rhs)
{
	return strcmp(theThing_,rhs.theThing_) != 0;
}
