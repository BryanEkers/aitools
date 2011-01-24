#include <iostream>
using namespace std;

#include "Board.cpp"

int main(){
  Board b(4,4);
  Board c(4,5);
  Board d(123,200);

  Board* p;

  char x[4]; 
  x[0] = 'a';
  x[1] = 'b';
  x[2] = 'c';
  x[3] = 'd';

  cout << "RAND" << endl;
  d.randomizeWithNum();
  cout << "PRINT" << endl;
  d.print();

  p = new Board(5, 5);
  delete p;
  return 0;
}
