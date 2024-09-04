internal class Program
{
    private static void Main(string[] args)
    {
        unsafe
        {
            Person person = new Person();
            person.Age = 18;
            person.Name = "Test";
            Person* pPerson = &person;
            Console.Write(pPerson->name + " " + pPerson->age);

        }
    }
}

struct Person
{
    //Инкапсуляции нет..
    public string name;
    public int age;

    public string Name
    {
        get { return Name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

}