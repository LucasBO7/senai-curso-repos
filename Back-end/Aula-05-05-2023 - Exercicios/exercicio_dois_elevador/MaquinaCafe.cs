using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_dois_elevador
{
    public class MaquinaCafe
    {
        public float AcucarDisponivel { get; set; }


        public void FazerCafe(float gramasPedidas)
        {
            // Se açúcar disponível for menor que as gramas pedidas ou igual a 0
            if (this.AcucarDisponivel < gramasPedidas || this.AcucarDisponivel == 0)
            {
                
            }
        }
    }
}