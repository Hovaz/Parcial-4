using System;

namespace Prototype
{
    class MainApp
    {
        static void Main()
        {
            string animal;
            Console.WriteLine("Este es un creador de un animal\npara rellenar el mapa");
            Console.WriteLine("Porfavor ingrase el nombre del\nanimal que desea creapara rellenar\n");
            animal = Console.ReadLine();
            AnimalBase Tipo = new AnimalBase(animal);
            AnimalBase animal1 = (AnimalBase)Tipo.Clone();
            AnimalBase animal2 = (AnimalBase)Tipo.Clone();
            AnimalBase animal3 = (AnimalBase)Tipo.Clone();
            AnimalBase animal4 = (AnimalBase)Tipo.Clone();
            AnimalBase animal5 = (AnimalBase)Tipo.Clone();
            Console.WriteLine();
            Console.WriteLine(animal1.Id + " 1");
            Console.WriteLine(animal2.Id + " 2");
            Console.WriteLine(animal3.Id + " 3");
            Console.WriteLine(animal4.Id + " 4");
            Console.WriteLine(animal5.Id + " 5");
            

      
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        private string _id;

        public Animal(string id)
        {
            this._id = id;
        }
        public string Id
        {
            get { return _id; }
        }

        public abstract Animal Clone();
    }
    class AnimalBase : Animal
    {
        public AnimalBase(string id)
            : base(id)
        {
        }
        public override Animal Clone()
        {
            return (Animal)this.MemberwiseClone();
        }
    }
}
