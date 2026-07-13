namespace ConsoleApp1;

public delegate void Notify();

public class Process
{
    public event Notify ProcessCompleted;
    public void StartProcess()
    {
        Console.WriteLine("\tProcess Started!");
        Console.WriteLine("\tProcessing...");
        OnProcessCompleted();
    }

    protected virtual void OnProcessCompleted() => ProcessCompleted?.Invoke();
}

public class Event
{
    public static void Main()
    {
        Process p1 = new();
        p1.ProcessCompleted += p1_ProcessCompleted;
        p1.StartProcess();
    }

    public static void p1_ProcessCompleted() => Console.WriteLine("\tProcess Completed!");
}