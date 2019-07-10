using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Configuration
{
    class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(produto => produto.Id);
            builder.Property(produto => produto.Nome).IsRequired();
            builder.Property(produto => produto.Descricao).IsRequired().HasColumnType("text");
            builder.Property(produto => produto.Preco).IsRequired();

        }
    }
}
