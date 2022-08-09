/*
Итоговая проверочная работа.

Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

/*
Ниже приведены три пимера для теста работы кода.
Для проверки работоспособности кода с каждым приведенным примером
необходимо с выбранного примера снять признак комментария //,
остальные два примера обязательно должны быть закомментироаны.
*/

int N = 3;
int count = 0;
string[] inputArray = { "hello", "2", "world", ":-)" };
// string[] InputArray = { "1234", "1567", "-2", "computer science" };
// string[] InputArray = { "Russia", "Denmark", "Kazan" };

int FindCount(int N)
{
    for (int i = 0; i < inputArray.Length; i++)
        if (inputArray[i].Length <= N) count++;
    return count;
}

string[] NewArray(string[] inputArray)
{
    int j = 0;
    string[] result = new string[count];
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= N)
        {
            result[j] = inputArray[i];
            j++;
        }
    }
    Console.WriteLine();
    Console.WriteLine("[" + string.Join(", ", result) + "]" + "\n");
    return result;
}


