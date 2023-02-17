var numbers= new []{3,6,12,-1};
var count = numbers.Length;
 foreach (var i in numbers)
 {
     Console.Write(i+"   ");
 }
 Console.Write("\n");
var array= new int[count];
Console.Write("\tGiven elements of newarray: ");
int n = 0;
foreach (var j in array)
{
    array[j] = numbers[count - 1 - n];
    Console.Write( array[j]+ "   ");
    ++n;
}