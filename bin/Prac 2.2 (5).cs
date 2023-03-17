namespace Applicaion;

public class designer
{
    private int property1;
    private string property2;

    public designer(int pr1, string pr2) 
    {
        property1 = pr1;
        property2 = pr2;
    }

    public designer() 
    {
        property1 = 314;
        property2 = "Комната";
    }

    ~designer()
    {
        Console.WriteLine("Объект удален");
    }

    public int Property1
    {
        get
        {
            return property1;
        }
        set
        {
            property1 = value;
        }
    }

    public string Property2
    {
        get
        {
            return property2;
        }
        set
        {
            property2 = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        designer object1 = new designer(621, "Aydan"); 
        Console.WriteLine("Свойство первого объекта: " + object1.Property1 + ", " + object1.Property2);
        designer object2 = new designer();
        Console.WriteLine("Свойство второго объекта: " + object2.Property1 + ", " + object2.Property2); 

        object1.Property1 = 2004;
        object1.Property2 = "год";
        Console.WriteLine("Свойство первого объекта после обновления: " + object1.Property1 + ", " + object1.Property2);
        GC.Collect();
    }
}
