using System;
using System.Collections.Generic;

namespace Composite
{
    class MainApp
    {
        static void Main()
        {
            Robots Inicial = new Robots("Sin asignacion");
            Inicial.Add(new Activo("XR1"));
            Inicial.Add(new Activo("XR2"));

            Robots Trabajador = new Robots("Trabajadores");
            Trabajador.Add(new Activo("XR1T"));
            Trabajador.Add(new Activo("XR2T"));

            Inicial.Add(Trabajador);
            Inicial.Add(new Activo("XY"));

            Activo activo = new Activo("XT");
            Inicial.Add(activo);
            Inicial.Remove(activo);

            Inicial.Display(1);

            Console.ReadKey();
        }
    }
    abstract class Robot
    {
        protected string name;

        public Robot(string name)
        {
            this.name = name;
        }

        public abstract void Add(Robot c);
        public abstract void Remove(Robot c);
        public abstract void Display(int depth);
    }
    class Robots : Robot
    {
        private List<Robot> _children = new List<Robot>();

        public Robots(string name)
            : base(name)
        {
        }

        public override void Add(Robot component)
        {
            _children.Add(component);
        }

        public override void Remove(Robot component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Robot component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }
    class Activo : Robot
    {
        public Activo(string name)
            : base(name)
        {
        }

        public override void Add(Robot c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Robot c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}