// 37. Компьютер придумывает число и определяет заканчивается ли на чётную цифру куб этого числа.
// Показать кубы чисел, заканчивающихся на чётную цифру

Random random = new Random();
// Random random1 = new Random(105);
// Random random2 = new Random(1023);
// System.Console.WriteLine(random2.Next(1,100));
// System.Console.WriteLine(random.Next(1,100));
// System.Console.WriteLine(random1.Next(1,100));
bool Test(int n)
{
    return n%2==0;
}

for (int i = 0;i<10;i++)
{
    int a = random.Next(1,100);
    int b = (int)Math.Pow(a,3);
    if (Test(a))
        System.Console.WriteLine($"{a}, {b}");
}