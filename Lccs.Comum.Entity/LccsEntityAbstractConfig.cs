using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lccs.Comum.Entity
{
    public abstract class LccsEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class
    {
        public LccsEntityAbstractConfig()
        {
            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavePrimaria();
            ConfigurarChavesEstrangeiras();
        }

        protected abstract void ConfigurarNomeTabela();

        protected abstract void ConfigurarChavePrimaria();

        protected abstract void ConfigurarCamposTabela();

        protected abstract void ConfigurarChavesEstrangeiras();
    }
}
