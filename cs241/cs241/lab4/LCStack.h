//Will Foley & Ryan Fu
//LCStack class and functions

#ifndef LCSTACK_H
#define LCSTACK_H

template <typename T>
class LCStack{
private:
	struct Node
	{
		T data_;	
		Node* next_;
	};
	Node* pHead_;       /*the first node in stack*/
	int size_;			
public:
	//constructor
	LCStack(void)	
	{
		//empty stack
		pHead_=NULL;
		size_=0;		
	}
	
	//copy constructor
	LCStack(const LCStack<T>& rhs)
	{
		if (rhs.pHead_ == NULL)		//if the stack you want copy is empty
			pHead_=NULL;
		else
		{
			Node* rbegin = rhs.pHead_;
			pHead_ = new Node;			//new node for the beginning
			Node* begin = pHead_;
			while (rbegin != NULL)		//while you havent reached the end of the rhs stack
			{
				begin->data_ = rbegin->data_;	//copy data
				begin->next_ = new Node;		//new node for the next one
				begin = begin->next_;			//iterating
				rbegin = rbegin->next_;
			}
			size_ = rhs.size_;
			begin->next_ = NULL;
		}
	}
	
	//assignment operator
	LCStack& operator =(const LCStack& rhs)
	{
		if (rhs.pHead_ == NULL)
			pHead_=NULL;
		else
		{
			while(!empty())	//deleting all items in this stack
			{
				pop();
			}
			
			pHead_ = new Node;			//new node for the beginning
			Node* begin = pHead_;		
			Node* rhs_node = rhs.pHead_;
			
			while (rhs_node != NULL)	//while you haven't reached the end
			{
				begin->data_ = rhs_node->data_;		//copy data
				begin->next_ = new Node;			//new node for then next one
				begin = begin->next_;				//iterating
				rhs_node = rhs_node->next_;
			}
			
			size_ = rhs.size_;
			begin->next_ = NULL;
		}
		return *this;
	}
	
	//destructor
	virtual ~LCStack(void)
	{
		while(pHead_!=NULL)
		{
			Node* tmpNode= pHead_;
			pHead_=pHead_->next_;
			delete tmpNode;
			
		}
		
	}
	
	//push front
	void push(const T& t)
	{
		Node* pNode = new Node;	//new node to hold data
		pNode->data_ = t;		//put data in new node
		pNode->next_=pHead_;	//have new node point to beginning
		pHead_=pNode;			//let new node be the beginning
		size_++;
	}
	
	//pop front
	T pop()
	{
		T tmp = pHead_->data_;	//save the data
		Node* tmpNode= pHead_;	//save the node to be popped
		pHead_=pHead_->next_;	//move phead to the next one
		size_--;
		delete tmpNode;
		return tmp;	
	}
	
	//look at top
	T top()
	{
		return pHead_->data_;
	}
	
	bool empty()
	{
		return size_ == 0;
	}
	
	int size()
	{
		return size_;
	}
};
#endif 

