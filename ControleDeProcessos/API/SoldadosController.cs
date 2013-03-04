using ControleDeProcessos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.API
{
    public class SoldadosController
    {
        public SoldadoDTO ProximoPasso(SoldadoDTO dto)
        {
            Repositorio repositorio = new Repositorio();

            Soldado soldado = repositorio.ObterSoldadoPeloNome(dto.Nome);

            soldado.ProximoEstado();

            return new SoldadoDTO { Nome = soldado.Nome, Esta = soldado.Esta };
        }
    }
}
