using System;

namespace Singleton
{
    class MainApp
    {
        static void Main()
        {
            humano Juan = humano.Instance();
            humano Maria = humano.Instance();

            if (Juan == Maria)
            {
                Console.WriteLine("juan y maria son humanos");
            }
            Console.ReadKey();
        }
    }

    class humano
    {
        private static humano _instance;

        protected humano()
        {
        }

        public static humano Instance()
        {
            if (_instance == null)
            {
                _instance = new humano();
            }

            return _instance;
        }
    }
}