using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public abstract class DecoradorGuardarCxP : IComponentGuardadoCXP
    {
        IComponentGuardadoCXP componente;

        public virtual void GuardarCxP()
        {
            if (this.componente != null)
            {
                this.componente.GuardarCxP();
            }
            else
            {
                //return string.Empty;
            }
        }

        public DecoradorGuardarCxP(IComponentGuardadoCXP componente)
        {
            this.componente = componente;
        }

        public void SetComponent(IComponentGuardadoCXP componente)
        {
            this.componente = componente;
        }
    }
}
