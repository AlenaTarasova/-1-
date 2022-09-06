Console.WriteLine("Введите число");
/*
string num1 = Console.ReadLine();
var iNum1 = int.Parse(num1);
if (iNum1 % 2 == 0)
*/
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"{num1} четное");
    Console.WriteLine($"{num} четное");
}
else
{
    Console.WriteLine($"{num1} не четное");
    Console.WriteLine($"{num} не четное");
}