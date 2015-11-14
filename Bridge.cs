using System;

namespace Bridge 
{
    class MainApp
    {
        static void Main()
        {
            Systema sigaa = new SystemaI();
            
            
            sigaa.Sujeto = new Juan();
            sigaa.Operation();

           

            sigaa.Sujeto = new Manuel();
            sigaa.Operation();

            Console.ReadKey();
        }
    }
    class Systema
    {
        protected Estudiante sujeto;

        public Estudiante Sujeto
        {
            set { sujeto = value; }
        }

        public virtual void Operation()
        {
            sujeto.Operation();
        }
    }
    abstract class Estudiante
    {
        public abstract void Operation();
    }
    class SystemaI : Systema
    {
        public override void Operation()
        {
            sujeto.Operation();
        }
    }
    class Juan : Estudiante
    {
        public override void Operation()
        {
            Console.WriteLine("Porfavor ingrese su nombre\n");
            string nombre = Console.ReadLine();
            Console.WriteLine("Porfavor ingrese La materia que desea inscribir\n");
            string materia = Console.ReadLine();
            Console.WriteLine("El estudiante "+ nombre +" insecribio " + materia);
        }
    }
    class Manuel : Estudiante
    {
        public override void Operation()
        {
            Console.WriteLine("Porfavor ingrese su nombre\n");
            string nombre = Console.ReadLine();
            Console.WriteLine("Porfavor ingrese La materia que desea inscribir\n");
            string materia = Console.ReadLine();
            Console.WriteLine("El estudiante " + nombre + " insecribio " + materia);
        }
    }
}