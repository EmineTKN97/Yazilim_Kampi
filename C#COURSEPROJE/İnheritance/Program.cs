

Person[] persons =new Person[3];
{
    persons[0]= new Customer { Name = "Ali" };
    persons[1]=new Student { Name = "Ayşe" };
    persons[2]= new Person { Name = "Derya" };

};
foreach (var person in persons)
{
    Console.WriteLine(person.Name);
}

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }

}
class Customer : Person
{
    public string City { get; set; }
}
class Student : Person
{
    public string Department { get; set; }
}