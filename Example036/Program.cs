// 36. Написать программу вычисления произведения чисел от 1 до N
int N = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine(proiz(N));

double proiz(double x)
{
    int p = 1;
    for(int i = 1; i<=x; i++)
    {
        p = p*i;
    
    }
    return p;
}
