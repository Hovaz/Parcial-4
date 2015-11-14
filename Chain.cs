using System;

namespace Chain
{

    class MainApp
    {
        static void Main()
        {
            Caldero PocionA = new Nivel1();
            Caldero PocionB = new Nivel2();
            Caldero PocionC = new Nivel3();

            PocionA.SetSuccessor(PocionB);
            PocionB.SetSuccessor(PocionC);
            Console.WriteLine("Bienvenido a la tienda de pocimas\n aqui solo es pocible hacer\npocimas de nivel 3 o menor\n la cantidad maxima de ingrediente es 100");
            Console.WriteLine("ingrese la cantidad de material que desea depositar para la primera pocima");
            string material1 = Console.ReadLine();
            int m1;
            int.TryParse(material1, out m1);
            Console.WriteLine("ingrese la cantidad de material que desea depositar para la segunda pocima");
            string material2 = Console.ReadLine();
            int m2;
            int.TryParse(material2, out m2);
            Console.WriteLine("ingrese la cantidad de material que desea depositar para la tercera pocima");
            string material3 = Console.ReadLine();
            int m3;
            int.TryParse(material3, out m3);

            Peticion p = new Peticion(1, m1, "Pocima 1");
            PocionA.ProcessRequest(p);

            p = new Peticion(2, m2, "Pocima 2");
            PocionA.ProcessRequest(p);

            p = new Peticion(3, m3, "Pocima 3");
            PocionA.ProcessRequest(p);

            Console.ReadKey();
        }
    }
    abstract class Caldero
    {
        protected Caldero successor;

        public void SetSuccessor(Caldero successor)
        {
            this.successor = successor;
        }

        public abstract void ProcessRequest(Peticion purchase);
    }
    class Nivel1 : Caldero
    {
        public override void ProcessRequest(Peticion purchase)
        {
            if (purchase.Amount < 10)
            {
                Console.WriteLine("{0} Pocima posible {1}",
                  this.GetType().Name, purchase.Number);
            }
            else 
            {
                successor.ProcessRequest(purchase);
            }
        }
    }
    class Nivel2 : Caldero
    {
        public override void ProcessRequest(Peticion purchase)
        {
            if (purchase.Amount < 20)
            {
                Console.WriteLine("{0} Pocima posible {1}",
                  this.GetType().Name, purchase.Number);
            }
            else
            {
                successor.ProcessRequest(purchase);
            }
        }
    }
    class Nivel3 : Caldero
    {
        public override void ProcessRequest(Peticion purchase)
        {
            if (purchase.Amount < 100)
            {
                Console.WriteLine("{0} Pocima posible {1}",
                  this.GetType().Name, purchase.Number);
            }
            else
            {
                Console.WriteLine(
                  "Pocima {0} posible en esta tienda!",
                  purchase.Number);
            }
        }
    }

    class Peticion
    {
        private int _number;
        private int _amount;
        private string _purpose;

        public Peticion(int number, int amount, string purpose)
        {
            this._number = number;
            this._amount = amount;
            this._purpose = purpose;
        }
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }
    }
}