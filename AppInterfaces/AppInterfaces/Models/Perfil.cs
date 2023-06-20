using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInterfaces.Models
{
    internal class Perfil
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Telefone { get; set; }
        public int Rg { get; set; }
        public string Email { get; set; }
        public string Funcao { get; set; }
        public string Setor { set; get; }
        private string _perfil;
    }
}
