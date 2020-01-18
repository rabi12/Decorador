using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public class GuardarCxPConcreta : IComponentGuardadoCXP
    {
        public void GuardarCxP()
        {
            Console.WriteLine("Se Guardo CxP");
        }
    }
}
