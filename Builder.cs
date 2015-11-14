using System;
using System.Collections.Generic;

namespace Builder
{

    public class MainApp
    {

        public static void Main()
        {
            Director Manuel = new Director();

            Builder b1 = new ComprarComida();
            Builder b2 = new ComprarJuegos();

            Manuel.Construct(b1);
            Product p1 = b1.GetResult();
            p1.ShowP();

            Manuel.Construct(b2);
            Product p2 = b2.GetResult();
            p2.ShowJ();

            Console.ReadKey();
        }
    }
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.Comprar1();
            builder.Comprar2();
            builder.Comprar3();
            builder.Comprar4();
        }
    }
    abstract class Builder
    {
        public abstract void Comprar1();
        public abstract void Comprar2();
        public abstract void Comprar3();
        public abstract void Comprar4();
        public abstract Product GetResult();
    }
    class ComprarComida : Builder
    {
        private Product _product = new Product();

        public override void Comprar1()
        {
            _product.Add("Leche");
        }

        public override void Comprar2()
        {
            _product.Add("Doritos");
        }
        public override void Comprar3()
        {
            _product.Add("Helado");
        }
        public override void Comprar4()
        {
            _product.Add("Cereal");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
    class ComprarJuegos : Builder
    {
        private Product _product = new Product();

        public override void Comprar1()
        {
            _product.Add("Mario");
        }

        public override void Comprar2()
        {
            _product.Add("Metroid");
        }
        public override void Comprar3()
        {
            _product.Add("Call of duty");
        }
        public override void Comprar4()
        {
            _product.Add("Aion");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
    class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void ShowP()
        {
            Console.WriteLine("\nEl usuario compro la siguiente comida");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
        public void ShowJ()
        {
            Console.WriteLine("\nEl usuario compro los siguientes juegos");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }
}