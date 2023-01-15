// See https://aka.ms/new-console-template for more information
int summa (int number)
{
    int sum=0;
    for (int i=1;number>=i;i++)
    {
        sum+=i;
    }
    return sum;
}






Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(summa (num));

