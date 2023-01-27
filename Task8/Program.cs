// Задача 8: Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.Write("Enter your number: ");
string strNumber = Console.ReadLine();
int numberN = Convert.ToInt32(strNumber);

if(numberN < 1)
{
    System.Console.WriteLine("You have entered a wrong number");
}

int number2 = 2;

// while(numberN >= number2)
// {
//     if(number2 % 2 == 0)
//     {
//         System.Console.Write(number2);
//         System.Console.Write(" ");
//     }
// number2 = number2 + 1;
// }

while(numberN >= number2)
{
    System.Console.Write(number2);
    System.Console.Write(" ");
    number2 = number2 + 2;
}
