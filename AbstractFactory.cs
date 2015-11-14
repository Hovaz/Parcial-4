using System;

namespace AbstractFactory
{

    class MundoReal
    {
   
        public static void Main()
        {
            MaterialFactory Metalurgia = new MetalFactory();
            FactoryWorld world = new FactoryWorld(Metalurgia);
            world.RunCuidadosMedicos();

            MaterialFactory Maderera = new WoodFactory();
            world = new FactoryWorld(Maderera);
            world.RunCuidadosMedicos();

            Console.ReadKey();
        }
    }


    abstract class MaterialFactory
    {
        public abstract Trabajador CreateWorker();
        public abstract Medico CreateMedic();
        
    }

    class MetalFactory : MaterialFactory
    {
        public override Trabajador CreateWorker()
        {
            return new Juan();
        }
        public override Medico CreateMedic()
        {
            return new Leon();
        }
    }

    class WoodFactory : MaterialFactory
    {
        public override Trabajador CreateWorker()
        {
            return new Pedro();
        }
        public override Medico CreateMedic()
        {
            return new Manuel();
        }
    }

    abstract class Trabajador
    {
    }

   

    abstract class Medico
    {
        public abstract void cura(Trabajador h);
    }

    class Juan : Trabajador
    {
    }

    class Leon : Medico
    {
        public override void cura(Trabajador h)
        {
            Console.WriteLine(this.GetType().Name +
              " cura a " + h.GetType().Name);
        }
    }

    class Pedro : Trabajador
    {
    }

    class Manuel : Medico
    {
        public override void cura(Trabajador h)
        {
            Console.WriteLine(this.GetType().Name +
              " cura a " + h.GetType().Name);
        }
    }


    class FactoryWorld
    {
        private Trabajador _trabajador;
        private Medico _medico;

        public FactoryWorld(MaterialFactory factory)
        {
            _medico = factory.CreateMedic();
            _trabajador = factory.CreateWorker();
        }

        public void RunCuidadosMedicos()
        {
            _medico.cura(_trabajador);
        }
    }
}