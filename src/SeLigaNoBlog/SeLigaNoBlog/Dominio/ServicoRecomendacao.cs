using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeLigaNoBlog
{
    public class ServicoRecomendacao
    {
        public void Executar()
        {
            var blogMartinFowler = new FonteArtigos("http://martinfowler.com/feed.atom","articles");

            var usuario = new Usuario("Oliveira", "cavernabrasil@bol.com.br");

            IArtigos artigos = new Feed(blogMartinFowler);

            var smtp = Smtp.ObterPorConfig();

            var artigo = artigos.ObterArtigo();

            //envio de email
            var servico = new Gmail(smtp);//nova instância da classe Gmail

            

            var mensagem = new Mensagem(usuario, artigo);

            servico.Enviar(mensagem);
        }
    }
}
