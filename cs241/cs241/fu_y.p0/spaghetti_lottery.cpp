#include "generate.h"
#include "print_it.h"
#include "data_structures.h"

int main(){
  struct lottery nr;
  generateLotteryNumber(&nr);
  printLottery(&nr);
  return 0;
}
