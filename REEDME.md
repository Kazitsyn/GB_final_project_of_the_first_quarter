
<image src = "start.png">

# [Решение:](https://github.com/Kazitsyn/GB_final_project_of_the_first_quarter/blob/main/Task/Program.cs)
Разделим задачу на 3 части 
* ввод
* основной метод решения
* вывод

### Блок-схема основного метода решения
<image src = "blank.png">

* ### метод ввода

```c#
string[] InputArr(char x = ' ')
{

    Console.Write($"Введите строки разделяющим символом в скобках ({x}): ");
    string words = Console.ReadLine()?? " ";
    return words.Split(x);
}
```
* ### основной метод решения
```c#
string[] SelectItem(string[] arr, int selectLength = 3)
{
    int count = 0;

    foreach (string item in arr)
    {
        if (item.Length <= selectLength)
        {
            count++;
        } 
    }
    string[] result = new string[count];

    if (count == 0) return result;
    else
    {
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= selectLength) 
            {
                result[index] = arr[i];
                index++;
            }
        }
        return result;
    }
}
```

* ### метод вывода
```c#
void Print(string[] arr)
{
    if (arr.Length == 0) Console.WriteLine("[]");
    else
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 0)
            {
                Console.Write($"[{arr[i]}");
                if (i == arr.Length-1) Console.Write("]");
                else Console.Write(", ");
            }
            else if (i< arr.Length-1)
            {
                Console.Write($"{arr[i]}, ");
            }
            else 
            {
                Console.Write($"{arr[i]}]");
            }
        }
        
    }
}

void PrintResult(string[] arr, string[] result)
{
    Print(arr);
    Console.Write(" --> ");
    Print(result);
    Console.WriteLine();
}
```
## тело программы Main
```c#
string [] primer1 = {"hello", "2", ":-)"};
string [] primer2 = {"1234", "1567", "-2", "computer science"};
string [] primer3 = {"Russia", "Demmark", "Kazan"};

PrintResult(primer1, SelectItem(primer1));
PrintResult(primer2, SelectItem(primer2));
PrintResult(primer3, SelectItem(primer3));

string[] primerInput = InputArr();
PrintResult(primerInput, SelectItem(primerInput));
```
### вывод консоли
```c#
[hello, 2, :-)] --> [2, :-)]
[1234, 1567, -2, computer science] --> [-2]
[Russia, Demmark, Kazan] --> []

Введите строки разделяющим символом в скобках ( ): Прошла первая четверть обучения в GB
[Прошла, первая, четверть, обучения, в, GB] --> [в, GB]
```
# The end