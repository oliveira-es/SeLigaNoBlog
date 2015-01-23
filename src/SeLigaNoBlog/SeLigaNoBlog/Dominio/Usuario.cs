using System;

namespace SeLigaNoBlog
{
    public class Usuario
    {
        //public string Nome { get; set; }
        private string nome;
        public string Nome { 
            get{
                return nome;
            }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("value");
                nome = value;
            }
        }
        public string Email { get;  set; }

        public Usuario(string nome, string email)
        {
            //validação dos parâmetros
            if (String.IsNullOrEmpty(nome))
                throw new ArgumentNullException("nome");

            if (String.IsNullOrEmpty(email))
                throw new ArgumentNullException("email");
        }
    }
}
