using System;
using static System.Console;
Clear();
string Prompt(string message)                                  // Функция для ввода переменных
{
    Write(message);                                            // выводим заданный текст на экран
    string result = ReadLine();                                // считываем введённые данные в строку                     
    return result;
}
string[] StringToArray(string stringArray)                     // Функция для преобразования строки в массив
{
    string[] result = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries); 
    return result;
}
string[] IfFewer(string[] inArray)                              // Функция для выбора слов, состоящих из <= 3 букв
{
    int count = 0;                                              // Счётчик для нахождения длины финального массива и его наполнения
    for (int i = 0; i < inArray.Length; i++)
    {
        string element = inArray[i];
        if (element.Length <= 3) count += 1;
    }
    string[] result = new string[count];                        // Создаём массив длиной равной счётчику
    count = 0;                                                  // Обнуляем счётчик для наполнения массива
    for (int i = 0; i < inArray.Length; i++)
    {
        string element = inArray[i];
        if (element.Length <= 3)
        {
            result[count] = element;                            // Каждое подходящее слово добавляем в массив
            count++;                                            // Увеличиваем счётчик
        }
    }
    return result;                                              // Возвращаем получившийся массив
}
string textline = Prompt("Введите слова через пробел: ");       // Указания для пользователя и создание строки с введёнными словами
string[] text = StringToArray(textline);                        // Преобразуем строку в массив с отдельными словами
Write("Слова, в которых букв меньше или равно 3: ");            // Выводим результат
WriteLine(string.Join(", ", IfFewer(text)));