using ControleDeProcessos.API;
using ControleDeProcessos.Domain.ComponenteEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Domain.ComponenteDePreInscricao
{
    public class Acao
    {
        public string Nome{get;set;}

        private IList<Atividade> _atividades;

        public Acao()
        {
            _atividades = new List<Atividade>();
        }

        public virtual void Registrar(Atividade atividade)
        {
            _atividades.Add(atividade);
        }

        public virtual void Remover(Atividade atividade)
        {
            _atividades.Remove(atividade);
        }

        public virtual bool Executar(DTO dto)
        {
            try
            {
                foreach (var atividade in _atividades)
                    atividade.Executar(dto);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

    public abstract class Atividade 
    {
        public abstract void Executar(DTO dto);
    }

    public class AtividadeProcessarArquivo : Atividade
    {
        public override void Executar(DTO dto)
        {
            
        }
    }

    public class AtividadeSubirArquivo : Atividade
    {
        public override void Executar(DTO dto)
        {
            var preInscricaoDTO = (PreInscricaoDTO)dto;

            if (preInscricaoDTO.ExtensaoDoArquivo == "pdf")
                throw new Exception("");
        }
    }
}
