﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos
{
    public abstract class DTO
    {
        public Transacao UltimaTransacao { get; set; }

        public string Processo { get; set; }

        public virtual string Esta { get; set; }

        public string Nome { get; set; }

        public string Acao { get; set; }
    }
}
