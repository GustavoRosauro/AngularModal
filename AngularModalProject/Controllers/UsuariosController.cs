using AngularModalProject.DAO;
using AngularModalProject.Modal;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularModalProject.Controllers
{
    [Route("api/[controller]")]
    public class UsuariosController:Controller
    {
        [HttpGet("[action]")]
        public List<Usuarios> RetornaUsuarios()
        {
            return new UsuariosDAO().RetornaUsuarios();
        }
        [HttpPost("[action]")]
        public void InserirRegistro([FromBody]Usuarios usuarios)
        {
            new UsuariosDAO().InserirRegistro(usuarios);
        }
        [HttpDelete("[action]/{id}")]
        public void DeletaUSuario(int id)
        {
            new UsuariosDAO().DeletaUsuario(id);
        }
        [HttpPut("[action]")]
        public void Atualizar([FromBody]Usuarios usuario)
        {
            new UsuariosDAO().Atualiza(usuario);
        }
    }
}
