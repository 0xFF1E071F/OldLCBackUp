/* Yu Fu partner: Will Foley
	ComputerCodebreaker.h
*/

#ifndef COMPUTERCODEBREAKER_H
#define COMPUTERCODEBREAKER_H
#include <iostream>
#include <vector>
#include <cmath>
#include <utility>
#include <list>
#include <iterator>
#include <string.h>
#include "CodeBreakerIF.h"
#include "Mastermind.h"
using namespace std;

class ComputerCodeBreaker: public CodeBreakerIF
{
  public:
	ComputerCodeBreaker(size_t range,size_t length);
	void initAllCodes();//initialize all possible code from a... to range_...
	string nextGuess() const;	// return the  best code as next guess 

	// use guess result to narrow the potential Codes list
	list<string> potentialCodes(string guess,size_t bulls, size_t cows)const;	
	
	// give result of guess
	void guessResults(std::string guess, size_t bulls, size_t cows);	
	
	// getBestCode is using best way to get next code  
	string getBestCode() const; 

  private:
	size_t range_;
	size_t length_;
	list<string> codeList_;	//pentital code list
	list<string> allCodeList_;//all code list
	size_t allCodeSize_;	// size of all code

};
#endif 