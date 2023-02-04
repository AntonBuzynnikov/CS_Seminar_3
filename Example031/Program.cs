// 31. Вывести на экран кубы чисел от 1 до N
int N = Int32.Parse(System.Console.ReadLine());

System.Console.WriteLine("Число\tКуб");
for (int i = 1; i <= N; i++)
{
    System.Console.WriteLine("{0}\t{1}",i,Cub(i));
}

double Cub(double x)
{
    return Math.Pow(x,3);
}
