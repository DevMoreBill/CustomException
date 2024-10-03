using System;

// Собственный тип исключения
public class CustomException : Exception
{
    public CustomException(string message) : base(message) { }
}

class Program
{
    static void Main(string[] args)
    {
        // Массив из пяти различных видов исключений
        Exception[] exceptions =
        [
      new ArgumentNullException("Аргумент не может быть null"),
      new DivideByZeroException("Деление на ноль"),
      new IndexOutOfRangeException("Индекс находится за пределами допустимого диапазона"),
      new FormatException("Неверный формат данных"),
      new CustomException("Это моё собственное исключение!")
        ];

        try
        {
            // Итерация по каждому типу исключения
            foreach (Exception exception in exceptions)
            {
                throw exception;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Перехвачено исключение: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Блок finally всегда выполняется.");
        }
    }
}
