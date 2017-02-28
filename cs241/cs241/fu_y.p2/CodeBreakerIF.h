#ifndef CODE_BREAKER_IF_H
#define CODE_BREAKER_IF_H

#include <string>

class CodeBreakerIF
{
 public:
  virtual std::string nextGuess() const = 0;
  virtual void guessResults(std::string guess, size_t bulls, size_t cows) = 0;
};

#endif
