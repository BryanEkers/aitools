/// <author> Simon Symeonidis </author>

using System;

public class Board{
  /// default constructor -- 
  public Board(int x, int y){
    mWidth  = x;
    mHeight = y;
    mSquare = new char[x,y];
  }

  // Interface for the alpha generator
  public void randAlpha(){
    randomGen(0);
  }
  
  // Interface for the number generator
  public void randNum(){
    randomGen(1);
  }

  public void printArr(){
    int i;
    int j;

    for (i=0; i<mWidth; ++i){
      for (j=0; j<mHeight; ++j){
        Console.Write("{0}",  mSquare[i, j]);
      }
      Console.Write("\n");
    }
  }

  private char[,] mSquare;
  private int     mWidth;
  private int     mHeight;

  
  /** All the ugly work is done here
  * 0 : for captital alphabetic char
  * 1 : for nums 0-9
  */
  private void randomGen(int csw){
    int i;
    int j;
    Random rand = new Random();

    for (i=0; i<mWidth; ++i){
      for (j=0; j<mHeight; ++j){
        switch(csw){
	  case 0:
	    mSquare[i, j] = (char)(rand.Next(26) + 65);
	    break;
	  case 1:
	    mSquare[i, j] = (char)(rand.Next(10) + 48);
	    break;
	  default:
	    break;
        }
      }
    }
  }
}
