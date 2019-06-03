using AngularModalProject.Modal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AngularModalProject.DAO
{
    public class UsuariosDAO
    {
        const string conexao = @"Data Source=LAPTOP-VKBJ4J6T\SQLEXPRESS;Initial Catalog=ExemploPedidos;Integrated Security=true";
        public List<Usuarios> RetornaUsuarios()
        {
            string sql = @"SELECT * FROM USUARIOS ORDER BY NOME";
            using (var conn = new SqlConnection(conexao))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                var lista = new List<Usuarios>();
                while (reader.Read())
                {
                    Usuarios u = new Usuarios(
                            Convert.ToInt32(reader["ID"]),
                            reader["NOME"].ToString(),
                            Convert.ToInt32(reader["IDADE"])
                        );
                    lista.Add(u);
                }
                return lista;
            }
        }
        public void InserirRegistro(Usuarios usuarios)
        {
            string sql = string.Format(@"INSERT INTO USUARIOS (NOME,IDADE) VALUES ('{0}',{1})", usuarios.Nome, usuarios.Idade);
            using (var conn = new SqlConnection(conexao))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeletaUsuario(int id)
        {
            string sql = string.Format("DELETE FROM USUARIOS WHERE ID = {0}",id);
            using (var conn = new SqlConnection(conexao))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.ExecuteNonQuery();
            }
        }
        public void Atualiza(Usuarios usuario)
        {
            string sql = string.Format("UPDATE USUARIOS SET NOME = '{0}', IDADE = {1} WHERE ID = {2}",usuario.Nome,usuario.Idade, usuario.Id);
            using (var conn = new SqlConnection(conexao))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
