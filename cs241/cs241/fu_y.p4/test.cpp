#include <iostream>
#include "LCMap.h"
#include <string>
#include <list>
using namespace std;

int main()
{
	LCMap<int,int,std::less<int> > a;
	
	// if(a.empty())
	// {
		// cout<< "a is empty";
		
	// }
	// else 
		// cout<<"not empty"<<endl;
	// if (a.insert(3,3) == true)
	// {
		// cout<< "insert";
	// }
	a.insert(1,1);
	a.insert(4,4);
	a.insert(7,7);
	a.insert(2,2);
	a.insert(5,5);
	a.insert(6,6);
	// LCMap<int,int,std::less<int> > b(a);
	
	// LCMap<int,int,std::less<int> > c=a;
	// if (c.in(2))
	// {
		// cout<<"i find 2"<<endl;
	// }else{
		// cout<<"2 not find"<<endl;
	// }
	// if (c.in(6))
	// {
		// cout<<"i find 6"<<endl;
	// }else{
		// cout<<"6 not find"<<endl;
	// }
	/* if (c.erase(2))
	{
		cout<<"delete"<<endl;
	}else{
		cout<<"not find"<<endl;
	} */
	// if (c.in(2))
	// {
		// cout<<"i find 2"<<endl;
	// }else{
		// cout<<"2 not find"<<endl;
	// }
	
	// if(b.empty())
	// {
		// cout<< "b is empty";
		
	// }
	// else
		// cout<<"b not empty"<<endl;
		
	// b.clear();	
	// if (b.in(2))
	// {
		// cout<<"i find 2"<<endl;
	// }else{
		// cout<<"2 not find"<<endl;
	// }
	
	// if(b.empty()==true)
	// {
		// cout<< "b is empty"<<endl;
	// }
	// else
		// cout<<"b not empty"<<endl;
		

	// list<int> newlist=a.keys();
	// for(list<int>::const_iterator i=newlist.begin();i!=newlist.end();i++)
	// {
		// cout<<*i;
	// }
	// a.print();
	// cout<<"====";
	// for (std::list<int>::iterator it=l.begin(); it != l.end(); ++it)
		// cout << *it;
	// cout<<endl;
	// cout<<"a"<<a.size()<<endl;
	// cout<<"b"<<b.size()<<endl;
	// cout<<"c"<<c.size()<<endl;
	a.printTree();
}