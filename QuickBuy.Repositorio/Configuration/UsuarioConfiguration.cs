using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //Define a chave primária
            builder.HasKey(usuario => usuario.Id);

            //Builder utiliza o padrão Fluent
            builder.Property(usuario => usuario.Email).IsRequired();
            builder.Property(usuario => usuario.Nome).IsRequired();
            builder.Property(usuario => usuario.SobreNome).IsRequired();
            builder.Property(usuario => usuario.Senha).IsRequired();

            //Um para muitos
            builder
                .HasMany(usuario => usuario.Pedidos)
                .WithOne(p => p.Usuario);
        }
    }
}
