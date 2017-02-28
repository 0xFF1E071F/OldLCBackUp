#include "generate.h"
#include <stdlib.h>
#include <time.h>

void generateLotteryNumber(struct lottery* nr){
  srand( time(NULL) );
  nr->first_ = rand() % 45;
  nr->second_ = rand() % 45;
  nr->third_ = rand() % 45;
  nr->fourth_ = rand() %45;
  nr->powerball_ = rand()% 45;
}
