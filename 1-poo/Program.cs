using System;

namespace _1_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração dos objetos
            Pessoa felipe = new Pessoa("Felipe", "429.122.328-41", "Estagiario Back-end");
            Pessoa bruno = new Pessoa("Bruno", "478.117.356-42", "Estagiario Front-end");
            ContaCorrente ContaDoFelipe = new ContaCorrente(felipe,0001,000001,100);
            ContaCorrente ContaDoBruno = new ContaCorrente(bruno,0001,000002,200);

            //Saque
            ContaDoFelipe.ImprimirSaldo();
            Console.WriteLine("Saque 50,00");
            if(ContaDoFelipe.Sacar(50)){
                Console.WriteLine("Saque concluido!");
            }else{
                Console.WriteLine("Saque não efetuado!");
            }
            ContaDoFelipe.ImprimirSaldo();

            //Deposito
            Console.WriteLine("Deposito 50");
            ContaDoFelipe.Depositar(50);
            ContaDoFelipe.ImprimirSaldo();

            //Transferencia
            ContaDoFelipe.ImprimirSaldo();
            ContaDoBruno.ImprimirSaldo();
            Console.WriteLine("Transferencia 100");
            if(ContaDoBruno.Transferir(100, ContaDoFelipe)){
                Console.WriteLine("Transferencia concluida!");
            }else{
                Console.WriteLine("Transferencia não efetuada!");
            }
            ContaDoFelipe.ImprimirSaldo();
            ContaDoBruno.ImprimirSaldo();

            ContaDoFelipe.Saldo = -10;
            ContaDoFelipe.ImprimirSaldo();

            Console.WriteLine("Total de contas criadas: "+ContaCorrente.TotalDeContas);
            Console.ReadLine();
        }
    }
}
