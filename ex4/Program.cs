// Показать кубы чисел, заканчивающихся на четную цифру
int number = new Random() .Next();
Console.WriteLine(number);
int a = 0;
a = number * number * number;
if (a %2==0)
{
    Console.WriteLine("yes");
}
if (a %2!=0)
{
    Console.WriteLine("no");
}

