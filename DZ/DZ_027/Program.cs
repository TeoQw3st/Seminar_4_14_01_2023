// // решение через массив
Console.WriteLine("Решаем через массив: введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
string massive = number.ToString();
int sum = 0;
int size = massive.Length;
int index=0;
while (index < size)
{
    int numb = int.Parse(Convert.ToString(massive[index]));
    sum=sum + numb;
    index=index+1;
}
Console.WriteLine($"Сумма чисел при решении через массив равна {sum}");


// решение не через массив

Console.WriteLine("---------------");
int summ (int arg){
int b = 10;
int c = 1;
int summ = arg%b/c;
int n = arg;
while (n!=0){
    n= arg%(b*10)/(c*10);
    arg = arg/b;
    summ=summ+n;
}
return summ;
}
// // int b = number%100/10;
// // int c = number%1000/100;
// Console.WriteLine($"a = {a}");
// Console.WriteLine($"b = {b}");
// Console.WriteLine($"c = {c}");
Console.WriteLine("Решаем не через массив: введите любое число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел при решении не через массив равна {summ (number2)}");