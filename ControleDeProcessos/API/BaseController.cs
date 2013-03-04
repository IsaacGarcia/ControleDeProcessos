using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeProcessos.API
{
    public abstract class BaseController
    {
        public DTO ProximoPasso(DTO dto)
        {
            var resultado = ProximoPassoEspecifico(dto);

            RegistrarTransacao(dto, ultimaAtividade: resultado.Esta);

            return resultado;
        }

        protected abstract DTO ProximoPassoEspecifico(DTO dto);

        public void RegistrarTransacao(DTO dto, string ultimaAtividade)
        {
            var gerenciadorDeTransacao = new GerenciadorDeTransacao();

            gerenciadorDeTransacao.Salvar(dto.UltimaTransacao, ultimaAtividade, dto);
        }
    }
}
