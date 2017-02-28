#pragma once
#include "Vector.h"

template <typename Type>
class Collection: public Vector // virtual from Vector
{
public:
	Collection();
	Collection(const Collection<Type>& orig);
	virtual ~Collection();

	//print 
	void print (ostream Collection<Type>& out) const;
	
	// operators
	Collection<Type>& operator=(const Collection<Type>& rhs); 
	Collection<Type>& operator<(const Collection<Type>& rhs); 
	Collection<Type>& operator>(const Collection<Type>& rhs); 
	Collection<Type>& operator<=(const Collection<Type>& rhs); 
	Collection<Type>& operator>=(const Collection<Type>& rhs); 
	Collection<Type>& operator==(const Collection<Type>& rhs); 
	Collection<Type>& operator!=(const Collection<Type>& rhs); 

	// See if one test is == to another test
	bool operator==(const Collection<Type>& rhs) const;

	//functions
	void addThing     (const Collection<Type>& thingToAdd);
	void removeThing  (Collection<Type>& thingToRemove);
	void findSmallest (const Collection<Type>& thing);


private:
	int nElements_;
	Type* theThing_;
};

// cout<<
template <typename Type>
ostream& operator<<(ostream& out, const Collection<Type>& thingToPrint);

