using System;
using System.Collections;

namespace Flyweight
{
    class MainApp
    {
        static void Main()
        {
            int Vida = 20;
            Console.WriteLine("Empieza la batalla \n1.Golpea\n2.Defiende\n3.Curate");
            while (Vida >= 0)
            {
                int p = Vida;
                Batalla factory = new Batalla();
                Console.WriteLine("ingresa el numero de La opcion");

                int o;
                string opcion = Console.ReadLine();
                int.TryParse(opcion, out o);

                if (o == 1)
                {

                    Golpe fx = factory.GetFlyweight("X");
                    fx.Operation(Vida - 3);
                }

                if (o == 2)
                {
                    Golpe fy = factory.GetFlyweight("Y");
                    fy.Operation(Vida - 2);
                }
                if (o == 3)
                {
                    Golpe fz = factory.GetFlyweight("Z");
                    fz.Operation(Vida + 1);
                }

                Console.WriteLine("tu vida es: "+ Vida);
           
            }
            Console.WriteLine("\n Estas muerto");
        }
    }

    class Batalla
    {
        private Hashtable flyweights = new Hashtable();

        public Batalla()
        {
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Golpe GetFlyweight(string key)
        {
            return ((Golpe)flyweights[key]);
        }
    }

    abstract class Golpe
    {
        public abstract void Operation(int extrinsicstate);
    }

    class ConcreteFlyweight : Golpe
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine(extrinsicstate);
        }
    }

    
}
