using System;

namespace Adapter
{
    class MainApp
    {
        static void Main()
        {
            Console.WriteLine("Caracteristicas de los personajes del juego");
            Console.WriteLine("No adaptado ");

            personaje insecto = new personaje("Insecto");
            insecto.Display();

            Console.WriteLine("\nAdaptados");
            personaje humano = new PersonajeDec("Humano");
            humano.Display();

            personaje reptil = new PersonajeDec("Reptil");
            reptil.Display();

            personaje gato = new PersonajeDec("Gato");
            gato.Display();

            personaje demonio = new PersonajeDec("Demonio");
            demonio.Display();



            Console.ReadKey();
        }
    }
    class personaje
    {
        protected string _nombree;
        protected float _poder;
        protected float _peso;
        protected double _altura;
        protected string _nombre;

        public personaje(string personaje)
        {
            this._nombree = personaje;
        }

        public virtual void Display()
        {
            Console.WriteLine("\nPersonaje: {0}  ", _nombree);
        }
    }

    class PersonajeDec : personaje
    {
        private CharBank _bank;

        public PersonajeDec(string name)
            : base(name)
        {
        }

        public override void Display()
        {
            _bank = new CharBank();

            _poder = _bank.GetWheight(_nombree, "Peso");
            _peso = _bank.GetWheight(_nombree, "Daño");
            _altura = _bank.GetMolecularWeight(_nombree);
            _nombre = _bank.GetName(_nombree);

            base.Display();
            Console.WriteLine(" Nombre: {0}", _nombre);
            Console.WriteLine(" Altura en M : {0}", _altura);
            Console.WriteLine(" Peso en Kg : {0}", _peso);
            Console.WriteLine(" Daño por golpe : {0}", _poder);
        }
    }

    class CharBank
    {
        public float GetWheight(string compound, string point)
        {
            if (point == "Daño")
            {
                switch (compound.ToLower())
                {
                    case "humano": return 65f;
                    case "reptil": return 95f;
                    case "gato": return 55f;
                    case "demonio": return 80f;
                    default: return 0f;
                }
            }
            else
            {
                switch (compound.ToLower())
                {
                    case "humano": return 50f;
                    case "reptil": return 80f;
                    case "gato": return 70f;
                    case "demonio": return 60f;
                    default: return 0f;
                }
            }
        }

        public string GetName(string compound)
        {
            switch (compound.ToLower())
            {
                case "humano": return "Albert";
                case "reptil": return "Igna";
                case "gato": return "Aslan";
                case "demonio": return "Marik";
                default: return "";
            }
        }

        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "humano": return 1.80;
                case "reptil": return 2.10;
                case "gato": return 1.60;
                case "demonio": return 1.90;
                default: return 0d;
            }
        }
    }
}
