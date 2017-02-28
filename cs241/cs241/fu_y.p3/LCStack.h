#ifndef LCSTACK_H
#define LCSTACK_H

#include "Node.h"

template <typename T>
class LCStack:public Node<T>{
private:
	Node<T> *pHead_;	/*the first node in stack*/
	int size_;			/*numbers of items in stack*/
public:
	LCStack(void)	
	{
		//empty stack
		pHead_=NULL;
		size_=0;		
	}
	
	LCStack(const LCStack<T>& rhs)
	{
		pHead_=NULL;
		size_=0;
		if (rhs.pHead_ == NULL)
			pHead_ = NULL; 
		else
		{
			pHead_= new Node<T>;
			pHead_->data_=rhs.pHead_->data_;
			size_++;
			Node<T> *newPtr = pHead_;    // new node pointer
			for (Node<T> *origPtr = rhs.pHead_->next_;
					origPtr != NULL; origPtr = origPtr->next_)
			{
				newPtr->next_ = new Node<T>;
				newPtr = newPtr->next_;
				newPtr->data_ = origPtr->data_;
				size_++;
			}
			newPtr->next_=NULL;
		}
	}
	
	LCStack& operator =(const LCStack& rhs)
	{
			while(size_!=0)
			{
				this.pop();
			}
			this->pHead_=NULL;

			size_=0;
			if (rhs.pHead_ == NULL)
				this->pHead_ = NULL; 
			else
			{
				this->pHead_= new Node<T>;
				this->pHead_->data_=rhs.pHead_->data_;
				size_++;
				Node<T> *newPtr = this->pHead_;    // new node pointer
				for (Node<T> *origPtr = rhs.pHead_->next_;
						origPtr != NULL; origPtr = origPtr->next_)
				{
					newPtr->next_ = new Node<T>;
					newPtr = newPtr->next_;
					newPtr->data_ = origPtr->data_;
					size_++;
				}
				newPtr->next_=NULL;
			}
		return this;
	}
	
	virtual ~LCStack(void)
	{
		while(size_!=0)
		{
			Node<T> *tmpNode= pHead_;
			pHead_=pHead_->next_;
			delete tmpNode;
			size_--;
		}
		pHead_=NULL;
	}
	
	void push(const T& t)
	{
		if (size_==0)
		{
			pHead_= new Node<T>(t);

		}
		else
		{
			Node<T>* pNode=new Node<T>(t);
			pNode->next_=pHead_;
			pHead_=pNode;
		}
		size_++;
	}
	
	T pop()
	{
		T tmp = pHead_->data_;
		Node<T>* tmpNode= pHead_;	
		pHead_=pHead_->next_;
		size_--;
		delete tmpNode;
		return tmp;	
	}
	
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
