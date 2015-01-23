using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeLigaNoBlog.Test
{
    [TestClass]
    public class ArtigoTests
    {
        [TestMethod]
        public void DeveAtribuirValoresAsPropriedades()
        {
            //arrange
            var titulo = "Blog da Azys";
            var url = "http://www.azys.com.br/blog/";

            var artigo = new Artigo(titulo, url);

            //assert
            Assert.AreEqual(titulo, artigo.Titulo);
            Assert.AreEqual(url, artigo.Url);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NaoDeveAceitarTituloNulo()
        {
            //Act
            var artigo = new Artigo(null, "http://www.azys.com.br/blog/");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NaoDeveAceitarUrlNula()
        {
            //Act
            var artigo = new Artigo("Titulo", null);
        }
    }
}
