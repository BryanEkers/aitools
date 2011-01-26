/// <author> Simon Symeonidis Bryan Ekers </author>
/// TODO 
///   Must start creating the interface here
///   for quick commands.
using System.Collections.Generic;
using System;

public class Executor{
  public static void Main(String[] argv){
    // Data Structs
    Dictionary<string, int> dic = new Dictionary<string, int>();
    string s; 
    // Primitives
    bool   finished = false;
    int    cmd;

    /// Begin the command definitions
    dic["end"]        = 1;
    dic["quit"]       = 1;
    dic["exit"]       = 1;
    // -- 
    dic["newboard"]   = 2;
    dic["help"]       = 3;
    dic["printboard"] = 4;
    dic["printraw"]   = 5;
    /// End the command definitions

    Board b = new Board(1,1);

    while(!finished){
      Console.Write("ex::");
      s = Console.ReadLine();

      try{
        cmd = dic[s];
      }
      catch(Exception e){
        cmd = 0;
      }

      switch(cmd){
        case 0:
          Console.WriteLine("There's an error with your syntax. Type help");
          break;
        case 1:
          Console.WriteLine("Exit! Bye!");
          finished = true;
          break;
        case 2:
	  int w;    // width for the new board
	  int h;    // height for the new board
	  string c; // 
          
	  Console.WriteLine("New board creation");
	  Console.Write("Heigh: ");
	  h = int.Parse(Console.ReadLine());
	  Console.Write("Width: ");
	  w = int.Parse(Console.ReadLine());
	  Console.Write("Fill with [A]lphabetic chars, [N]umeric chars, [S]pecific [a|n|s] : ");
	  c = Console.ReadLine();

          Console.Write("Creating board [{0},{1}] with {2} option ... ", h, w, c);
	  b = new Board(w,h);
	  switch(c[0]){
	    case 'a':
	      b.randAlpha();
	      break;
	    case 'n':
	      b.randNum();
	      break;
	    case 's':
	      b.manualEntry();
	      break;
	    default:
	      // TODO 
	      break;
	  }
	  
	  Console.WriteLine("Done!");

	  break;
        case 3: // help
          Console.WriteLine("Here are the actions you can perform: ");
          Console.WriteLine("\tend|quit : close the current program");
          Console.WriteLine("\tnewboard : will generate a new board with your specifications");
          Console.WriteLine("\thelp     : display this");
          break;
	case 4: // printboard
	  b.printArr();
	  break;
	case 5: // printraw
          b.printRaw();
	  break;
        default:
          break;
      }
    }

  }
}

