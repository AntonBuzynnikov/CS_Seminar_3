// 32. Найти сумму чисел от одного до А
int A = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine(sum(A));

double sum(double x)
{
    int sum0 = 0;
    for(int i=1;i <= x; i++)
    {
        sum0 += i;
    }
    return sum0;
}
