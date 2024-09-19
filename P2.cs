
internal class Program
{
    private static void Main(string[] args)
    {
        int p1, verde = 0, azul = 0, rojo = 0;
        String o = "v";
        Console.WriteLine("¿Continuar con el programa? (s/n)");
        o = Console.ReadLine().ToLower();
        while (o == "s")
        {
            Console.WriteLine("Ingrese el ultimo digito de la placa");
            p1= int.Parse(Console.ReadLine());
            if (p1 >= 0 & p1 <= 3)
            {
                verde++;
            }
            else 
            
            if (p1 >= 4 & p1 <= 6)
            {
                azul++;
            }
            else 
            if (p1 >= 7 & p1 <= 9)
            {
                rojo++;
            }
            Console.WriteLine("Continuar con el programa? (v/f)");
             o = Console.ReadLine().ToLower();
        }       
        Console.WriteLine($"Verde: {verde}");
        Console.WriteLine($"Azul: {azul}");
        Console.WriteLine($"Rojo: {rojo}");
        Console.WriteLine($"Total de autos: {azul + verde + rojo}");
    }
}