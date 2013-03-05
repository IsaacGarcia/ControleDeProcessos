using DominioA;
using DominioCompartilhado;
using DominioRegulamento;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
    public class Mapeamento<T> : ClassMap<T> where T : Objeto
    {
        public Mapeamento()
        {
            Id(x => x.Id);
            Map(x => x.Nome);
        }
    }

    public class RegulamentoMap : Mapeamento<Regulamento>
    {
        public RegulamentoMap()
        {
            Map(x => x.Caminho);

            References(x => x.Plano);
        }
    }

    public class PessoaPreInscritaMap : Mapeamento<PessoaPreInscrita>
    {
        public PessoaPreInscritaMap()
        {
            Map(x => x.Matricula);

            References(x => x.PessoaJuridica);
            References(x => x.Plano);
        }
    }

    public class EntidadeMap : Mapeamento<Entidade>
    {
        public EntidadeMap()
        {
            HasMany(x => x.Planos);
        }
    }

    public class PlanoMap : Mapeamento<Plano>
    {
        public PlanoMap()
        {
            HasManyToMany(x => x.PessoasJuridicas);
        }
    }

    public class PessoaJuridicaMap : Mapeamento<PessoaJuridica>
    {
        public PessoaJuridicaMap()
        {
            Map(x => x.Cnpj);
        }
    }
}
