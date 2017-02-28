/* Yu Fu partner: Will Foley
	UserCodeMaker.h
*/

#ifndef USERCODEMAKER_H
#define USERCODEMAKER_H

#include <iostream>
#include <string.h>
#include "CodeMakerIF.h"
using namespace std;
class UserCodeMaker :public CodeMakerIF
{
public:
  UserCodeMaker(size_t range,size_t length);
  string generateCode() const;
private:
	size_t length_;
	size_t range_;
 
};

#endif 