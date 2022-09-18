// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на стартевыполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите значения массива через пробел");
string words = Console.ReadLine();
string[] massive  = words.Split(' ', StringSplitOptions.RemoveEmptyEntries);
Console.Write($"[{String.Join("; ", massive)}]");
Console.WriteLine();

string[] result = new string [massive.Length];
int x = 0;

for (int i = 0; i < massive.Length; i++)
{
    if (massive[i].Length <= 3)
    {
      result[x] = massive[i];
      x++;  
    }
}

Console.WriteLine($"{String.Join("; ", result)}");