using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Filme
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public TimeSpan Duracao { get; set; }
        public string Sinopse { get; set; }
        public bool StLocado { get; set; }
        public string Banner { get; set; }
        public int IdCategoria { get; set; }
        public int IdGenero { get; set; }
        public Categoria Categoria { get; set; }
        public Genero Genero { get; set; }
    }

    

}
