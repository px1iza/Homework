class Program
{
    static void Main()
    {
        char[,] data = {
            { 'К', 'о', 'т' },
            { 'С', 'и', 'н' },
            { 'П', 'а', 'в' }
        };

        CharMatrix matrix = new CharMatrix(data);

        Console.WriteLine("Рядок з індексом 1: " + matrix[1]); // Виведе: Син
        Console.WriteLine("Кількість приголосних: " + matrix.ConsonantCount); // Виведе: 6
    }
}