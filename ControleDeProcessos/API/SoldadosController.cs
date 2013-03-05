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

            Soldado soldado = repositorio.ObterSoldadoPeloNome(dto.Usuario);

            soldado.ProximoEstado();

            return new SoldadoDTO { Usuario = soldado.Nome, Esta = soldado.Esta };
        }
    }
}
