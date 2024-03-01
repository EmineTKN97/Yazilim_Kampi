
using Proje.Business;
using Proje.DataAccess.Concretes;
using Proje.Entities;

Console.WriteLine("Hello, World!");


CourseManager courseManager = new(new CourseDal());
List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + "-" + courses2[i].Description);
}
IndividualCustomer customer = new IndividualCustomer();
customer.Id = 1;
customer.NationalIdentity = "12345678922";
customer.FirstName = "Test";
customer.LastName = "TEST";
customer.CustomerNumber = "123456";
IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 2;
customer1.NationalIdentity = "12345678923";
customer1.FirstName = "Test1";
customer1.LastName = "TEST1";
customer1.CustomerNumber = "123457";
CoorParateCustomer customer2 = new CoorParateCustomer();
customer2.Id = 3;
customer2.Name = "Kodlamaio";
customer2.CustomerNumber = "654779";
customer2.TaxNumber = "12345678987";
CoorParateCustomer customer3 = new CoorParateCustomer();
customer3.Id = 4;
customer3.Name = "Abc";
customer3.CustomerNumber = "654779";
customer3.TaxNumber = "12345678985";