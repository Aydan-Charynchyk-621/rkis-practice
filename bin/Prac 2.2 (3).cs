namespace ConsoleApplication;

class TwoInt
{
    private int num1;
    private int num2;
 
    public int Num1
    {
        get
        {
            return num1;
        }
        set
        {
            num1 = value;
        }
    }
 
    public int Num2
    {
        get
        {
            return num2;
        }
        set
        {
            num2 = value;
        }
    }
}
 
class Program
{
    static int Sum(TwoInt num)
    {
        Console.WriteLine("Введите первое значение:");
        num.Num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе значение:");
        num.Num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{num.Num1} + {num.Num2} = {num.Num1 + num.Num2}");
        return 0;
    }
        
    static void Comparison(TwoInt num)
    {
        if (num.Num1 > num.Num2)
        {
            Console.WriteLine("Первая переменная больше");
        }
        else if (num.Num1 < num.Num2)
        {
            Console.WriteLine("Вторая переменная больше");
        }
        else
        {
            Console.WriteLine("Первая и вторая переменная равны");
        }
    }
 
    static void Main(string[] args)
    {               
        TwoInt show = new TwoInt();
        Sum(show);
        Comparison(show);
    }
}
