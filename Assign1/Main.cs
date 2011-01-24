/// <author> Simon Symeonidis </author>
/// TODO 
///   Must start creating the interface here
///   for quick commands.
using System;

public class Executor{
    public static void Main(String[] argv){
      Board b = new Board(20,84);
      b.randAlpha();
      b.printArr();
      Console.WriteLine("\n");
      b.randNum();
      b.printArr();
      Console.WriteLine("End of Main... and the world");
    }
}

