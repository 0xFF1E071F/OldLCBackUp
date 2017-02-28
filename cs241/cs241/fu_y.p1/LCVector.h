// Yu Fu & William Foley
// p1 CARDS
// CS 241
#ifndef LCVECTOR_H
#define LCVECTOR_H
#include <iostream>
using namespace std;

template <typename T>
class LCVector
{
 public:
 LCVector();
 LCVector(const LCVector<T>& orig);
 virtual ~LCVector();
 LCVector<T>& operator =(const LCVector<T> &rhs);
 size_t size() const;	//return current size_
 T& operator [] (size_t index);	// provides l-value access to the item at the index
 const T& operator [] (size_t index) const;	// provides constant l-value access to the item at the index
 void push_back(const T& item); // adds an item to the end of the list
 void pop_back(); // remove the last item from the list
 void insertAt(const T& item,size_t index);//inserts item at given index, shifts items at/past this index back
 void removeAt(size_t index);// remove the item at the given index from the list
 void remove_front();	//remove the first one 
 virtual void print (ostream& out) const;	// print out
 private:
 int size_;
 int capacity_;
 T* items_;
 //double capacity
 void doubleCapacity()
 {
  capacity_+=capacity_;
  T* tmp = new T [capacity_];
  for (int i =0;i<size_;i++)
  {
	tmp[i]=items_[i];
  }
  delete [] items_;
  items_=tmp;
 }
};

template <typename T>
LCVector<T>::LCVector()
{
 capacity_ = 16;
 size_ =0;
 items_ = new T[capacity_];
}

template <typename T>
LCVector<T>::LCVector (const LCVector<T>& orig)
{
 //copy size
 size_=orig.size_;
 capacity_=orig.capacity_;
 items_ = new T [capacity_];
 for (int i =0;i<size_;i++)//copy
 {
  items_[i]=orig.items_[i];
 }
}

template <typename T>
LCVector<T>::~LCVector()
{ 
	capacity_=16;
	size_=0;
	delete [] items_;
}

template <typename T>
LCVector<T>& LCVector<T>::operator = (const LCVector<T>& rhs)
{
 //Test for self-assignment
 if (this != &rhs)
 {
  for (int i=0;i<size_;i++)
  {
	 delete [] items_;
  }
 }
 //copy size
 size_=rhs.size_;
 capacity_=rhs.capacity_;
 items_ = new T[capacity_];
 for (int i =0;i<size_;i++)//copy
 {
  items_[i]=rhs.items_[i];
 }
 return this;
}

template <typename T>
void LCVector<T>::push_back(const T& item)
{
	if (size_ == 0)	// if size =0
	{
		items_[size_] = item;
	}
	else{
		while (size_+ 1 == capacity_)
		{
			doubleCapacity();
		}
		items_[size_]=item;
	}
	size_++;
}

template <typename T>
size_t LCVector<T>::size() const
{
  return size_; 
}
template <typename T>
 T& LCVector<T>::operator [] (size_t index)
{
	return items_[index];
} 

template <typename T>
const T& LCVector<T>::operator [] (size_t index)const
{	
	return items_[index]; 
}

template <typename T>
void LCVector<T>::pop_back()
{
	if (size_>=1)
		size_--;
}

template  <typename T>
void LCVector<T>::remove_front()
{
	T* newVector = new T [capacity_];
	for (int i=0;i<size_;i++)
	{
		newVector[i]= items_[i+1];
	}
	size_--;
	delete [] items_;
	items_ = newVector;
}

template <typename T>
void LCVector<T>::insertAt(const T& item,size_t index)
{
	int capacity=16;
	if (index >=size_)
	{
		push_back(item);
	}
	else if (index>=0 && index<size_)
	{
		while (size_+ 1 == capacity_)
		{
			capacity_+= capacity;
		}
		T* newVector = new T [capacity_];
		for(int i =0;i<index;i++)
		{
			newVector[i]=items_[i];
		}
		newVector[index]=item;
		for(int i=index;i<size_;i++)
		{
			newVector[i+1]=items_[i];
		}
		size_++;
		delete [] items_;
		//items_= new T [capacity_];
		items_=newVector;
	}

}

template <typename T>
void LCVector<T>::removeAt(size_t index)
{
	T* newVector = new T [capacity_];
	if (index ==0)
	{
		remove_front();
	}
	else if (index == size_-1)
	{
		pop_back();
	}
	else if (index >0 && index<size_-1)
	{
		for (int i=0;i<index;i++)
		{
			newVector[i]=items_[i];
		}
		for (int i=index;i<size_;i++)
		{
			newVector[i]=items_[i+1];
		}
		size_--;
		delete [] items_;
		items_ = newVector;	
	}
}

template <typename T>
void  LCVector<T>::print(ostream& out) const
{
  out <<"[ ";
  
  for (int i=0; i<size_; i++)
  {
    out<<items_[i]<<" ";
  }
  
  out <<"]";
}

template <typename T>
ostream& operator <<(ostream& out, const LCVector<T>& LCVector)
{
  //  print  all  
  LCVector.print(out);
  return out;
}

#endif /*LCVECTOR_H*/
