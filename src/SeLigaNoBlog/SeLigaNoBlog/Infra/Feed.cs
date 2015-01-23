using System;
using System.Linq;
using TNX.RssReader;

namespace SeLigaNoBlog
{
    public class Feed: IArtigos
    {
        public FonteArtigos Fonte { get; set; }

        protected Feed(FonteArtigos fonte)
        {
            this.Fonte = fonte;
        }        

        
        public Artigo ObterArtigo()
        {
            //seleciona os artigos no Blog
            var feed = RssHelper.ReadFeed(this.Fonte.Url);
            var articles = feed.Items
                .Select(i => new Artigo(i.Title, i.Link))
                .Where(a => a.Url.Contains(this.Fonte.Url));
            //ou var articles = feed.Items.Where(isArticle);

            //obtendo o artigo aleatório
            var radom = new Random();
            var randomNumber = radom.Next(0, articles.Count()); //pegar um número aleatório.
            var article = articles.ToArray()[randomNumber];

            return article;
        }
    }
}
