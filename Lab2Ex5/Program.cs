/*Să se scrie un program care citeşte de la tastatură un şir de n numere
naturale şi determină media aritmetică a celor pare, n fiind citit de la
tastatra*/

Console.WriteLine("Enter the number of elements: ");

int n = int.Parse(Console.ReadLine());

int sum = 0;
int count = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter a number: ");
    int number = int.Parse(Console.ReadLine());

    if (number % 2 == 0)
    {
        sum += number;
        count++;
    }
}

if (count > 0)
{
    double average = (double)sum / count;
    Console.WriteLine("The arithmetic mean of the even numbers is: " + average);
}
else
{
    Console.WriteLine("There are no even numbers to calculate the arithmetic mean.");
}