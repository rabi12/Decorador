using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public class DecoradorCorreo:DecoradorGuardarCxP
    {
        public DecoradorCorreo(IComponentGuardadoCXP comp) : base(comp)
        {
            
        }

        public override void GuardarCxP()
        {
            base.GuardarCxP();
            extra();
        }

        private void extra()
        {
            Console.WriteLine("Correo:Se guardo CxP.");
        }
    }
}
