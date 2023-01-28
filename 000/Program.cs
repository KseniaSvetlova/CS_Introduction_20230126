// С клавиатуры вводятся два числа. Найти и выывести на экран их сумму.
//string s;
int a,b,sum;
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
sum=a+b;
//1. Конкатинация (склеивание)строк.
System.Console.WriteLine(a+"+"+b.ToString()+"="+Convert.ToString(sum));
//2. Форматированный вывод.
System.Console.WriteLine("{0:F2}+{1:E5}={2:G4}",a,b,sum);
//3. Интерполяция строк.
System.Console.WriteLine($"{a:F2}+{b:E5}={sum:G4}");

// С клавиатуры вводятся два числа. Найти и выывести на экран максимальное з них.

int max;
if(a>b)
    max=a;
else
    max=b;
    System.Console.WriteLine($"max={max}");
