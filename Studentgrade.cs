Console.WriteLine("Reqem daxil edin");
int grade = Convert.ToInt32(Console.ReadLine());


if (grade < 0 && grade > 100)
{
    Console.WriteLine("Duzgun reqem daxil edin");
}

else if (grade > 90 && grade < 101)
{
    Console.WriteLine("A");
}

else if (grade > 80 && grade < 91)
{
    Console.WriteLine("B");
}

else if (grade > 70 && grade < 81)
{
    Console.WriteLine("C");
}
else if (grade > 60 && grade < 71)
{
    Console.WriteLine("D");
}
else if (grade > 50 && grade < 61)
{
    Console.WriteLine("E");
}

else  
{
    Console.WriteLine("Kesildiniz");
}
