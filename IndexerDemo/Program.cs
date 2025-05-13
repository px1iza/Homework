using System;

class StudentTable
{
    private string[,] table;
    private int rows;

    public StudentTable(string[,] inputTable)
    {
        table = inputTable;
        rows = table.GetLength(0);
    }

    public string this[string column]
    {
        get
        {
            int colIndex = -1;

            // Визначаємо індекс стовпця за назвою
            if (column == "Name") colIndex = 0;
            else if (column == "Surname") colIndex = 1;
            else if (column == "Patronymic") colIndex = 2;

            if (colIndex == -1)
                throw new ArgumentException("Невірна назва стовпця!");

            // Повертаємо стовпець
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                result += table[i, colIndex] + " ";
            }
            return result.Trim();
        }
    }

    public int NetchayCount
    {
        get
        {
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                if (table[i, 1] == "Нечай") // Перевіряємо прізвище (стовпець з індексом 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

class Program
{
    static void Main()
    {
        string[,] students = {
            { "Іван", "Нечай", "Петрович" },
            { "Олександр", "Іванов", "Володимирович" },
            { "Анна", "Нечай", "Миколаївна" },
            { "Марія", "Сидорова", "Анатоліївна" },
            { "Петро", "Нечай", "Іванович" }
        };

        StudentTable table = new StudentTable(students);

        // Використовуємо індексатор для отримання стовпців
        Console.WriteLine("Імена студентів: " + table["Name"]);
        Console.WriteLine("Прізвища студентів: " + table["Surname"]);
        Console.WriteLine("По батькові студентів: " + table["Patronymic"]);

        // Використовуємо властивість для підрахунку студентів з прізвищем "Нечай"
        Console.WriteLine("Кількість студентів з прізвищем 'Нечай': " + table.NetchayCount);
    }
}