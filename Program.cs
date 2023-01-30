Console.Clear();

Console.Write("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());

//int m = int.Parse(Console.ReadLine()); // выгоднее с точки зрения использования памяти. тк использует ту же ячейку памяти.
//string? name = Console.ReadLine();

Console.WriteLine($"Результат: {n*5}");


