namespace ConsoleApp1;

public class Converter
{
    private Dictionary<char, int> converter = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public int Convert(string romanNum)
    {
        int result = 0;
        int prevValue = 0;

        for (int i = romanNum.Length - 1; i >= 0; i--)
        {
            int curValue = converter[romanNum[i]];

            if (curValue < prevValue)
            {
                result -= curValue;
            }
            else
            {
                result += curValue;
            }
            prevValue = curValue;
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Converter converter = new Converter();

        string romanNum = "MCMXCIV";
        int integer = converter.Convert(romanNum);
        Console.WriteLine("Римская цифра: " + romanNum);
        Console.WriteLine("Преобразование: " + integer);
    }
}
