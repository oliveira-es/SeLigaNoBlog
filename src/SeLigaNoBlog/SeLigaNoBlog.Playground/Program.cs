using System;
using System.Net.Mail;

namespace SeLigaNoBlog.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Eu enquanto usuario, quero receber todo dia pela manhã,
             * um artigo técnico do Blog do Martin Fowler em meu e-mail.
             * 
             * Planejamento
             * 
             * Obter os posts do Blog
             * Separar os artigos
             * Pegar um artigo aleatório
             * Enviar o link para o email do Usuário
             * 
             * Desafios:
             * Como pegar os posts
             *      - RSS http://martinfowler.com/feed.atom
             * Separar os artigos
             *      - onde o feet conter article
             * Como enviar o e-mail
             */

            var servico = new ServicoRecomendacao();
            servico.Executar();
            Console.ReadLine();
        }
    }
}
