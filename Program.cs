using System;

namespace herenciaMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            HerenciaMultiple h = new HerenciaMultiple();
            Interfaz1 i1 = h;
            Interfaz2 i2 = h;
            Console.WriteLine(i1.Metodo1());
            Console.WriteLine(i2.Metodo2());
        }
    }
}
