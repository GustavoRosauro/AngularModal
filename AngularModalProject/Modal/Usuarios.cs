using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularModalProject.Modal
{
    public class Usuarios
    {
        public Usuarios(int id,string nome,int idade)
        {
            this.Id = id;
            this.Nome = nome;
            this.Idade = idade;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
