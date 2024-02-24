/*Scrieti un program care va determina daca un numar negativ citit de
la tastatura este divizibil cu 2 si nu este divizibil cu 6*/

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0 && number % 6 != 0)
{
    Console.WriteLine(number + " is divisible by 2 and not by 6.");
}
else
{
    Console.WriteLine(number + " is either not divisible by 2 or divisible by 6.");
}