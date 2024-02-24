/*Ex 1: Scrieti un program care va calcula valoarea urmatoarei functii pentru
x citit de la tastatura
    7x^(2) , if x ∈ (-∞ ,-2]
    4x- 5 , if x ∈ (-2 ,\frac{1}{ 2}]
    14x - 7 , if x ∈ (\frac{1}{ 2} , ∞)*/

Console.WriteLine("Enter the value of x: ");
double x = double.Parse(Console.ReadLine());

double result;

if (x <= -2)
{
    result = 7 * Math.Pow(x, 2);
}
else if (x <= 0.5)
{
    result = 4 * x - 5;
}
else
{
    result = 14 * x - 7;
}

Console.WriteLine("The result is: " + result);