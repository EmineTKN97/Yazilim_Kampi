using Interfaces;

PersonManager manager = new PersonManager();
manager.Add(new Customer { Id = 1, Name = "Emine", SurName = "TEKİN", Adress = "İstanbul" });
Student student = new Student();
student.Id = 1;
student.Name = "Derya";
student.SurName = "DENİZ";
student.Depertmant = "Bilgisayar Programcılığı";
manager.Add(student);

Demo();

static void Demo()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new SqlServerCustomerDal());
}
ICustomerDal[] CustomerDals = new ICustomerDal[2]
{ new SqlServerCustomerDal(), new OracleCustomerDal() };
foreach (var customerDal in CustomerDals)
{

    customerDal.Add();
}
interface IPerson
{
    int Id { get; set; }
    string Name { get; set; }
    string SurName { get; set; }
}
class Customer : IPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public string Adress { get; set; }
}
class Student : IPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public string Depertmant { get; set; }
}
class PersonManager
{
    public void Add(IPerson person)
    { Console.WriteLine(person.Name); }
}
