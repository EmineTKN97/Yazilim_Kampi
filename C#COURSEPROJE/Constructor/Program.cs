Customer customer = new Customer { Id = 1, LastName = "tekin", FirstName = "emine", City = "İstanbul" };
Customer customer1 = new Customer(2, "fatma", "turan", "Ankara");
Console.WriteLine(customer1.FirstName);


class Customer
{
    //default constructor
    public Customer()
    {
        Console.WriteLine("Default constructor çalıştı");
    }
    public Customer(int id, string name, string lastname, string city)
    {
        Id = id;
        LastName = lastname;
        FirstName = name;
        City = city;
    }
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string City { get; set; }
}