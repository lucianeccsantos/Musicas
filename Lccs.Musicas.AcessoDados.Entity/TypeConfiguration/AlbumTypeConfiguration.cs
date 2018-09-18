
using Lccs.Comum.Entity;
using Lccs.Musicas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lccs.Musicas.AcessoDados.Entity.TypeConfiguration
{
    class AlbumTypeConfiguration : LccsEntityAbstractConfig<Album>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(a => a.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("ALB_ID");
            Property(a => a.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("ALB_NOME");
            Property(a => a.Ano)
                .IsRequired()
                .HasColumnName("ALB_ANO");
            Property(a => a.Observacoes)
                .IsOptional()
                .HasMaxLength(1000)
                .HasColumnName("ALB_OBSERVACOES");
        }

        protected override void ConfigurarChavePrimaria()
        {

            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarChavesEstrangeiras()
        {
            
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("ALB_ALBUNS");
        }
    }
}
