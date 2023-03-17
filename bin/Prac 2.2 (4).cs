namespace ConsoleApplication;

public class Counter
{
    private int num;

    public Counter()
    {
        num = 10;
    }

    public Counter(int initialnum) 
    {
        num = initialnum;
    }

    public void Magnifications() 
    {
        num++;
    }

    public void decrease() 
    {
        num--;
    }

    public int current
    {
        get
        {
            return num;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Counter counter1 = new Counter(); 
        Console.WriteLine("Первое число: " + counter1.current); 
        counter1. Magnifications(); 
        Console.WriteLine("Увеличение: " + counter1.current); 
        counter1.decrease(); 
        Console.WriteLine("Уменьшение: " + counter1.current);

        Counter counter2 = new Counter(20); 
        Console.WriteLine("Второе число: " + counter2.current); 
        counter2.Magnifications();
        Console.WriteLine("Увеличение 2-го числа: " + counter2.current);
        counter2.decrease();
        Console.WriteLine("Уменьшение 2-го числа: " + counter2.current);
    }
}
