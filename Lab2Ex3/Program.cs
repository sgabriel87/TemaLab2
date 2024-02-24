/*Scrieti un program care va afisa suma cifrelor unui numar n, n fiind
citit de la tastatura.*/

Console.WriteLine("How many numbers do you want to sum?");
int n = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter number " + (i + 1) + ": ");
    int number = int.Parse(Console.ReadLine());
    sum += number;
}

Console.WriteLine("The sum of the " + n + " numbers is: " + sum);
    