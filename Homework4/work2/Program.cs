// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int num = 25;
System.Console.WriteLine(GetSumNumbers(num));

static int GetSumNumbers(int num)
{
    int s = 0;
    for(int i = 0; i <= num; i++)
    {
        s = s + (num % 10);
        num = num / 10;
    }
    return s;
}
