using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }

        public string SobreNome { get; set; }

        /// <summary>
        /// Um Usuario pode ter pelo menos um ou muitos pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validar()
        {
            if (string.IsNullOrEmpty(Email))
            {
                MensagemValidacao.Add("Qual o email do usuário?");
            }

            if (string.IsNullOrEmpty(Senha))
            {
                MensagemValidacao.Add("Qual a senha do usuário?");
            }
        }
    }
}
