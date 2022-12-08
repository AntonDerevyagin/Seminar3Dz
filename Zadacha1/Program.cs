// 1 Cпособ решения
// string n = Console.ReadLine();
// int len = n.Length;

// if ( len == 5)
// {
//     if (n[0]==n[4] && n[1]==n[3])
//     {Console.WriteLine($"Число {n} является палиндромом");
// }
// else
// {
//     Console.WriteLine($"Число {n} не палиндром");
// }
// }
// else
// {
//     Console.WriteLine("Число не пятизначное");

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine()); // 64846
int res = 0;
for (int m = n;  m > 0; m = m / 10)
{
    res = (res * 10) + (m % 10);
}
if ( n == res)
{
    Console.WriteLine("Число палиндром");
}
else 
{
    Console.WriteLine("Число не палиндром");
}