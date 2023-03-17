namespace ConsoleApplication1;

public class Program
{
    public class Student
    {
        private string surname;
        private DateTime dateOfBirth;
        private int group;
        private int[] progress = {};


        public void Info()
        {
            Console.WriteLine("Фамилия: {0}\nДата Рождения: {1}\nГруппа: {2}", surname, dateOfBirth, group);
            foreach(int arr in progress)
            Console.Write(arr + " ");
        }
        
        public void Changeinfo(string surname)
        {
            this.surname = surname;
        }
        public void Changeinfo(string surname, DateTime dateOfBirth)
        {
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
        }
        public void Changeinfo(string surname, DateTime dateOfBirth, int group)
        {
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.group = group;
        }

        public Student(string surname, DateTime dateOfBirth, int group, int [] progress)
        {
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.group = group;
            this.progress = progress;
        }
    }

    static void Main()
    {
        Student myInfo= new Student("Maksimov", new DateTime(1991, 01, 30), 714, new int [5] {4, 3, 4, 5, 2});

        myInfo.Changeinfo(surname: "Charynchyk", dateOfBirth: new DateTime(2004, 11, 27), group: 621);
        
        myInfo.Info();
    }
}
