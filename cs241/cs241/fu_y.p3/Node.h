template <typename T>  
class Node
{  
public:
	Node(const T& data = T(), Node* n = NULL)
	{
		next_=n;	//next item, default NULL
		data_=data;	// data_ 
	}
	Node *next_; // next_ address
    T data_; 		// item in node
}; 