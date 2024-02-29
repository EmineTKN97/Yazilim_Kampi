﻿IWorker[] workers =new IWorker[3];
{
    new Manager();
    new Worker();
    new Robot();
}
foreach (IWorker worker in workers)
{
    worker.Work();
}
IEat[] eats = new IEat[2];
{
    new Manager();
    new Worker();

}
foreach(IEat eat in eats)
{
    eat.Eat();
}


interface IWorker 
{
    void Work();


}
interface IEat
{
    void Eat();
}
interface ISalary {
    void GetSalary();
}
class Manager : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}
class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}
class Robot : IWorker
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}
