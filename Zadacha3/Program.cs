Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
int res = 0;
for (i=1; i <= n; i++)
{
   res = i*i*i;
   Console.WriteLine($"{res}");
}

