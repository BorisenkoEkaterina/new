/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int Digits (int Number)
{
    int num1 = Number / 100;
    int num3  = Number % 10;
    int num2 = (Number - num1*100 - num3)/10;
    return num2;
}

Console.WriteLine("Input your 3digits number:");
int number = Convert.ToInt32(Console.ReadLine());
int result = Digits(number);
Console.WriteLine(result);
/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/
int Digits1 (int numb2)
{
    while (numb2 > 1000)
    {
        numb2 = numb2/10;
    
    }
        if (numb2 < 100)
        {
        Console.WriteLine("третьей цифры нет");
        
        }
        else 
     {
        numb2 = numb2 % 10;
    
        }
      return numb2;    
}
Console.WriteLine("Input your number:");
int number13 = Convert.ToInt32(Console.ReadLine());
int result13 = Digits1(number13);
Console.WriteLine(result13);
/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

void  Day (int numberDay)
{
    if (numberDay>=1 && numberDay <6)
    {
    Console.Write("No");
    }

    else
    {
            
    Console.Write("Yes");
    }
}
Console.Write("inpur days-digit:");
int number1 = Convert.ToInt32(Console.ReadLine());
Day (number1);







