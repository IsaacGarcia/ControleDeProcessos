using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeProcessos
{
    public class Transacao
    {
        /// <summary>
        /// Aberta
        /// Sentado
        /// Em pé
        /// Deitado
        /// Fechado
        /// </summary>
        public string Estado { get; set; }

        public string Usuario { get; set; }

        public string Processo { get; set; }

        public string UltimaAtividade { get; set; }

        public DateTime Data { get; set; }

        public DTO Dto { get; set; }

        public SoldadoDTO ProximoPasso(SoldadoDTO dto)
        {
            return new SoldadoDTO { Esta = "sentado" };
        }
    }
}
