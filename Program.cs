using System;

namespace PracticaGit_Amin_ElMakhtari
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Amin", 22s);
            Salutador salutador = new Salutador();

            salutador.Saluda(persona);
        }
    }
}
