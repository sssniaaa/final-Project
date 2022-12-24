// Написать программу, которая из имеющегося массива
// строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Пример:
// [hello, 2, world, :-)] -> [2, :-)]
// ["1234","1567","-2","computer science"] -> ["-2"]
// ["Russia","Denmark","Kazan"] -> []

void PrintArray(string[] array, string message) // метод для выводв массива
{
    string result = message;
    if (array.Length == 0) result += "There are no elements in array";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]}, ";
    }
    System.Console.WriteLine(result.TrimEnd(' ', ',')); // убираем разделители
}

string[] ParseArray(string[] arrayOrigin) // метод перебирает массив и создаёт новый учитывая требования задачи 
{
    string[] arrayTemp = new string[0];
    for (int i = 0; i < arrayOrigin.Length; i++)
    {
        if (arrayOrigin[i].Length <= 3) // проверка
        {
            Array.Resize(ref arrayTemp, arrayTemp.Length + 1); // увеличиваем размер финального массива
            arrayTemp[arrayTemp.Length - 1] = arrayOrigin[i];
        }
    }
    return arrayTemp;
}

void Main()
{
    System.Console.Clear();
    string[] arrayOrigin = new string[] {"1234","1567","-2","computer science"};
    PrintArray(arrayOrigin, "Original array is:  ");
    string[] arrayNew = ParseArray(arrayOrigin);
    PrintArray(arrayNew, "Array according to conditions of the task: ");
    System.Console.WriteLine();
}

Main();

