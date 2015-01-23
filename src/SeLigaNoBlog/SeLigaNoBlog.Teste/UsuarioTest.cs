using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeLigaNoBlog.Teste
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void DeveAtribuirNomeEmailNoConstrutor()
        {
            //arrange
            var nome = "Oliveira";
            var email = "cavernabrasil@bol.com.br";

            var usuario = new Usuario(nome, email);

            //assert
            Assert.AreEqual(nome, usuario.Nome);
            Assert.AreEqual(email, usuario.Email);
        }
    }
}
