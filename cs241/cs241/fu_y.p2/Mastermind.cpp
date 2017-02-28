/* Yu Fu partner: Will Foley
	Mastermind.cpp
*/
#include "Mastermind.h"
using namespace std;

void Mastermind::compareCodes(string code, string guess, size_t& bulls, size_t& cows)
{
	size_t size=code.size();
	
	/*if have same replace as '1' or '2'.
	  '1' means same letter and same loc, bulls.
	  '2' means same letter not same loc, cows.*/
	  
	//check all bulls first
	for (size_t i=0;i<size;i++)
	{ 
		if (guess[i]==code[i] )
		{
				guess[i]='1';
				code[i]='1';
				bulls++;
		}
	}
	//then check the cows
	for(size_t i=0;i<size;i++)	// for each maker code
		if(code[i] !='1' && code[i]!='2')	// any code cant be bull or exist cow	
			for (size_t j=0;j<size;j++)	// check all breaker codes
				if (guess[j] !='1' &&guess[j]!='2' && guess[j]==code[i]) // any code cant be bull or exist cow
					{
						guess[j]='2';
						code[i]='2';
						cows++; 
					}
}