namespace ConsoleApplication;

public class Worker
{
    public string surname {get; set;}
    public string name {get; set;}
    public int rate {get; set;}
    public int days {get; set;}

    public int getSalary()
    {
        return rate * days;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Worker worker = new Worker();
        worker.surname = "Charynchyk";
        worker.name = "Aydan";
        worker.rate = 1000;
        worker.days = 31;

        Console.WriteLine("Фамилия работника: " + worker.surname);
        Console.WriteLine("Имя работника: " + worker.name);
        Console.WriteLine("Зарплата: " + worker.getSalary());
    }
}
