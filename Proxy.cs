using System;

namespace Proxy
{
    class MainApp
    {
        static void Main()
        {
            Console.WriteLine("Escribe tu nombre:\n");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu edad");
            string edad = Console.ReadLine();
            Console.WriteLine("Ququieres hacer\n");
            Console.WriteLine("1. Jugar un videojuego\n2. Hacer deporte\n3. Ver una pelicula\n");
            Console.WriteLine("Escribe la opcion deseada");
            string opcion = Console.ReadLine();
            int o;
            int.TryParse(opcion, out o);
            MathProxy proxy = new MathProxy();

            if (o == 1)
            {
                Console.WriteLine("Elegiste videojuego\n" + proxy.Videojuego(nombre, edad));
            }
            if (o == 2)
            {
                Console.WriteLine("Elegiste deporte\n" + proxy.Deporte(nombre, edad));
            }
            if (o == 3)
            {
                Console.WriteLine("Elegiste Pelicula\n" + proxy.Pelicula(nombre, edad));
            }
            Console.ReadKey();

        }
    }

    public interface ActividadesI
    {
        string Deporte(string x, string y);
        string Videojuego(string x, string y);
        string Pelicula(string x, string y);
    }

    class Actividad : ActividadesI
    {
        public string Deporte(string x, string y) { 
            Console.WriteLine("¿que deporte quieres practicar?");
            string D = Console.ReadLine();
            string r = x +" de "+y+ " Practicara " + D;
            return r;
        }
        public string Videojuego(string x, string y)
        {
            Console.WriteLine("¿que videojuego quieres Jugar?");
            string D = Console.ReadLine();
            string r = x + " de " + y + " jugara " + D;
            return r;
        }
        public string Pelicula(string x, string y)
        {
            Console.WriteLine("¿que Pelicula quieres ver?");
            string D = Console.ReadLine();
            string r = x + " de " + y + " vera " + D;
            return r;
        }
    }

    class MathProxy : ActividadesI
    {
        private Actividad Actividad = new Actividad();

        public string Deporte(string x, string y)
        {
            return Actividad.Deporte(x, y);
        }
        public string Videojuego(string x, string y)
        {
            return Actividad.Videojuego(x, y);
        }
        public string Pelicula(string x, string y)
        {
            return Actividad.Pelicula(x, y);
        }
    }
}
