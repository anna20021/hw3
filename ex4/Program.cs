// Показать кубы чисел, заканчивающихся на четную цифру
int number = new Random() .Next(1, 20);
Console.WriteLine(number);
int a = 0; 
for ( int b= 0; b <= number; b++)
{
a = b*b*b;
if (a %2==0)

    Console.WriteLine(a);
}
