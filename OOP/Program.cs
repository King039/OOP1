using _2;

Console.Write("Введите марку автомобиля: ");
string name = Console.ReadLine()!;
Console.Write("Введите обьем топливного бака: ");
double volume = double.Parse(Console.ReadLine()!);
Console.Write("Введите расход бензина на 100 км: ");
double expend = double.Parse(Console.ReadLine()!);
Console.Write("Введите текущее колличество топлива в баке:");
double curent = double.Parse(Console.ReadLine()!);

Auto auto = new Auto(name, volume, expend, curent);
Console.Write("Введите обьем заправки: ");
double addFill = double.Parse(Console.ReadLine()!);
auto.Fide(addFill);
Console.Write($"Колличество топлива в баке: {auto.Curent:F2}");

Console.Write("Введите колличество км: ");
double km = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Расход топлива равен: {auto.Way(km):F2} литров");
Console.WriteLine($"Еще можно проехать {auto.Remains():F2} км");
