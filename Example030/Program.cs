// 30. Вывести на экран таблицу квадратов чисел от 1 до N
int N = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Число\tКвадрат");
for (int i = 1;i <= N; i++)
{
    System.Console.WriteLine("{0}\t{1}",i,Math.Pow(i,2));
}
