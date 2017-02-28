/* Yu Fu partner: Will Foley
	UserCodeBreaker.h
*/
#ifndef UserCodeBreaker_H
#define UserCodeBreaker_H
#include <iostream>
using namespace std;
#include <string.h>
#include "CodeBreakerIF.h"

class UserCodeBreaker: public CodeBreakerIF
{
public:
  UserCodeBreaker(size_t range,size_t length);
  string nextGuess() const;
  void guessResults(std::string guess, size_t bulls, size_t cows);
private:
  size_t length_;
  size_t range_;
};
#endif 