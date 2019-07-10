using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Configuration
{
    class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(pedido => pedido.Id);
            builder.Property(pedido => pedido.UsuarioId).IsRequired();
            builder.Property(pedido => pedido.FormaPagamentoId).IsRequired();

            builder.HasOne(p => p.FormaPagamento);
            builder.HasOne(p => p.Usuario);
            builder.HasMany(p => p.ItensPedido).WithOne(i => i.Pedido);
        }
    }
}
