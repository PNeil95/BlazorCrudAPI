using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Data
{
    public class Heroe
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Poder { get; set; }
        public string Universo { get; set; }
    }
}
