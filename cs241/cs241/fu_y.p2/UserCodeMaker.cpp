/* Yu Fu partner: Will Foley
	UserCodeMaker.cpp
*/
#include "UserCodeMaker.h"

UserCodeMaker::UserCodeMaker(size_t range,size_t length)
{
	length_ = length;
	range_ = range;
}

string UserCodeMaker::generateCode() const
{

	size_t makerLast=0;
	int makerFirst=0;
	string code;
	//check maker code valid
	while(code.size() != length_ || makerLast > range_ || makerFirst < 1)	// until get correct length									// range from 'a' to 'z' which 1-26
	{
		cin>>code;
		makerLast=0;
		makerFirst=0;
		for(size_t i =0;i<code.size();i++)
		{
			if (code[i]>code[makerLast])
			{
				makerLast=i;
			}
			if (code[i]<code[makerFirst])
			{
				makerFirst=i;
			}
		}
		makerLast = code[makerLast] -96;
		makerFirst = code[makerFirst] -96;
		if(code.size() != length_)
		{
			cout<<"You make a wrong length of code, please enter a "<<length_<<" long Code :"<<endl;
		}
		else if (makerLast>range_)
		{
			cout<<"You make a wrong range of code, please enter a "<<range_<<" range Code :"<<endl;
		}
		else if (makerFirst < 1 )
		{
			cout<<"You make a wrong code, please enter a "<<range_<<" range Code :"<<endl;
		}
	}	
	cout<<"Maker created a length "<<length_<<" code and with range "<<range_<<". Start to guess."<<endl;
 
	return code;
}

