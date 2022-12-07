Console.WriteLine("Eded daxil edin");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0)
{
    Console.WriteLine("Duzgun eded daxil edin");
}

else if (n % 21 == 0) {
    Console.WriteLine("eded 3-e ve 7-e bolunur");

}
else if (n % 21 != 0) {
    Console.WriteLine("eded 3-e ve 7-e bolunmur");
}



