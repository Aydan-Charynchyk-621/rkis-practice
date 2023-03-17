namespace ConsoleApplication1;
class Train
{
    public string Destination;
    public int TrainNumber;
    public DateTime Departure;
 
    public void Info()
    {
        Console.WriteLine("Пункт назначения: {0}\nВремя отправление: {1}", Destination, Departure);
    }
    public Train(string destination, int TrainNumber, DateTime departure)
    {
        this.Destination = destination;
        this.TrainNumber = TrainNumber;
        this.Departure = departure;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Train[] trainlist = 
        {
            new Train ("Абакан", 11, new DateTime(2023, 3, 27, 15, 30, 0)),
            new Train ("Кызыл", 12, new DateTime(2023, 4, 27, 21, 00, 0)),
            new Train ("Томск", 13, new DateTime(2023, 3, 14, 10, 40, 0)),
            new Train ("Красноярск", 14, new DateTime(2023, 3, 21, 18, 30, 0)),
            new Train ("Новосибирск", 15, new DateTime(2023, 4, 21, 7, 00, 0))
        };
        
        Console.Write("Введите номер поезда - ");
        int readline = Convert.ToInt32(Console.ReadLine());
        foreach(Train train in trainlist)
        {
            if (train.TrainNumber == readline)
            train.Info();
        }
    }
}
