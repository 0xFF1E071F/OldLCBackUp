#include <iostream>
using namespace std;
#include "FloatArray.h"

FloatArray::FloatArray (const FloatArray& thing)
{
	for (int i = 0 ; i<thing.dimension_; ++i)
		theArray_[i]=thing.theArray_[i];
}

FloatArray::FloatArray()
{
	theArray_ = 0;
	dimension_ = 0; //set original value
}

FloatArray::~FloatArray()
{
	delete [] theArray_;
}

FloatArray::FloatArray(int dimension, float initialElementValue)
{
	dimension_=dimension;

	// Dynamically allocate memory for dimension floats
	theArray_ = new float[dimension];

	// Set each element to initialElementValue
	for(int i=0;i<dimension;i++)
	{
		theArray_[i] = initialElementValue;
	}

}

void FloatArray::print(std::ostream& out) const
{
	for (int i=0; i<dimension_; ++i)
	{
		out << theArray_[i]<<endl; // print the value of each data
	}
}

ostream& operator << (std::ostream& out, const FloatArray& thingToPrint)
{
	thingToPrint.print(out); // print
	return out;
}

void FloatArray::push_back(const float& newThing)
{
	++dimension_;
	// set a newArray
	float* newArray = new float [dimension_];

	// copy theArry_ to newArray
	if (dimension_ >1)
	{
		for ( int i =0; i < dimension_; ++i)
		{
			newArray[i] = theArray_[i];
		}
	}
	// push back the newThing
	newArray[dimension_-1] = newThing;

	// deallocate theArray_
	delete [] theArray_;

	// pointer to newArray
	theArray_ = newArray;
}

void FloatArray::push_front(const float& newThing)
{
	// size of FloatArray +1
	dimension_ = dimension_ +1;
	// set a newArray
	float* newArray = new float [dimension_];

	// push front the newThing
	newArray[0] = newThing;
	// copy theArry_ to newArray
	if (dimension_ >1)
	{
		for ( int i =1; i < dimension_ -1; ++i)
		{
			newArray[i] = theArray_[i-1];
		}
	}

	// deallocate theArray_
	delete [] theArray_;

	// pointer to newArray
	theArray_ = newArray;
}
