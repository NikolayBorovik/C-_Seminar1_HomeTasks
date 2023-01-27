// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным 
// (делится ли оно на два без остатка).

System.Console.Write("Enter your number: ");
string strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);
if(number % 2 == 0)
{
    System.Console.WriteLine("Your number is EVEN");
}
else
{
    System.Console.WriteLine("Your number is ODD");
}