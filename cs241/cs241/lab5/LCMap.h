//Will Foley & Ryan Fu
//LCMap

#ifndef LCMAP_H
#define LCMAP_H

#include <iostream>
#include <list>

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
	
	//find smallest node within the tree recursive helper
	Node** findMin(Node** n)
	{
		
		if ((*n)->left_ != NULL)	//if the next left node is not Null then you need to go next again 
			n = findMin(&((*n)->left_));
		return n;
	}

	//find if a node exists with a specific key recursive helper
	bool find_inner(Node* root, K key)
	 {
		if (root != NULL )   		
		{
			if  (comp_(key , root->key_))		//if the key is less than go left 
				return find_inner(root->left_,key);
			else if (comp_(root->key_, key))	//otherwise go right 
				return find_inner(root->right_,key);
		}
		
		return root != NULL;        //if it is no less than or greater than then you should have found it
									//otherwise it does not exist within the tree
	} 
	
	//recursive helper for insert
	bool insert(Node*& node, const K& key, const V& value)
	{
		if (node!=NULL)					//goes through until it has found the proper spot for the node 
		{
			if  (comp_(key, node ->key_))
				insert(node->left_,key , value);
	
			else if (comp_(node->key_, key))
				insert(node->right_,key , value);
		}
		else 				//and then puts it there 
		{
			node = new Node;
			node->key_ = key;
			node->value_ = value;
			node-> right_=NULL;
			node-> left_=NULL;
		} 
	
		return node == NULL;	
	} 
	
	//remove node with 0 or 1 child
	void removeNodeSimple(Node*& n)
	{
		Node* tmp = n; 		//have it point to the tmp
		
		//then point it to the left or the right node depending which side the child is on.
		if (n->left_== NULL)
			n = n->right_;
		else if(n->right_ == NULL)
			n = n->left_;
			
		delete tmp;     //then delete it 
						//this will also just delete a leaf
	}
	
	//delete node recursive helper
	bool deleteNode (Node*& n, const K& key)
	{
		if (n==NULL)			//if the node does not exist
			return false;	
		else	//otherwise go left or right 
		{
			if(comp_(key, n->key_) )
				 deleteNode(n->left_, key);
			else if(comp_(n->key_, key) )
				 deleteNode(n->right_, key);
			else if (n->left_!=NULL && n->right_!=NULL)		//if you found the node and if it has two childeren
			{
				
				Node** tmp = findMin(&n->right_);		//find the smallest node in the right subtree
				n->key_ = (*tmp)->key_;			//and move the data from that node to this current node
				n->value_ = (*tmp)->value_;
				removeNodeSimple(*tmp);		//then delete the node where you got the info from.
			}
			else
				removeNodeSimple(n);	//otherwise just delete the node
			return true;	
		}	
	}
	
	//deletes all nodes in the tree
	void clearHelper(Node *root)
	{
		if(root!=NULL)
		{
			clearHelper(root->left_);                       //L
			clearHelper(root->right_);                      //R
			delete root;                             //V
		}
	}
	
	//get the size of the tree
	int Getsize(Node* n)  const
	{ 
	  if (n==NULL) 		
		return 0;
	  else 
		return(Getsize(n->left_) + 1 + Getsize(n->right_)); 
	} 
	
	//preform an inorder traversal of the tree and make a list of all the keys 
	void inOrder(Node* n,list<K>& keyList) 
	{ 	
		if (n!=NULL) 
		{ 	
			inOrder(n->left_,keyList); 
			keyList.push_back(n->key_);
			inOrder(n->right_,keyList); 
			
		} 
	}
	
	//copy helper  
	void copy(Node * n)
	{
		 if(n != NULL)
		 {
			 insert(n->key_,n->value_);	
			 copy(n->left_);
			 copy(n->right_);
		 }
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
		copy(orig.root_);	//calling the copy helper with orig
	}
	/* cleans up all memory for stroage and calls the destructor for the keys and values stored */
	virtual ~LCMap()
	{
		clear();	//recursive helper
		
	}
	
	/* assignment operator*/
	LCMap<K,V,Comparator>& operator =(const LCMap<K,V,Comparator>& rhs)
	{
	
		this->clear();	//clear out current tree
		root_=NULL;
		copy(rhs.root_);	//then copy everything into tree
		
		return *this;
	}
	
	/* inserts the key vaule pair referenced by key
		returns true if successful */
	bool insert(const K& key, const V& value)
	{
		return  insert(root_, key, value);	//call insert helper function
	}

	/* erase key vaule pair referenced by key
		return true if successful */
	bool erase(const K& key)
	{
		return deleteNode(root_,key);
	}
	
	/* lookup the value associated with a key. if the key is not in the
	map, insert it with default value. Should provide l-value access to
	value.*/
	V& operator[](const K& k)
	{
		V tmp;
		if (!in(k))		//if the key does not exist 
		{
			insert(k,tmp);	//insert it with default value
		}
		Node* n = root_;
		while(comp_(k ,n->key_) || comp_(n->key_,k ))	//find the node with the key
		{
			if (comp_(k ,n->key_))
				n = n->left_;
			else if (comp_(n->key_,k ))
				n = n->right_;
		}
		
		return n->value_;	//and return its value
	}
	
	/* return true if this key maps to a value */
	bool in(const K& key)
	{
		Node* root = root_;
		return find_inner(root,key);	//calls recursive helper
	}
	
	 
	
	/* return a list of keys in this map */
	list<K> keys()
	{
		list<K> keyList_;
		inOrder(root_,keyList_);	//calls recursive helper
		return keyList_;
	}
	
	/* return true if the map is empty */
	bool empty() const
	{
		return (this->size()) ==0;
	}
	
	/* number of key value pairs stored */
	int size() const
	{
		return Getsize(root_);	//calls recursive helper
	}

	/* empties the map */
	void clear()
	{
		clearHelper(root_);			//calls recursive helper
		root_=NULL;
	}
	
	

};
#endif 