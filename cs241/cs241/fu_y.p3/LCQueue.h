#ifndef LCQUEUE_H
#define LCQUEUE_H

#include <iostream>
using namespace std;
template <typename T>
class LCQueue{
private:
	// default capacity, if none is specified
	const static int INITIAL_CAPACITY = 2;
	// size and capacity
	int size_;
	int capacity_;
	// item array
	T * data_;
	// position of first and last item in array
	int first_;
	int last_;
	
public:
	LCQueue(){
		size_=0;
		capacity_=INITIAL_CAPACITY;
		first_=0;
		last_=-1;
		data_ = new T [capacity_];
	}

	LCQueue(int capacity){
		size_=0;
		first_=0;
		last_=first_;
		capacity_ = capacity;
		data_ = new T [capacity_];
	}
	
	LCQueue(const LCQueue& oldQueue){
		size_= oldQueue.size_;
		capacity_ = oldQueue.capacity_;
		first_=oldQueue.first_;
		last_=oldQueue.last_;
		data_ = new T [capacity_];
		for(int i =0;i<capacity_;i++)
		{
			data_[i]=oldQueue.data_[i];
		}
	}
	LCQueue& operator =(const LCQueue& oldQueue){
		size_= oldQueue.size_;
		capacity_ = oldQueue.capacity_;
		first_=oldQueue.first_;
		last_=oldQueue.last_;
		data_ = new T [capacity_];
		for(int i =0;i<capacity_;i++)
		{
			data_[i]=oldQueue.data_[i];
		}
	}
	virtual ~LCQueue(){
		size_=0;
		capacity_=INITIAL_CAPACITY;
		delete [] data_;
		first_=0;
		last_=first_;
	}

	/*
	  put new item in back of the array
	  if array full, double capacity, then put in 
	  if array empty, put at first location
	  last_ be the position of this item
	*/
	void push(const T& t){
		if (size_==capacity_)
		{
			doubleCapacity(); 
		}
		last_ = (last_+1)%capacity_;
		data_[last_]=t;
		size_++;
	}
	
	/*
	  return item of current position
	  then delete this item, first become next one
	*/
	T pop(){
		int tmpLoc=first_;
		first_ = (first_+1)%capacity_;
		size_--;
		return data_[tmpLoc];
	}
	
	/*
	  return the first item in array
	*/
	T front()
	{
		return data_[first_];
	}
	
	/*
	 return the if size = 0;
	 also if first_  last_ 
	 at same position, its also be empty, but not the first one		
	*/
	bool empty(){
		return size_==0;
	}
			
	/*
	  return current size_			
	*/
	int size(){
		return size_;
	}

	
	/*
	  double the size of capacity
	  and extend the old array
	*/
	void doubleCapacity(){
		int tmpCap = 2 * capacity_;
		T* tmpData = new T [tmpCap];
		for(int i=first_;i<capacity_;i++)
		{
			tmpData[i]=data_[i];
		}
		for(int i=0;i<first_;i++)
		{
			tmpData[i+capacity_]=data_[i];
		}
		delete [] data_;
		data_ = tmpData;
		last_ = first_ + size_ -1;
		capacity_ *= 2;
	}
	
	void print()
	{
		cout<<"=";
		for(int i=0;i<capacity_;i++)
		{
		
			if (i<first_ && i>last_ && first_ > last_)
				cout<<"_"<<"|";
			else if ((first_ < last_ && i>last_)||(first_ < last_ && i<first_))
				cout<<"_"<<"|";
			else 
				cout<<data_[i]<<"|";
				
			
		}cout<<"=";
		
	}
};
#endif