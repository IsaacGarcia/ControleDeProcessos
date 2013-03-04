using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProcessos.Domain.ComponenteEstado
{
    public class UtilizaEstado<T, Dto> where Dto: DTO
    {
        public string Esta { get; set; }
        public Estado<T, Dto> Estado { get; set; }
    }
}
