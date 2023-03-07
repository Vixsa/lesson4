Console.Write("Введите число A - ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B - ");
int B = int.Parse(Console.ReadLine());
double result = Math.Pow(A, B);
Console.Write($"{result}");