/*Scrieti un program care va afisa suma cifrelor unui numar n, n fiind
citit de la tastatura.*/

Console.WriteLine("How many numbers do you want to sum?");
int n = int.Parse(Console.ReadLine());
int temp = n;

int sum = 0;
while (n > 0)
{
    int digit = n % 10;
    sum += digit;
    n /= 10;
}

Console.WriteLine($"The sum of the digits of {temp} is: {sum}");
    