public abstract class Perro
{

    public virtual string Ladrar()
    {
        return "";
    }
    public virtual string Dormir()
    {
        return "";
    }
    public virtual string Comer()
    {
        return "";
    }
    public virtual string Jugar()
    {
        return "";
    }
    public virtual string Aullar()
    {
        return "";
    }
    public virtual string Saltar()
    {
        return "";
    }

    static void Main(string[] args)
    {
        int _seleccion;

        Console.WriteLine("Escoja la raza de perro a analizar colocando el numero de su seleccion");
        Console.WriteLine("1 - Bulldog");
        Console.WriteLine("2 - Chihuahua");

        var _sConsola = Console.ReadLine();
        if (!Int32.TryParse(_sConsola, out _seleccion))
        {
            Console.WriteLine("Lo que usted introdujo no tiene el formato solicitado. El programa se cerrará.");
            return;
        }

        if (_seleccion != 1 && _seleccion != 2)
        {
            Console.WriteLine("Lo que usted introdujo no esta dentro de las opciones disponibles. El programa se cerrará.");
            return;
        }

        if (_seleccion == 1){
            Polimorfismo.Bulldog _Bulldog1 = new Polimorfismo.Bulldog();
            Perro[] _Perrera = {_Bulldog1};

            foreach (Perro item in _Perrera)
            {
                Console.WriteLine(item.Ladrar());
                Console.WriteLine(item.Dormir());
                Console.WriteLine(item.Comer());
                Console.WriteLine(item.Jugar());
                Console.WriteLine(item.Aullar());
                Console.WriteLine(item.Saltar());
            }
        }

        if (_seleccion == 2)
        {
            Polimorfismo.Chihuahua _Chihuahua1 = new Polimorfismo.Chihuahua();
            Perro[] _Perrera = { _Chihuahua1 };
            foreach (Perro item in _Perrera)
            {
                Console.WriteLine(item.Ladrar());
                Console.WriteLine(item.Dormir());
                Console.WriteLine(item.Comer());
                Console.WriteLine(item.Jugar());
                Console.WriteLine(item.Aullar());
                Console.WriteLine(item.Saltar());
            }
        }
        Console.WriteLine();
        Console.Write("Pulsa cualquier tecla para salir.");
        Console.ReadLine();
    }

}