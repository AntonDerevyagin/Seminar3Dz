string n = Console.ReadLine();
int len = n.Length;

if ( len == 5)
{
    if (n[0]==n[4] && n[1]==n[3])
    {Console.WriteLine($"Число {n} является палиндромом");
}
else
{
    Console.WriteLine($"Число {n} не палиндром");
}
}
else
{
    Console.WriteLine("Число не пятизначное");
}