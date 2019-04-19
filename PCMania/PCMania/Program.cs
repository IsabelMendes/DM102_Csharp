using System;

namespace PCMania
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sistema Opracional
            SistemaOpracional sistemaOpracional1 = new SistemaOpracional();
            sistemaOpracional1.nome = "Linux Ubuntu";
            sistemaOpracional1.tipo = 32;

            SistemaOpracional sistemaOpracional2 = new SistemaOpracional();
            sistemaOpracional2.nome = "Windows XP";
            sistemaOpracional2.tipo = 64;

            //Hardware Basico
            HardwareBasico hardwareBasico1 = new HardwareBasico();
            hardwareBasico1.nome = "HD";
            hardwareBasico1.capacidade = 500;

            HardwareBasico hardwareBasico2 = new HardwareBasico();
            hardwareBasico2.nome = "SSD";
            hardwareBasico2.capacidade = 120;

            //Memoria
            MemoriaUSB memoriaUSB1 = new MemoriaUSB();
            memoriaUSB1.nome = "Samsung";
            memoriaUSB1.capacidadde = 6966;

            MemoriaUSB memoriaUSB2 = new MemoriaUSB();
            memoriaUSB2.nome = "LG";
            memoriaUSB2.capacidadde = 596;

            //Cliente
            Cliente cliente1 = new Cliente();
            cliente1.nome = "Lucas";
            cliente1.cpf = 2145896323;

            //Computador
            Computador computador1 = new Computador();
            computador1.sistemaOpracional = sistemaOpracional1;
            computador1.hardwareBasico = hardwareBasico1;
            computador1.addMemoriaUSB(memoriaUSB1);
            computador1.preco = 2500;
            computador1.marca = "Samsung";
            computador1.mostraPCConfigs();
            cliente1.computadores.Add(computador1);


            Computador computador2 = new Computador();
            computador2.sistemaOpracional = sistemaOpracional2;
            computador2.hardwareBasico = hardwareBasico2;
            computador2.addMemoriaUSB(memoriaUSB2);
            computador2.preco = 4500;
            computador2.marca = "LG";
            computador2.mostraPCConfigs();
            cliente1.computadores.Add(computador2);


            float totalCompra = cliente1.calculaTotalCompra();

            Console.WriteLine("O nome do Cliente é: " + cliente1.nome + " e seu cpf é: " + cliente1.cpf);

            Console.WriteLine("Total da compra é: R$ "+totalCompra);
        }
    }
}
