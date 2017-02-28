/* Yu Fu partner: Will Foley
	ComputerCodeMaker.cpp
*/
#include "ComputerCodeMaker.h"

ComputerCodeMaker::ComputerCodeMaker(size_t range,size_t length)
{
	length_=length;
	range_=range;
}
	
string ComputerCodeMaker::generateCode() const
{
	srand (time(NULL));
	string tmp;
	size_t rdmRange;
	for(size_t i=0;i<length_;i++)
	{	
		rdmRange = rand() % range_;
		tmp.push_back('a'+rdmRange);
	}
	cout<<tmp<<endl;
	return tmp;
}
	
