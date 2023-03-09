using System;
using static System.Console;
Clear();
string Prompt(string message)                                  // Функция для ввода переменных
{
    Write(message);                                            // выводим заданный текст на экран
    string result = ReadLine();                                // считываем введённые данные в строку                     
    return result;
}