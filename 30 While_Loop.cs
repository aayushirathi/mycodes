using System;
namespace geeksforgeeks {
class GFG {
  public static void Main()
  {
    int[] intArray;
    intArray = new int[5];
    intArray[0] = 10;
    intArray[1] = 20;
    intArray[2] = 30;
    intArray[3] = 40;
    intArray[4] = 50;

  Console.Write("while loop: ");
  int j=0;
  while(j<intArray.Length){
    Console.Write(" "+intArray[j]);
    j++;
  }
  }
}
}