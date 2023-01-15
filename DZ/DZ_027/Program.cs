// // // решение через массив
// Console.WriteLine("введите любое число");
// int number = Convert.ToInt32(Console.ReadLine());
// string massive = number.ToString();
// Console.WriteLine($"массив {massive}");  
// int summ = 0;
// Console.WriteLine($"Первоначальная сумма равна {summ}");  
// int size = massive.Length;
// Console.WriteLine($"размер массива равен {size}");  
// int index=0;
// while (index < size)
// {
//     summ=summ + massive[index];
//     index=index+1;
// }
// Console.WriteLine(summ);
// Console.WriteLine(index);

// решение не через массив
Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
int b = 10;
int c = 1;
int summ = number%b/c;
int n = number;
while (n!=0){
    n= number%(b*10)/(c*10);
    number = number/b;
    summ=summ+n;
}
// // int b = number%100/10;
// // int c = number%1000/100;
// Console.WriteLine($"a = {a}");
// Console.WriteLine($"b = {b}");
// Console.WriteLine($"c = {c}");
Console.WriteLine($"сумма чисел = {summ}");