/* Yu Fu partner: Will Foley
	Mastermind.h
*/
#ifndef MASTERMIND_H
#define MASTERMIND_H

#include <string>

class Mastermind
{
 public:
  static void compareCodes(std::string code, std::string guess, size_t& bulls, size_t& cows);
};

#endif
