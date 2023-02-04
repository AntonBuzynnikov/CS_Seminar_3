// 35. Подсчитать сумму цифр в числе. Сделать подпрограмму
string N = System.Console.ReadLine();
int size = N.Length;
int digit = Int32.Parse(N);

double sumDigit(double x)
{
    double sum = 0;
    for (int i = 1; i<=x; i++)
    {
        double d;
        d = digit%10;
        sum +=d;
        digit/=10;
    }
    return sum;
}

System.Console.WriteLine(sumDigit(size));