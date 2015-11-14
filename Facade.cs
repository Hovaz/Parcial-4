using System;

namespace DoFactory.GangOfFour.Facade.Structural
{
    class MainApp
    {
        public static void Main()
        {

            Console.WriteLine("Bienbenido a Perlas Games\n");
            Console.WriteLine("A continuacion se le dara una lista\nde juegos para su hijo\nsegun la edad que tiene");
            Console.WriteLine("\nPorfavor ingrese la edad de su primer hijo\n");
            Facade facade = new Facade();
            string edad1 = Console.ReadLine();
            int e;
            int.TryParse(edad1, out e);
            Console.WriteLine("\nPorfavor ingrese la edad de su segundo hijo\n");
            string edad2 = Console.ReadLine();
            int x;
            int.TryParse(edad2, out x);

            facade.MethodA(e);
            facade.MethodB(x);

            Console.ReadKey();
        }
    }
    class Careras
    {
        public void MethodOne(int e)
        {
            if (e < 15)
            {
                Console.WriteLine(" Mario carts");
            }
            else
            {
                Console.WriteLine(" Need for speed");
            }
        }
    }
    class Aventuras
    {
        public void MethodTwo(int e)
        {
            if (e < 15)
            {
                Console.WriteLine(" Crash");
            }
            else
            {
                Console.WriteLine(" Dust");
            }
        }
    }
    class Accion
    {
        public void MethodThree(int e)
        {
            if (e < 15)
            {
                Console.WriteLine(" Catle crashers");
            }
            else
            {
                Console.WriteLine(" Call of duty");
            }
        }
    }
    class Terror
    {
        public void MethodFour(int e)
        {
            if (e > 15)
            {
                Console.WriteLine(" Silent hills");
            }

        }
    }
    class Facade
    {
        private Careras _one;
        private Aventuras _two;
        private Accion _three;
        private Terror _four;

        public Facade()
        {
            _one = new Careras();
            _two = new Aventuras();
            _three = new Accion();
            _four = new Terror();
        }

        public void MethodA(int e)
        {
            Console.WriteLine("Para la edad de "+ e);
            _one.MethodOne(e);
            _two.MethodTwo(e);
            _three.MethodThree(e);
            _four.MethodFour(e);
        }

        public void MethodB(int e)
        {
            Console.WriteLine("Para la edad de " + e);
            _one.MethodOne(e);
            _two.MethodTwo(e);
            _three.MethodThree(e);
            _four.MethodFour(e);
        }
    }
}