﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }

        public virtual FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um ou muitos itens pedidos
        /// </summary>
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validar()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
            {
                MensagemValidacao.Add("Item de Pedido não pode ficar vazio");
            }

            if(UsuarioId == 0)
            {
                MensagemValidacao.Add("Qual usuário está fazendo o pedido?");
            }

            if (string.IsNullOrEmpty(CEP))
            {
                MensagemValidacao.Add("CEP é obrigatório");
            }
        }
    }
}
