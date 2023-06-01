using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LocadoraClassic.VO
{
    public class Categoria
    {
        //id
        //nome
        //vlDiaria
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal vlDiaria { get; set; }

        public override string ToString()
        {
            return Nome;
        }

    }
}
