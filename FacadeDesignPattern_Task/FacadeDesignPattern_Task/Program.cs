namespace FacadeDesignPattern_Task;

class SubsystemA
{
    public void OperationA()
    {
        Console.WriteLine("Subsystem A - Operation A");
    }
}

class SubsystemB
{
    public void OperationB()
    {
        Console.WriteLine("Subsystem B - Operation B");
    }
}

class SubsystemC
{
    public void OperationC()
    {
        Console.WriteLine("Subsystem C - Operation C");
    }
}

class Facade
{
    private SubsystemA subsystemA;
    private SubsystemB subsystemB;
    private SubsystemC subsystemC;

    public Facade()
    {
        subsystemA = new SubsystemA();
        subsystemB = new SubsystemB();
        subsystemC = new SubsystemC();
    }

    public void Operation()
    {
        Console.WriteLine("\nFacade - Operation");
        subsystemA.OperationA();
        subsystemB.OperationB();
        subsystemC.OperationC();
    }
}

class Client
{
    static void Main()
    {
        // Facade oluştur
        Facade facade = new Facade();

        facade.Operation();

        Console.ReadKey();
    }
}
