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
string[] IfFewer(string[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        string element = inArray[i];
        if (element.Length <= 3) count += 1;
    }
    string[] result = new string[count];
    count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        string element = inArray[i];
        if (element.Length <= 3)
        {
            result[count] = element;
            count++;
        }
    }
    return result;
}
string textline = Prompt("Введите слова через пробел: ");
string[] text = StringToArray(textline);
WriteLine(string.Join(", ", IfFewer(text)));