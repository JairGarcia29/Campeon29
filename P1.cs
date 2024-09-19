internal class Program
{
    private static void Main(string[] args)
    {
        double sbruto, ventas, salario=0, total, años, bono=0, dscto=0, sueldoto;
        string nom;
        Console.WriteLine("Inserte su nombre");
        nom=Console.ReadLine();
        Console.WriteLine("Inserte su salario bruto");
        sbruto=double.Parse(Console.ReadLine());
        Console.WriteLine("Inserte su numero de ventas");
        ventas=double.Parse(Console.ReadLine());
        Console.WriteLine("Inserte su numero de años en la empresa");
        años=double.Parse(Console.ReadLine());
        if (ventas <= 600) 
        {
            bono = ventas * 0.05;
        }else
        {
            if (ventas >= 600 || ventas <=3000)
            {
                bono = ventas * 0.07;
            }
            else
            {
                if (ventas > 3000)
                {
                    bono = (ventas * 0.06) + 300;
                }
            }
        }
        total = sbruto + bono;
        if (años <= 3)
        {
            dscto = total * 0.065;
        } else if (años >= 4)
        {
            dscto = total * 0.045;
        }
        sbruto= total - dscto;
        Console.WriteLine($"Nombre:{nom}");
        Console.WriteLine($"Su salario bruto es: {sbruto}");
        Console.WriteLine($"Su numero de ventas es:{ventas} ");
        Console.WriteLine($"Numero de años en la empresa: {años}");
    }
}