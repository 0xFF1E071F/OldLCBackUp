/* Yu Fu partner: Will Foley
	ComputerCodeMaker.h
*/
#ifndef ComputerCodeMaker_H
#define ComputerCodeMaker_H

#include <iostream>
#include <stdio.h>      /* printf, scanf, puts, NULL */
#include <stdlib.h>     /* srand, rand */
#include <time.h>       /* time */
#include <string>
using namespace std;

#include "CodeMakerIF.h"

class ComputerCodeMaker :public CodeMakerIF
{
public:
	ComputerCodeMaker(size_t length,size_t range);
	string generateCode() const;
	
private:
	size_t length_;
	size_t range_;
};


#endif 