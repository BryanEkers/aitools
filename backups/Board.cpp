#ifndef _BOARD_CPP_
#define _BOARD_CPP_

#include "Board.h"

/*
  @param x the width of the board
  @param y the height of the board
*/
Board::Board(unsigned short x, unsigned short y){
  int i;
  
  mWidth  = x;
  mHeight = y;

  pBoard = new char* [y]; // y rows

  for (i=0; i<y; i++){
    pBoard[i] = new char [x]; // x number of columns
  }

  // There might need be a better place to place this
  srand(time(NULL));
}

/** Default destructor. This must remove all the pointers
 from the array which have allocated space */
Board::~Board(){
  int i, j;
  i = 0;
  j = 0;

  for (i=0; i<mHeight; ++i){
    delete pBoard[i]; 
  }
  delete [] pBoard;
}

/** Returns the value of the board at a specific carteasian coordinate 
An alternative approach instead of overloading the operator
*/
char Board::getPos(unsigned short x, unsigned short y){
  return pBoard[x][y];
}

/** Implementation of the operator overloading */
//Board::operator[][] (){
//}

/** Main printing function */
void Board::print(){
  int i, j;

  for ( i = 0; i < mHeight; ++i ){
    for ( j = 0; j < mWidth; ++j ){
      cout << pBoard[i][j];
    }
    cout << endl;
  }
}

/** Randomize */
void Board::randomize(){
  int i, j;

  for ( i=0; i<mHeight; ++i ){
    for ( j=0; j<mWidth; ++j ){
      pBoard[i][j] = rand()%255; // unsigned char 0->255
    }
  }
}

/** Randomize with a given specific set*/
void Board::randomizeWithSet(char set[]){
  
}

void Board::randomizeWithSet(string set){
   
}

void Board::randomizeWithNum(){
  int i, j;
  for ( i=0; i<mHeight; ++i ){
    for ( j=0; j<mWidth; ++j ){
      pBoard[i][j] = (rand()%9) + 48;
    }
  }
}

#endif
