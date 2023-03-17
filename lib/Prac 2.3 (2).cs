namespace ConsoleApplication;

public class Worker
{
    private string surname;
    private string name;
    private int rate;
    private int days;

    public Worker(string name, string surname,int rate, int days)
    {
        this.name = surname;
        this.surname = name;
        this.rate = rate;
        this.days = days;
    }

    public string getSurname()
    {
        return surname;
    }

    public string getName()
    {
        return name;
    }

    public double getRate()
    {
        return rate;
    }

    public int getDays()
    {
        return days;
    }

    public double getSalary()
    {
        return rate * days;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Worker worker = new Worker("Charynchyk", "Aydan", 1000, 31);

        Console.WriteLine("Фамилия работника: " + worker.getSurname());
        Console.WriteLine("Имя работника: " + worker.getName());
        Console.WriteLine("Зарплата работника: " + worker.getSalary());
    }
}
