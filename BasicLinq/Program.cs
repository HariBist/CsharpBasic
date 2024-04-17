// int[] age = {12,34,24,22,4,45,32,33,22,12,3,2};
// var a = from i in age where i<20  orderby i select i;
// foreach(int item in a)
// {
//     Console.WriteLine(item);
// }
// Console.ReadLine();

string[] names ={ "hari", "radha","krishna"};
var b = from name in names where name.Contains("i") select name;
foreach(string item in b)
{
    Console.WriteLine(item);
}
