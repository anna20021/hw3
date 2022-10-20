// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("number");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number);
int a = 1;
int b = 1;

while (a <= number)
{
b = a * b;

Console.WriteLine(b);
a = a+1;
}
