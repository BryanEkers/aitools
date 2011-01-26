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

  // This will take care of entry manually
  // For now let's assume one char per square
  public void manualEntry(){
    int i, j;
    int c; 
    for (i=0; i<mWidth; ++i){
      for (j=0; j<mHeight; ++j){
        Console.Write("[{0},{1}] : ", i, j);
	c = int.Parse(Console.ReadLine());
	mSquare[i,j] = (char) c;
      }
    }
  }

  public void printRaw(){
    int i, j;

    for (i=0; i<mWidth; ++i){
      for (j=0; j<mHeight; ++j){
        Console.Write("{0} ",  (int)mSquare[i, j]);
      }
      Console.Write("\n");
    }
 
  }

  public void printArr(){
    int i, j;

    for (i=0; i<mWidth; ++i){
      for (j=0; j<mHeight; ++j){
        Console.Write("{0}",  mSquare[i, j]);
      }
      Console.Write("\n");
    }
  }
  
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
  private char[,] mSquare;
  private int     mWidth;
  private int     mHeight;
}
