using System;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            //AulaClasses();
            //AulaPropriedadeSomenteLeitura();
            //AulaHeranca();
            //AulaClasseSelada();
            //AulaClasseAbstrata();
            //AulaRecord();
            AulaInterface();
        }

        private static void AulaClasses()
        {
            var resultado = Cadastro.Calculos.SomarNumeros(2, 3);
            Console.WriteLine(resultado);
            /*
            var produto = new Cadastro.Produto();
            produto.SetId(1);
            produto.Descricao = "Teclado";

            produto.ImprimirDescricao();
            Console.WriteLine(produto.GetId());
            */          
        }

        private static void AulaPropriedadeSomenteLeitura()
        {
            var produto = new Cadastro.Produto();
            produto.Descricao = "Mouse";
            // produto.Estoque = 1; --> Prova de que não consegue mudar valor de uma propriedade Somente Leitura
            Console.WriteLine(produto.Estoque);
        }

        private static void AulaHeranca()
        {
            /*var pessoaFisica = new Cadastro.PessoaFisica();

            pessoaFisica.Id = 1;
            pessoaFisica.Endereco = "Endereco Teste";
            pessoaFisica.Cidade = "Goiania";
            pessoaFisica.Cep = "123456789";
            pessoaFisica.CPF = "12398745600";

            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCpf();
            */

            var pessoaFisica = new Cadastro.Funcionario();

            pessoaFisica.Id = 1;
            pessoaFisica.Endereco = "Endereco Teste";
            pessoaFisica.Cidade = "Goiania";
            pessoaFisica.Cep = "123456789";
            pessoaFisica.CPF = "12398745600";

            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCpf();
        }

        private static void AulaClasseSelada()
        {
            var configuracao = new Cadastro.Configuracao();
            configuracao.Host = "LocalHost";

            Console.WriteLine(configuracao.Host);  
        }
   
        private static void AulaClasseAbstrata()
        {
            var cachorro = new Cadastro.Cachorro();

            cachorro.Nome = "Torresmo";

            cachorro.ImprimirDados();
        }
    
        private static void AulaRecord()
        {
            //var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso"};
            //var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso"};

            var curso1 = new Cadastro.Curso(1, "Curso");
            var curso2 = curso1 with {Descricao = "Teste Novo"};

            //var curso1 = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso"};           
            //var curso2 = curso1; --> Leva os dois ocuparem o mesmo endereço de memoria.
            //curso2.Descricao = "TESTE TESTE"; --> Muda os valores dos dois por ocuparem o mesmo endereço.
            // var curso2 = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso"};
            // curso2.Id = curso1.Id;
            // curso2.Descricao = "Nova Descrição";

            Console.WriteLine(curso1.Descricao);
            Console.WriteLine(curso2.Descricao);


            //Console.WriteLine(curso1.Equals(curso2));
            //Console.WriteLine(curso1 == curso2);
        }

        public static void AulaInterface()
        {
            var notificacaoCliente = new Cadastro.NotificacaoCliente();
            notificacaoCliente.Notificar();
            //var notificacaoFuncionario = new Cadastro.NotificacaoFuncionario();   
            //notificacaoFuncionario.Notificar();   
                  
        }
    
    }

}
