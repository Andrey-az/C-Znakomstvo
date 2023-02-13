Console.WriteLine("Введите число a");
string text_a = Console.ReadLine()!;
int number_a;
int.TryParse(text_a , out number_a);

Console.WriteLine("Введите число b");
string text_b = Console.ReadLine()!;
int number_b;
int.TryParse(text_b , out number_b);

int a = number_a;
int b = number_b;
int result = number_a;

if (b > a) result = number_b;
        else result = number_a;

Console.Write("Максимальное число ");
Console.Write(result);
