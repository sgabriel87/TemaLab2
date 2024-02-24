/*Scrieti un program care va determina daca un numar este sau nu
palindrom.*/

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

static bool IsPalindrome(int number)
{
    int originalNumber = number;
    int reversedNumber = 0;

    while (number > 0)
    {
        int remainder = number % 10;
        reversedNumber = reversedNumber * 10 + remainder;
        number /= 10;
    }

    return originalNumber == reversedNumber;
}
if (IsPalindrome(number))
{
    Console.WriteLine(number + " is a palindrome.");
}
else
{
    Console.WriteLine(number + " is not a palindrome.");
}