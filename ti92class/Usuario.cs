using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace ti92class
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Nivel Nivel { get; set; }
        public bool Ativo { get; set; }

        public Usuario() { }
        
        public Usuario( string _nome, string _email, string _senha, Nivel _nivel, bool _ativo)
        {
            Nome= _nome;
            Email= _email;
            Senha= _senha;
            Nivel= _nivel;
            Ativo= _ativo;
        }
       public Usuario(int _id, string _nome, string _email ,string _senha, Nivel _nivel, bool _ativo)
        {
            Id= _id;
            Nome= _nome;
            Email= _email;
            Senha= _senha;
            Nivel= _nivel;
            Ativo= _ativo;
        }

        public void Inserir()
        {
            // gravar um novo nível na tabela usuarios
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert usuarios (nome, email, senha, nivel_id, ativo) values ('" + Nome + "','" + Email + "','" + Senha + "'," + Nivel.Id + ",'" + Ativo + "',)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static List<Usuario> Listar()
        {
            List<Usuario> lista= new List<Usuario>();
            var cmd =Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                lista.Add(new Usuario
                    (
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                    )
                    );
            }
            return lista;
        }
        public static Usuario ObterPorId(int _id)
        {
            Usuario usuario = new Usuario();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            { 
                usuario.Id = dr.GetInt32(0);
                usuario.Nome= dr.GetString(1);
                usuario.Email= dr.GetString(2);
                Nivel.ObterPorId(dr.GetInt32(4));
                usuario.Senha= dr.GetString(4);
                usuario.Ativo = dr.GetBoolean(5);
            }
            return usuario;
        }
        public static void Atualizar(Usuario usuario)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update usuarios set nome = '" + usuario.Nome + "', email = '" + usuario.Email + "',senha = '" + usuario.Senha + "',Nivel = '" + usuario.Nivel + "',ativo = '" + usuario.Ativo;
            cmd.ExecuteNonQuery();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete * from usuarios where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
        //public static List<Usuario> BuscarPorNome(string _parte)
        //{
        //    var cmd = Banco.Abrir();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select * from usuarios where nome like '%" + _parte + "%' order by nome";
        //    var dr = cmd.ExecuteReader();
        //    List<Usuario> lista = new List<Usuario>();
        //    while (dr.Read()) 
        //    { 
        //        lista.Add(new Usuario
        //            (
        //            dr.GetInt32(0),
        //            dr.GetString(1),
        //            dr.GetString(2),
        //            Nivel.ObterPorId(dr.GetInt32(3)),
        //            dr.GetString(4),
        //            dr.GetBoolean(5)
        //            )
        //        );
        //    }
        //    return lista;
        //}

         
        
        
    }
}
