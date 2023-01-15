// See https://aka.ms/new-console-template for more information

int Bitdepth (int number)
{
    int count = 0;
    int i = number;
    while (i > 0)
    {
        i = i/10;
        count +=1;
    }
    return count;

}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В числе {num} всего {(Bitdepth (num))} цифр");
