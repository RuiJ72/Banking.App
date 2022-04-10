namespace Banking.App.Conta
{
    public class Conta
    {
       private TipoConta TipoConta { get; set; }

       private double Saldo { get; set; }

       private double Credito { get; set; }

       private string Nome  { get; set; }


        // Método construtor
       public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
       {
           this.TipoConta = tipoConta;
           this.Saldo = saldo;
           this.Credito = Credito;
           this.Nome = nome;
       }
    }
}

// Classe conta com os seus atributos
/* Como não é desejável nenhum usuário alterar esses dados, os atributos
são privados, o chamado Encapsulamento */