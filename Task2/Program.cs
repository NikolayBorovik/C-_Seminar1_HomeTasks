// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

System.Console.Write("Enter your 1st number: ");
string strNumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(strNumber1);
System.Console.Write("Enter your 2nd number: ");
string strNumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(strNumber2);
if(number1 > number2)
{
    System.Console.Write("Max value value = ");
    System.Console.WriteLine(number1);
    System.Console.Write("Min value value = ");
    System.Console.WriteLine(number2);
}
else
{
    System.Console.Write("Max value value = ");
    System.Console.WriteLine(number2);
    System.Console.Write("Min value value = ");
    System.Console.WriteLine(number1);
}

// int max = 0
// int min = 0
// if(number1 > number2)
// {
//     max = number1;
//     min = number2;
// }
// else
//     {
//         max = number2;
//         min = number1;
//     }
// System.Console.Write("Max value value = ");
// System.Console.WriteLine(max);
// System.Console.Write("Min value value = ");
// System.Console.WriteLine(min);
