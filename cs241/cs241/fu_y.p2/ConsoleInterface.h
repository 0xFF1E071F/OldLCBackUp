/* Yu Fu partner: Will Foley
	ConsoleInterface.h
*/
#ifndef CONSOLE_INTERFACE_H
#define CONSOLE_INTERFACE_H

#include <ctype.h>
#include <stdio.h>
#include <stdlib.h>
#include <string>
#include "CodeBreakerIF.h"
#include "CodeMakerIF.h"
#include "UserCodeMaker.h"
#include "UserCodeBreaker.h"
#include "ComputerCodeBreaker.h"
#include "ComputerCodeMaker.h"
#include "Mastermind.h"

class ConsoleInterface{

public:
  ConsoleInterface(){}
  virtual ~ConsoleInterface(){}
  
  // takes control of game from the main(...)
  void start();

private:
  // plays a single game of Mastermind
  void play(CodeBreakerIF*, CodeMakerIF*);

};

#endif
