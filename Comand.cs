using System;

namespace Command
{
    class MainApp
    {
        static void Main()
        {
            
            Receiver Stock = new Receiver();
            Command Guardar = new ConcreteCommand(Stock);
            Invoker Guarda = new Invoker();
            bool menu = true;
            Guarda.SetSave(Guardar);
            while (menu == true)
            {
                Console.WriteLine("Escriba salir para terminar o presione enter para Cambiar su nombre\n");
                string opcion = Console.ReadLine();
                if (opcion == "salir")
                { menu = false; }
                Console.WriteLine("Escriba el Nombre que desea tener\n");
                string objeto = Console.ReadLine();
                Guarda.ExecuteSave(objeto);
            }
            Console.ReadKey();
        }
    }
    abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute(string e);
    }
    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) :
            base(receiver)
        {
        }

        public override void Execute(string e)
        {
            receiver.Action(e);
        }
    }
    class Receiver
    {
        public void Action(string e)
        {
            string inventario = "";

            inventario = inventario + " " + e;

            Console.WriteLine(inventario);
        }
    }
    class Invoker
    {
        private Command Guardo;

        public void SetSave(Command Guardado)
        {
            this.Guardo = Guardado;
        }

        public void ExecuteSave(string e)
        {
            Guardo.Execute(e);
        }
    }
}