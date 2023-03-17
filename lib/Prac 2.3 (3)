namespace ConsoleApplication;

public class Calculation
{
    private string calculationLine;

    public void SetCalculationLine(string line)
    {
        calculationLine = line;
    }

    public void SetLastSymbolCalculationLine(char symbol)
    {
        calculationLine += symbol;
    }

    public string GetCalculationLine()
    {
        return calculationLine;
    }

    public char GetLastSymbol()
    {
        return calculationLine[calculationLine.Length - 1];
    }

    public void DeleteLastSymbol()
    {
        calculationLine = calculationLine.Remove(calculationLine.Length - 1);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculation calculation = new Calculation();

        calculation.SetCalculationLine("Toyota");
        Console.WriteLine("Первая строка: " + calculation.GetCalculationLine());
        calculation.SetLastSymbolCalculationLine('R');
        Console.WriteLine("Строка после добавления: " + calculation.GetCalculationLine());
        Console.WriteLine("Последний символ: " + calculation.GetLastSymbol());
        calculation.DeleteLastSymbol();
        Console.WriteLine("Строка после удаления последнего символа: " + calculation.GetCalculationLine());
    }
}
