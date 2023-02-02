// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.


int numberA = 2;
int numberB = 3;
System.Console.WriteLine(numberA);
System.Console.WriteLine(numberB);

System.Console.WriteLine(Exponentiation(numberA, numberB));

int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for(int i=1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}