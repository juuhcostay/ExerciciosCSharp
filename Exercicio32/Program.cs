// See https://aka.ms/new-console-template for more information
float N;
Console.WriteLine("Digite o valor de N: ");
N = float.Parse(Console.ReadLine());

if (N <= 10)
{
    Console.WriteLine("F1");
}
else if ( N <= 100)
{
    Console.WriteLine("F2");
}
else if (N > 100)
{
    Console.WriteLine("F3"); 
}
