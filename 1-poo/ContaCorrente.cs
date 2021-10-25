using System;

namespace _1_poo
{
    public class ContaCorrente
    {
        public static int TotalDeContas {get; set;}

        private double _saldo;
        public double Saldo { 
            get{
                return this._saldo;
            }
            set {
                if (value < 0)
                {
                    return;
                }
                this._saldo = value;
            } 
        }
        public Pessoa Titular { get; set; }
        private int _numero;
        public int Numero { 
            get{
                return this._numero;
            }
            set{
                if(value <= 0){
                    return;
                }
                this._numero = value;
            }
        }
        private int _agencia;
        public int Agencia {
            get{
                return this._agencia;
            }
            set{
                if (value < 0){
                    return;
                }
                this._agencia = value;
            }
        }
        public ContaCorrente(Pessoa titular, int agencia, int numero, double saldo){
            this.Titular = titular;
            this.Agencia = agencia;
            this.Numero = numero;
            TotalDeContas++;
        }

        public bool Sacar(double valor){
            if (this.Saldo <= valor){
                return false;
            }
            this.Saldo -= valor;
            return true;
        }

        public void Depositar(double valor){
            if (valor >= 0){
                this.Saldo += valor;
            }
        }

        public void ImprimirSaldo(){
            string message = String.Format("O saldo presente na conta do {0} de R$ {1,2:C}",this.Titular.Name,this.Saldo);
            Console.WriteLine(message);
        }

        public bool Transferir(double valor, ContaCorrente destino){
            if (this.Saldo <= valor){
                return false;
            }
            this.Sacar(valor);
            destino.Depositar(valor);
            return true;
        }
    }
}
