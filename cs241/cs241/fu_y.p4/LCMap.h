#ifndef LCMAP_H
#define LCMAP_H
#include <iostream>
#include <list>
#include <iomanip> 
using namespace std;
template <typename K,typename V, typename Comparator=less<K> >
class LCMap
{
  private:
	struct Node
	{
	  K key_;
	  V value_;	
	  Node* left_;
	  Node* right_;
	  

	};
	
	Node* root_;	
	Comparator comp_;

	Node** findMin(Node** n)
	{
		while((*n)->left_!=NULL)
		{
			(*n)=(*n)->left_;
		}
		
		return *n;
	}

  public:
	/* constructor */
	LCMap(Comparator c=Comparator())
	{
		comp_=c;
		root_=NULL;

	}
	
	/* copy constructor */
	LCMap(const LCMap<K,V,Comparator>& orig)
	{
		root_=NULL;
		copy(orig.root_);
	}
	/* cleans up all memory for stroage and calls the destructor for the keys and values stored */
	virtual ~LCMap()
	{
		clear();	
	}
	/* assignment operator*/
	LCMap<K,V,Comparator>& operator =(const LCMap<K,V,Comparator>& rhs)
	{
		if (root_!=rhs)
		{
			this->clear();
			root_=NULL;
			copy(rhs.root_);
		}
		return *this;
	}
	
	void copy(Node * n)
	{
		 if(n)
		 {
			 insert(n->key_,n->value_);
			 copy(n->left_);
			 copy(n->right_);
		 }
	}
	
	
	/* inserts the key vaule pair referenced by key
		returns true if successful */
	bool insert(const K& key, const V& value)
	{
		Node *newNode  = new Node;
		newNode-> key_=key;
		newNode-> value_=value;
		newNode-> right_=NULL;
		newNode-> left_=NULL;
		//return insert(root_,key,value);
		return insert_inner(root_, newNode);
	}

	bool insert_inner(Node*& root, Node *p)
	{
		if (root!=NULL)
		{
			if  (p->key_ < root ->key_)
				insert_inner(root->left_,p);
			else if (root ->key_< p->key_)
				insert_inner(root->right_,p);
		}
		if (root==NULL)
		{
			root=p;
			return true;
		} 
	} 
	/* erase key vaule pair referenced by key
		return true if successful */
	bool erase(const K& key)
	{
		return deleteNode(root_,key);
	}

	bool deleteNode (Node*& n, const K& key)
	{
		if (n==NULL)
			return false;	
		else
		{
			if(comp_(key, n->key_) )
				 deleteNode(n->left_, key);
			else if(comp_(n->key_, key) )
				 deleteNode(n->right_, key);
			else if (n->left_!=NULL && n->right_!=NULL)
			{
				Node** tmp= findMin(&n->right_);
				n->key_=(*tmp)->key_;
				n->value_=(*tmp)->value_;
				removeNodeSimple(*tmp);
			}
			else
				removeNodeSimple(n);
			return true;	
		}	
	}

	void removeNodeSimple(Node* n)
	{
		Node* tmp;
		tmp= n->left_;
		if (n->left_->right_==NULL)
			n->left_=n->left_->left_;
		else if (n->left_->left_==NULL)
			n->left_=n->left_->right_;
		else
			n->left_=NULL;
		delete tmp;
	} 
	
	/* lookup the value associated with a key. if the key is not in the
	map, insert it with default value. Should provide l-value access to
	value.*/


	
	/* return true if this key maps to a value */
	bool in(const K& key)
	{
		if(find_inner(root_,key))
			return true;
		else 
			return false;
	}
	
	 bool find_inner(Node *root, K key)
	 {
		 if  (root == NULL)
			 return false;

		 if  (root->key_ == key)
			 return true ;

		 if  (comp_(key,root->key_))
			return find_inner(root->left_,key);
		 else 
			return find_inner(root->right_,key);
	} 
	
	/* return a list of keys in this map */
	list<K> keys()
	{
		list<K> keyList_;
		listInOrder(root_,keyList_);
		return keyList_;
	}
	
	
	void listInOrder(Node* n,list<K>& keyList) 
	{ 	
		if (n!=NULL) 
		{ 	
			listInOrder(n->left_,keyList); 
			keyList.push_back(n->key_);
			listInOrder(n->right_,keyList); 
		} 
	}

	/* return true if the map is empty */
	bool empty() const
	{
		return (this->size()) ==0;
	}
	
	/* number of key value pairs stored */
	int size() const
	{
		return Getsize(root_);
	}
	int Getsize(Node* n)  const
	{ 
	  if (n==NULL) 
		return 0;
	  else 
		return(Getsize(n->left_) + 1 + Getsize(n->right_)); 
	} 
	void printTree()
	{
		PrintTree(root_,0);
	}
	void PrintTree( Node* tp, int spaces )
	{
	  int i;
	 
	  if( tp != NULL )
	  {
		cout << tp->key_ << endl;
		PrintTree( tp->right_, spaces + 3 );
		for( i = 0; i < spaces; i++ )
		  cout <<' ';
		
		PrintTree( tp->left_, spaces + 3 );
	  }
	}
	/* empties the map */
	void clear()
	{
		clearHelper(this->root_);
		root_=NULL;
	}
	
	void clearHelper(Node *n)
	{
		if(n!=NULL)
		{
			clearHelper( n->left_);
			clearHelper( n->right_);
			delete n;   
		}
	}

};

// template <class C> struct comp:LCMap<K,V,Comparator>{
	// bool operator () (const K& k1, const K & k2) const
	// {
		// return k1<k2;
	// }
// }
#endif 