using System;
class GFG{
  public int Add(int a, int b){
    int sum = a+b;
    return sum;
  }
  public int Add(int a, int b, int c){
    int sum = a+b+c;
    return sum;
  }
  public static void Main(String[] args){
    GFG ob = new GFG();
    int sum1 = ob.Add(4, 5);
    Console.WriteLine("Sum of the two integer values: "+ sum1);
    int sum2 = ob.Add(4, 5, 6);
    Console.WriteLine("Sum of the three interger values: "+ sum2);
  }
}