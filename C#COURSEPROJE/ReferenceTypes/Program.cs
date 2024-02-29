int sayi1 = 10;
int sayi2 = 20;
sayi1 = sayi2;
sayi2 = 100;
Console.WriteLine(sayi1);
int[] sayilar1 = new int[] { 1, 2, 3 };
int[] sayilar2 = new int[] { 10, 20, 30 };
sayilar1 = sayilar2;
sayilar2[0] = 1000;
Console.WriteLine(sayilar1[0]);
Person person1 = new Person();
Person person2 = new Person();
person1.FirstName = "Ayşe";
person2 = person1;
person1.FirstName = "Ece";
Console.WriteLine(person2.FirstName);
Customer customer = new Customer();
customer.FirstName = "Derya";
customer.CreditCardNumber = "23456";
Employee employee = new Employee();
employee.FirstName = "Gamze";
Person person3 = customer;
Console.WriteLine(person3.FirstName);
//boxing yapmış oluyoruz.
Console.WriteLine(((Customer)person3).CreditCardNumber);
//aynı kodu farklı nesnelerde kullanabilmemi sağlamış olur person base class kullanmak
PersonManager manager = new PersonManager();
manager.Add(person3);
manager.Add(customer);
manager.Add(employee);
//Bu bir baseclass old. için atama yaparız.Base classlara onu inherit eden sınıfların referansları atanabilir,tutabilir.
class Person
{
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
}
class Customer:Person
{
    public string CreditCardNumber { get; set; }
}
class Employee : Person
{ 
    public int EmployeeNumber { get; set; } 
}
class PersonManager
{
    //Person base classını kullandığım için burada istersek person,istersek,customer,istersek employee kullanabiliriz.Bu da bizim için bir kolaylık sağlar
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}