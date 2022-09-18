// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на стартевыполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите значения массива через пробел");
string words = Console.ReadLine();
string[] massive  = words.Split(' ', StringSplitOptions.RemoveEmptyEntries);
Console.Write($"[{String.Join("; ", massive)}]");

string[] result = new string [massive.GetLength];
int x = 0;

for (int i = 0; i < massive.GetLength; i++)
{
    if (massive[i].Length <= 3)
    {
      massive[i] = result[x];
      x++;  
    }
}

Console.Write($"{String.Join("; ", result)}");