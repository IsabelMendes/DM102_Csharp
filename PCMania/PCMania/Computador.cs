using System;
using System.Collections.Generic;
using System.Text;

namespace PCMania
{
    class Computador
    {
        public String marca;
        public float preco;
        public ICollection<MemoriaUSB> memoriaUSBs = new HashSet<MemoriaUSB>();
        public SistemaOpracional sistemaOpracional;
        public HardwareBasico hardwareBasico;


        public void mostraPCConfigs()
        {
            Console.WriteLine("Marca: "+marca);
            Console.WriteLine("Preço: " + preco);
            Console.WriteLine("Nome do Sistema Operacional: " +sistemaOpracional.nome);
            Console.WriteLine("Tipo do SO: " + sistemaOpracional.tipo);
            Console.WriteLine("Nome do Hardware: "+hardwareBasico.nome);
            Console.WriteLine("Capacidade do Hardware: " + hardwareBasico.capacidade);

            foreach (MemoriaUSB memoriaUSB in memoriaUSBs)
            {
                Console.WriteLine("Nome da memória: "+memoriaUSB.nome);
                Console.WriteLine("Capacidade da memória: " + memoriaUSB.capacidadde);
            }
        }

        public void addMemoriaUSB(MemoriaUSB memoriaUSB)
        {
            memoriaUSBs.Add(memoriaUSB);
        }

    }
}
