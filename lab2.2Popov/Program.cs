Console.Write("Введите шестизначное число: ");
int n = int.Parse(Console.ReadLine());
int n0 = n % 10;
n = n / 10;
int n1 = n % 10;
n = n / 10;
int n2 = n % 10;
n = n / 10;
int n3 = n % 10;
n= n / 10;
int n4 = n % 10;
n = n / 10;
int n5 = n % 10;
if (n0 + n1 + n2 == n3 + n4 + n5)
{
    Console.WriteLine("Число счастливое");
}
else
{
    Console.WriteLine("Число не счастливое");
}
