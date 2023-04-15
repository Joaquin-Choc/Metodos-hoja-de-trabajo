//metodos que se usaran

public class Figura
{
    public double ro, bt, ht, PrecioB, peso;
    public double l, PrecioT;
    public char CE;
    public int numero;

    public double calcularcirculo()
    {
        return (Math.PI * Math.Pow(ro, 2));
    }

    public double calcularcuadrado()
    {
        double ac;
        ac = (l * l);
        return ac;
    }
    public double calculartriangulo()
    {
        return (bt * ht) / 2;
    }

    public double CalcularPrecio()
    {

        switch (CE)
        {
            case 'A':
                PrecioT = PrecioB + 100;
                break;
            case 'B':
                PrecioT = PrecioB + 80;
                break;
            case 'C':
                PrecioT = PrecioB + 60;
                break;
            case 'D':
                PrecioT = PrecioB + 50;
                break;
        }
        if (peso >= 20 && peso < 40)
        {
            PrecioT = PrecioT + (PrecioB * 0.05);
        }
        else if (peso >= 40)
        {
            PrecioT = PrecioT + (PrecioB * 0.10);
        }
        return PrecioT;
    }

    public void CalcularDivisores()
    {
    
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
                
            }
        }
        
        
    }
    public static void Main()
    {
        Figura e = new Figura();
        Console.WriteLine("Ejercicio no. 1");
        Console.WriteLine("Ingrese la figura que se desea ingresar");
        Console.WriteLine("1. Circulo");
        Console.WriteLine("2. Cuadrado");
        Console.WriteLine("3. Triangulo");
        int op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.WriteLine("Ingrese el radio del circulo");
                e.ro = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El area del circulo es " + e.calcularcirculo().ToString("0.00"));
                break;

            case 2:
                Console.WriteLine("Ingrese lado del cuadrado");
                e.l = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El area del cuadrado es " + e.calcularcuadrado());
                break;

            case 3:
                Console.WriteLine("Ingrese la base del triangulo");
                e.bt = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del triangulo");
                e.ht = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El area del triangulo es " + e.calculartriangulo());
                break;

        }
        Console.WriteLine("Ejercicio no. 2");
        Console.WriteLine("Ingrese el precio base del producto");
        e.PrecioB = Convert.ToDouble(Console.ReadLine());

        bool Charvalido = false;

        do
        {
            Console.WriteLine(" Ingrese el consumo energetico A/B/C/D");
            e.CE = Convert.ToChar(Console.ReadLine());

            if (e.CE == 'A' || e.CE == 'B' || e.CE == 'C' || e.CE == 'D')
            {
                Charvalido = true;
            }
            else
            {
                Console.WriteLine("Ingrese un caracter valido");
            }
        } while (Charvalido == false);

        Console.WriteLine("Ingrese el peso del producto");
        e.peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("El valor del producto es: Q" + e.CalcularPrecio());


        Console.WriteLine("Ejercicio no. 3");
        Console.WriteLine("Introduce un número");
        e.numero = int.Parse(Console.ReadLine());

        Console.WriteLine("los divisores de " + e.numero + " son:");

        e.CalcularDivisores();
        
    }
}

