using System;
using System.Collections.Generic;

namespace Decorator
{
    class MainApp
    {
        static void Main()
        {
            PlatoF Pasta = new PlatoF("Carbonara", "Punta de anca", 10,"Medio");
            Pasta.Display();

            Postre Tarta = new Postre("Manzana", "Chocolate", 23, 15,"Crema");
            Tarta.Display();

            Console.WriteLine("\nSirviendo: ");

            Cocinando CocinandoPostre = new Cocinando(Tarta);
            CocinandoPostre.CocinandoOrden("Manuel");
            Cocinando CocinandoPlatof = new Cocinando(Pasta);
            CocinandoPlatof.CocinandoOrden("Juana");

            CocinandoPostre.Display();
            CocinandoPlatof.Display();

            Console.ReadKey();
        }
    }

    abstract class Orden
    {
        private int Existencias;

        public int EnCocina
        {
            get { return Existencias; }
            set { Existencias = value; }
        }

        public abstract void Display();
    }

    class PlatoF : Orden
    {
        private string Salsa;
        private string Carne;
        private string termino;

        public PlatoF(string Salsa, string Carne, int EnCocina, string termino)
        {
            this.Salsa = Salsa;
            this.Carne = Carne;
            this.EnCocina = EnCocina;
            this.termino = termino;
        }

        public override void Display()
        {
            Console.WriteLine("\nPlato fuerte\n ");
            Console.WriteLine(" Salsa: {0}", Salsa);
            Console.WriteLine(" Corte: {0}", Carne);
            Console.WriteLine(" En Cocina: {0}", EnCocina);
            Console.WriteLine(" Termino: {0}", termino);
        }
    }

    class Postre : Orden
    {
        private string Sabor;
        private string Salsa;
        private string acompañamiento;
        private int Tiempo;

        public Postre(string sabor, string salsa,
          int enCocina, int tiempo, string acompañamiento)
        {
            this.Sabor = sabor;
            this.Salsa = salsa;
            this.EnCocina = enCocina;
            this.Tiempo = tiempo;
            this.acompañamiento = acompañamiento;
        }

        public override void Display()
        {
            Console.WriteLine("\nPostre\n ");
            Console.WriteLine(" Sabor: {0}", Sabor);
            Console.WriteLine(" Salsa: {0}", Salsa);
            Console.WriteLine(" Existencias: {0}", EnCocina);
            Console.WriteLine(" Tiempo de preparacion: {0}", Tiempo);
            Console.WriteLine(" Acompañamiento: {0}\n", acompañamiento);
        }
    }

    abstract class Cocina : Orden
    {
        protected Orden Pedido;

        public Cocina(Orden Pedido)
        {
            this.Pedido = Pedido;
        }

        public override void Display()
        {
            Pedido.Display();
        }
    }

    class Cocinando : Cocina
    {
        protected List<string> Clientes = new List<string>();

        public Cocinando(Orden Pedido)
            : base(Pedido)
        {
        }

        public void CocinandoOrden(string name)
        {
            Clientes.Add(name);
            Pedido.EnCocina--;
        }

        public void ReturnItem(string name)
        {
            Clientes.Remove(name);
            Pedido.EnCocina++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string Cliente in Clientes)
            {
                Console.WriteLine(" Cliente: " + Cliente);
            }
        }
    }
}