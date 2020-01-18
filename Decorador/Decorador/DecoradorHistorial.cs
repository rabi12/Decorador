using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public class DecoradorHistorial:DecoradorGuardarCxP
    {
        public DecoradorHistorial(IComponentGuardadoCXP comp) : base(comp)
        {
            
        }

        public override void GuardarCxP()
        {
            base.GuardarCxP();
            extra();
        }

        private void extra()
        {
            Console.WriteLine("Historial:Se guardo CxP.");
        }
    }
}
