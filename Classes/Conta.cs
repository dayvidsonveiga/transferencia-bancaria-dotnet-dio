using System;

namespace DIO.Bank
{
    public class Conta
    {
        public Conta(TipoConta tipoConta, double saldo, double credito, string nome) 
        {
            this.TipoConta = tipoConta;
                this.Saldo = saldo;
                this.Credito = credito;
                this.Nome = nome;
               
        }
                private	TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }

        public Conta(TipoConta tipoConta, double Saldo, double Credito, string Nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = Saldo;
            this.Credito = Credito;
            this.Nome = Nome;
        }

        public bool Sacar(double valorSaque)
        {
            // Validação de saldo suficiente
            if (thisSaldo - valorSaque < (this.Credito * -1)){
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }

            this.Saldo -= valorSaque;
            
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);

            return true
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

    }
}