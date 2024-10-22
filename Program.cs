internal class Program
{
    static void Main(string[] args)
    {
        ListInt list = new ListInt();


        list.Add(14);
        list.Add(28);
        list.Add(42);

        Console.WriteLine("Arraya elave edirik ");
        Console.WriteLine("Arrayin elementleri");
        list.AddRange(64, 80, 96);
        Console.WriteLine(list);

        Console.WriteLine("Elementin olub olmadigini yoxlayiriq");
        Console.WriteLine(list.Contains(14));
        Console.WriteLine("AArrayin cemi");
        Console.WriteLine(list.Contains(50)); 
        Console.WriteLine(list.Sum());

        Console.WriteLine("Her hansisa indexdeki element silinir");
        list.Remove(64);
        Console.WriteLine(list);

        Console.WriteLine("Arrayden silinir:");
        list.RemoveRange(42, 80);
        Console.WriteLine(list);
    }
}