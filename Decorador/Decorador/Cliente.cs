using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    class Cliente
    {
        public void Main()
        {
            GuardarCxPConcreta guardarCXP = new GuardarCxPConcreta();
            Console.WriteLine("Guardar sin decoradores");
            guardarCXP.GuardarCxP();


            Console.WriteLine("\nGuardar con Historial");
            DecoradorHistorial guardarConHistorial = new DecoradorHistorial(guardarCXP);
            guardarConHistorial.GuardarCxP();


            Console.WriteLine("\nGuardar con Correo");
            DecoradorCorreo guardarConCorreo = new DecoradorCorreo(guardarConHistorial);
            guardarConCorreo.GuardarCxP();

        }
    }
}
