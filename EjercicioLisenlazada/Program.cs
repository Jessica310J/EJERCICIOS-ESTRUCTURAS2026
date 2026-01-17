// Implementación de un nodo

public class Nodo
{
    public int Data;
    public Nodo? Next;

    public Nodo(int data)
    {
        this.Data = data;
        this.Next = null;
    }
}

// Programa principal
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa de Lista Enlazada");
        
        // Crear un nodo de prueba
        Nodo nodo1 = new Nodo(10);
        Console.WriteLine($"Nodo creado con valor: {nodo1.Data}");
    }
}

