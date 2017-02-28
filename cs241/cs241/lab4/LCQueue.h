//Will Foley & Ryan Fu
//LCQueue class and functions

#ifndef LCQUEUE_H
#define LCQUEUE_H

template <typename T>
class LCQueue{

public:
	//default constructor
	LCQueue()
	{
		data_ = new T [INITIAL_CAPACITY];
		capacity_ = INITIAL_CAPACITY;
		size_ = 0;
		last_ = -1;
		first_ = 0;
	}
	
	//constructor for given capacity 
	LCQueue(int capacity)
	{
		data_ = new T [capacity];
		capacity_ = capacity;
		size_ = 0;
		last_ = first_ = capacity/2;
	}
	
	//copy constructor
	LCQueue(const LCQueue& old)
	{
		data_ = new T [old.capacity_];
		capacity_ = old.capacity_;
		size_ = old.size_;
		first_ = old.first_;
		last_ = old.last_;
		if (old.size_ > 0)
		{
			for (int i = 0; i < capacity_; ++i)	//copy over data
			{
				data_[i] = old.data_[i];
			}
		}
	}
	
	//assignment operator
	LCQueue& operator =(const LCQueue& old)
	{
		delete [] data_;	
		data_ = new T [old.capacity_];
		capacity_ = old.capacity_;
		size_ = old.size_;
		first_ = old.first_;
		last_ = old.last_;
		
		if (old.size_ > 0)	
		{
			for (int i = 0; i < capacity_; ++i)	//copy over data
			{
				data_[i] = old.data_[i];
			}
		}
		
		return *this;
	}
	
	//destructor
	virtual ~LCQueue()
	{
		delete [] data_;
	}
	
	//push back
	void push(const T& item)
	{
		if (size_ == capacity_)
		{
			doubleCapacity();
		}

		last_ = (last_ + 1) % capacity_;	//update last
		data_[last_] = item;	//put the item into last
		++size_;
	}
	
	//pop first
	T pop()
	{
		int first_index = first_;
		--size_;
		first_ = (first_ + 1) % capacity_;	//update first
		return data_[first_index];
	}
	
	//look at front
	T& front()
	{
		return data_[first_];
	}
	
	//double capacity
	void doubleCapacity()
	{
		T* newitems = new T [capacity_*2];
		for (int i = first_; i < capacity_; ++i)	//copy items from first to capacity
		{
			newitems[i] = data_[i];
		}
		for (int i = 0; i < first_; ++i)	//copy items from beginning to first
		{
			newitems[i+capacity_] = data_[i];
		}
		last_ = first_ + size_ -1;
		delete [] data_;
		data_ = newitems;	
		capacity_*=2;
	}
	
	
	bool empty()
	{
		return size_ == 0;
	}
	int size()
	{
		return size_;
	}

private:
	int size_;
	int capacity_;
	T* data_;
	int last_;
	int first_;
	// default capacity, if none is specified
	const static int INITIAL_CAPACITY = 2;
};
#endif

