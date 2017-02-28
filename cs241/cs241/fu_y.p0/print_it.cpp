#include "print_it.h"
#include <iostream>

using namespace std;

void printLottery(struct lottery* nr){
  cout << nr->first_ << "-" << nr->second_ << "-" << nr->third_ << "-" << nr->fourth_ << "-" << nr->powerball_ <<endl;
}
