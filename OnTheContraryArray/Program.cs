var numbers= new []{3,6,12,-1};
var count = numbers.Length;
 for (var i = 0; i < count ; ++i)
 {
     Console.Write(numbers[i]+"   ");
 }
 Console.Write("\n");
var array= new int[count];
Console.Write("\tGiven elements of newarray: ");
for (var j = 0; j < count; ++j)
{
    array[j] = numbers[count - 1 - j];
    Console.Write(array[j] + "   ");
}