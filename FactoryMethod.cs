using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Factory.RealWorld
{
    class MainApp
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido a la reposteria de Juana tenemos\nla siguiente oferta de postres \n");
            Reposteria[] postres = new Reposteria[3];

            postres[0] = new Tortas();
            postres[1] = new Tartas();
            postres[2] = new Flanes();
            foreach (Reposteria postre in postres)
            {
                Console.WriteLine("\n" + postre.GetType().Name + " de");
                foreach (Tipo sabor in postre.sabores)
                {
                    Console.WriteLine(" " + sabor.GetType().Name);
                }
            }
            Console.ReadKey();
        }
    }
    abstract class Tipo
    {
    }
    class pan : Tipo
    {
    }
    class envinada : Tipo
    {
    }
    class Banano : Tipo
    {
    }
    class Redvelvet : Tipo
    {
    }
    class Manzana : Tipo
    {
    }
    class Frambuesa : Tipo
    {
    }
    class Mora : Tipo
    {
    }
    class Pera : Tipo
    {
    }
    class Vainilla : Tipo
    {
    }
    class Guanabana : Tipo
    {
    }
    class Chocolate : Tipo
    {
    }
    class Fresa : Tipo
    {
    }
    abstract class Reposteria
    {
        private List<Tipo> _pages = new List<Tipo>();
        public Reposteria()
        {
            this.CreatePages();
        }

        public List<Tipo> sabores
        {
            get { return _pages; }
        }
        public abstract void CreatePages();
    }
    class Tortas : Reposteria
    {
        public override void CreatePages()
        {
            sabores.Add(new pan());
            sabores.Add(new envinada());
            sabores.Add(new Banano());
            sabores.Add(new Redvelvet());
        }
    }
    class Tartas : Reposteria
    {
        public override void CreatePages()
        {
            sabores.Add(new Manzana());
            sabores.Add(new Frambuesa());
            sabores.Add(new Pera());
            sabores.Add(new Mora());
        }
    }
    class Flanes : Reposteria
    {
        public override void CreatePages()
        {
            sabores.Add(new Vainilla());
            sabores.Add(new Chocolate());
            sabores.Add(new Guanabana());
            sabores.Add(new Fresa());
        }
    }
}