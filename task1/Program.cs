System.Console.WriteLine("Enter your FirstName : ");
string firstname = Console.ReadLine();
System.Console.WriteLine("Enter your LastName : ");
string lastname = Console.ReadLine();
System.Console.WriteLine("Enter your Age : ");
int age = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter your Address : ");
string address = Console.ReadLine();
System.Console.WriteLine("Enter your FulName : ");
string fulname = Console.ReadLine();
System.Console.WriteLine("Enter your birth Year  : ");
int birthyear = Convert.ToInt32(Console.ReadLine());
Person person = new Person();
person.FirstName = firstname;
person.LastName = lastname;
person.Age = age;
person.Address = address;
person.FullName = fulname;
person.BirthYear = birthyear;
System.Console.WriteLine(person.Information());

class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Address;
    public string FullName;
    public int BirthYear;
    public string Information()
    {
        return $"My name is {FullName} \nMy birth year is {BirthYear}.";
    }
}
