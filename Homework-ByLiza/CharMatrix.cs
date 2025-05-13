using System;

class CharMatrix
{
    private char[,] matrix;
    private int rows;
    private int cols;

    public CharMatrix(char[,] input)
    {
        matrix = input;
        rows = matrix.GetLength(0);
        cols = matrix.GetLength(1);
    }

    public string this[int rowIndex]
    {
        get
        {
            if (rowIndex < 0 || rowIndex >= rows)
                throw new IndexOutOfRangeException("Неправильний індекс рядка.");

            string result = "";
            for (int j = 0; j < cols; j++)
            {
                result += matrix[rowIndex, j];
            }

            return result;
        }
    }
 
    public int ConsonantCount
    {
        get
        {
            int count = 0;
            string vowels = "аеєиіїоуюяAEЄИІЇОУЮЯ";  

            
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < cols; j++) 
                {
                    char ch = matrix[i, j]; 
                    if (Char.IsLetter(ch) && !vowels.Contains(Char.ToLower(ch))) 
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}


