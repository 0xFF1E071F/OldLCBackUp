#pragma once

template <typename VectorType>
class Vector
{
public:
	Vector(void);
	Vector(int initialSize);
	Vector(const Vector<VectorType>& original);
	void push_back(const 
		VectorType& thingToAdd);
	const VectorType& operator[](int index) const;
	VectorType& operator[](int index);
	int size() const;
	Vector<VectorType>& operator=(
		const Vector<VectorType>& rhs);
	virtual ~Vector(void);
private:
	VectorType* theArray_;
	int nElements_;
};

template <typename VectorType>
Vector<VectorType>::Vector() :
  theArray_(0), nElements_(0)
  {
  }

template <typename VectorType>
Vector<VectorType>::Vector(int initialSize) :
theArray_(new VectorType[initialSize]),
	nElements_(initialSize)
{
}

template <typename VectorType>
int Vector<VectorType>::size() const
{
	return nElements_;
}

template <typename VectorType>
void Vector<VectorType>::push_back(
	const VectorType& thingToAdd)
{
	// Allocate a new array
	VectorType* newArray = new
		VectorType[nElements_+1];

	// Copy the old array
	for(int i=0;i<nElements_;i++)
	{
		newArray[i] = theArray_[i];
	}

	// Add the new element to the end of the 
	// new array
	newArray[nElements_] = thingToAdd;
	++nElements_;

	// Deallocate the old array
	delete [] theArray_;

	// point to the new array
	theArray_ = newArray;
}

template <typename VectorType>
const VectorType& Vector<VectorType>::operator[](int index) const
{
	return theArray_[index];
}

template <typename VectorType>
VectorType& Vector<VectorType>::operator[](int index)
{
	return theArray_[index];
}

template <typename VectorType>
Vector<VectorType>& Vector<VectorType>::operator=(
		const Vector<VectorType>& rhs)
{
	// Check for self-assignment
	if (this != &rhs)
	{
	  // Deallocate the lhs memory
	  delete [] theArray_;

	  // Allocate new memory for the lhs
	  theArray_ = new Type[rhs.nElements_];

	  // make nElements_ for lhs = nElements_ for rhs
	  nElements_ = rhs.nElements_;

	  // copy elements from rhs to lhs
	  for(int i=0;i<nElements_;i++)
	  {
		  theArray_[i] = rhs.theArray_[i];
	  }

	}
	// return a reference to the lhs
	return *this;
}

template <typename VectorType>
Vector<VectorType>::Vector(const Vector<VectorType>& original) :
   nElements_(original.nElements_),
   theArray_(new VectorType[original.nElements_])
{
	for(int i=0;i<nElements_;i++)
	{
		theArray_[i] = original.theArray_[i];
	}
}

template <typename VectorType>
Vector<VectorType>::~Vector()
{
	delete [] theArray_;
}