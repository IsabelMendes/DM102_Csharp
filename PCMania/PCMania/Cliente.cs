using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PCMania
{
    class Cliente
    {
        public String nome;
        public long cpf;
        public ICollection<Computador> computadores = new HashSet<Computador>();


        public float calculaTotalCompra()
        {
            float total = 0;
            foreach (Computador computador in computadores)
            {
                total = total + computador.preco;
            }
                return total;
        }
    }
}
