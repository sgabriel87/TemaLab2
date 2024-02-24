/*Scrieti un program care va afisa factorialul unui numar n, n fiind citit
de la tastatura.*/

Console.WriteLine("Enter a number to calculate its factorial (number <= 25):");
int n = int.Parse(Console.ReadLine());

long factorial = 1;

for (int i = 1; i <= n; i++)
{
    factorial *= i;
}

Console.WriteLine("The factorial of " + n + " is: " + factorial);