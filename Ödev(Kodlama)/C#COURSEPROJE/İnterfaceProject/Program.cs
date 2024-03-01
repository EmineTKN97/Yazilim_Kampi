//İNTERFACE NEWLENMEZ
IPersonManager customManager = new CustomerManager();
customManager.Add();
customManager.Update();
IPersonManager employeeMnaager = new EmployeeManager();
employeeMnaager.Add();
employeeMnaager.Update();
//yazılımda değişimi sağlar
ProjectManager projectManager = new ProjectManager();
projectManager.Add(new InternManager());
interface IPersonManager
{
    void Add();
    void Update();

}
class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Müşteri Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri Güncellendi");
    }
}
class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Personel Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Personel Günncellendi");
    }
}
class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("stajyer Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("stajyer Güncellendi");
    }
}
class ProjectManager
{
    public void Add(IPersonManager personManager)
    { 
    personManager.Add();
    }
}
