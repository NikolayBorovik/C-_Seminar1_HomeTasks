// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

System.Console.Write("Enter your 1st number: ");
string strNumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(strNumber1);
System.Console.Write("Enter your 2nd number: ");
string strNumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(strNumber2);
System.Console.Write("Enter your 3rd number: ");
string strNumber3 = Console.ReadLine();
int number3 = Convert.ToInt32(strNumber3);
int max = 0;
int min = 0;
if(number1 > number2)
{
    max = number1;
    min = number2;
}
else
    {
        max = number2;
        min = number1;
    }

if(number3 >max)
{
    max = number3;
}
else if(number3 < min)
{
    min = number3;
}

System.Console.Write("Max value value = ");
System.Console.WriteLine(max);
System.Console.Write("Min value value = ");
System.Console.WriteLine(min);