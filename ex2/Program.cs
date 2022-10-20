// Подсчитать сумму цифр в числе
int number = new Random() .Next(1, 1000);
Console.WriteLine(number);
int a = 0;
int b = 0;
int c = 0;
int d= 0;
int x = 0;

if (number >= 100 && number <= 999)
{
a = number / 100;
b = number / 10;
b = b % 10;
c = number % 10;
x= a+b+c;
Console.WriteLine(x);
}
else if ( number < 100 && number >= 10)
{
a = number / 10;
a = a % 10;
b= number / 10;
b= b % 10; 
x= a+b;
    Console.WriteLine("x");
}
else if (number >=1 && number < 10) 
{
Console.WriteLine("number");
}