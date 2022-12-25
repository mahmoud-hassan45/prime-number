// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Transactions;

int i,j;
Console.WriteLine("enter the first number ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("enter the max");
int max = int.Parse(Console.ReadLine ());
for (i = a; i <= max; i++)
{
    int count = 0;
    for (j = 1; j <= i; j++)
    {

        if (i % j == 0)
        { count = count + 1; }
    }

    if (count <= 2)
    {
        Console.WriteLine( i ); 
    }


}







