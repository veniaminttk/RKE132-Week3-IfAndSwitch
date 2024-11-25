
using System.ComponentModel.Design;

Console.WriteLine("Enter a number!");

int userNum = Convert.ToInt32(Console.ReadLine());

//четное или нечетное число

int result = userNum % 2;

Console.WriteLine(result);

if(result != 0) //не равно
{
    Console.WriteLine("User number is odd"); 
}
else
{
    Console.WriteLine("User number is even");
}