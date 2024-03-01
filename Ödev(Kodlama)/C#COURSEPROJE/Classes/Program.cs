using Classes;

CustomerManager customerManager = new();
customerManager.Add();
customerManager.Update();
ProductManager productManager = new ProductManager();   
productManager.Add();
productManager.Update();
Customer customer = new Customer();
customer.Firstname = "Emine";
customer.Lastname = "TEKİN";
customer.Id = 1;
customer.Address = "Kocaeli-İzmit";
Customer customer2 = new Customer()
{ 
    Address="İstanbul-maltepe",
    Firstname="Derya",
    Lastname="DENİZ",
    Id = 2
};
Console.WriteLine(customer2.Firstname);



