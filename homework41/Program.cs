int m = Convert.ToInt32(Console.ReadLine()),
    number, count = 0;

Console.WriteLine(m);
for (int i = 0; i < m; i++)
{
    Console.WriteLine("Число: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count++;
}

Console.WriteLine("Чисел больше 0: " + count);