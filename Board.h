#ifndef _BOARD_H_
#define _BOARD_H_

/* Class definition for the board generation.

NOTE: pBoard[x][y] format / rows vs cols

Arguably this could have been implemented with templates for better flexibility
in specifying the size of the table later on, but on the larger view, 65k x 65k
size board is already more than enough for what is needed. Later on, I might add
the posibility to link different boards together in order to have a board as a
BIGGER square of the world.

For example:
create two boards: a, b both having sizes 65k x 65k
  
  65+65k
  a<->b 65k

  @author Simon (psyomn) Symeonidis
  @file
  @date Wed Jan 19 06:32:35 EST 2011
*/
#include <cstdlib> // For random
#include <time.h>    // For srand

class Board {
public:
  /** Class constructor, and restrict the construction to require two
  unsigned short intergers in order for world creation. this allows us
  for a width and heigh of max ~65k which is more than what we need.
  short ints are half the size of ints so this is a small form of
  optimization.*/
  Board(unsigned short, unsigned short);
  /** This is the standard class destructor */
  ~Board();
  // --== Mutators Accessors ==--
  char getPos(unsigned short, unsigned short);
  // --== Operator Overloading ==--
  /** The operator version for getPos */
  //operator[][]();
  // --== Functions ==--
  /** Responsible of pringting the array*/
  void print();
  /** Randomize the contents with values of 0->255 (max value of a char) */
  void randomize();
  /** Randomize with a set of values*/
  void randomizeWithSet( char[] );
  /** Randomize with a set represented as a string. Overloaded function */
  void randomizeWithSet( string );
  /** Randomize with numeric values 0-9 */
  void randomizeWithNum();
private:
  /** This is the actual board. Each char =  1 byte**/
  char** pBoard;
  /** Store the width of said board in this var for future reference. 2 bytes */
  unsigned short mWidth;
  /** Store the width of said board in this var for future reference. 2 bytes */
  unsigned short mHeight;
};

#endif
