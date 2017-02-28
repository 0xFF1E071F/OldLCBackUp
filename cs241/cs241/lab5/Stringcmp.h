
#ifndef STRINGCMP_H
#define STRINGCMP_H
#include <string>
using namespace std;

class Stringcmp
{
public:
	
	bool operator() (string lhs, string rhs)
	{
		size_t i = 0;
		while (lhs[i] == rhs[i] && i < lhs.size())
		{
			++i;
		}
		return lhs[i] < rhs[i];
	}
};

#endif