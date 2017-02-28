#ifndef CODE_MAKER_IF
#define CODE_MAKER_IF

#include <string>

class CodeMakerIF
{
public:
  virtual std::string generateCode() const = 0;
};

#endif
