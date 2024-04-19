string[] names = {"B123","C234","A345","c15","B177","G3003","c235","B179"};
var a = from name in names where name.Contains("B") select name;
 foreach(var i in a){
    Console.WriteLine(i);
    // if(name.StartsWith("B"))
    // {
    // Console.WriteLine(name);
    // }
 }
//  public abstract class Squre
//  {
//     public abstract int Squre();

//  }
//  public class second : Squre
//  {
//     public int length;
//     public int width;
//     public second(int l=0, int w=0)
//     {
//         length =l;
//         width=w;
//     }
//     public override int square()
//     {
//         return length*width;
//     }
//     public void display()
//     {
//         Console.WriteLine($"Squre:{0}"+squre());
//     }
//  }
//  second s = new second();
//  s.second(2,8);
//  s.display();