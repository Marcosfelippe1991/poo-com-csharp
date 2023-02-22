namespace BancoCSharp.Models
{
    public class ContaBancaria
    {
        #region atributos
        public Titular Titular {get; set;}
        public double Saldo{get; private set;}

        public DateTime DataAbertura {get; private set;}

        private readonly double VALOR_MINIMO = 10.0;

        #endregion

        #region Construtores
        public ContaBancaria(Titular titular, double saldoAbertura, int v)
        {
            Titular = titular;
            Saldo  = saldoAbertura;
            DataAbertura = DateTime.Now;
        }
        #endregion

        #region Métodos

        public void Depositar(double valor)
        {
            if(valor < VALOR_MINIMO)
            {
                throw new Exception("O valor minimo para depósito é R$" + VALOR_MINIMO);
            }

            Saldo += valor;

        }

         public double Sacar(double valor)
        {
            if(valor < VALOR_MINIMO)
            {
                throw new Exception("O valor minimo para saque é R$" + VALOR_MINIMO);
            } 
            else if(valor > Saldo)
            {
                throw new Exception("Saldo insuficiente para Saque, saldo atual é de R$" + Saldo);
            }
        

            Saldo -= valor;

            return valor;

        }

        public void Transferir(ContaBancaria contaDestino, double valor)
        {
             if(valor < VALOR_MINIMO)
            {
                throw new Exception("Valor minimo para transferencia é de R$" + VALOR_MINIMO);
            }

             else if(valor > Saldo)
            {
                throw new Exception("Saldo insuficiente para Tranferencia, saldo atual é de R$" + Saldo);
            }

            contaDestino.Depositar(valor);
        }
        #endregion

    }
}