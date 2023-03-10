using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }

        public Telefone() { }

        public Telefone(int id, string numero, string tipo)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
        }

        public Telefone(string numero, string tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }

        public void Inserir(int cliente_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefones (cliente_id, numero, tipo) values (" + cliente_id + ",'" + Numero + "','" + Tipo + "')";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static List<Telefone> ListarPorCliente(int cliente_id)
        {
            List<Telefone> listaTel = new List<Telefone>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, numero, tipo from telefones where cliente_id = " + cliente_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaTel.Add(new Telefone(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)));
            }
            return listaTel;
        }
        public static Telefone ObterPorId(int _id)
        {
            Telefone telefone = new Telefone();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from telefones where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                telefone.Id = dr.GetInt32(0);
                telefone.Numero = dr.GetString(1);
                telefone.Tipo = dr.GetString(2);
            }
            return telefone;
        }
        //public bool Arquivar(int _id)
        //{
        //    var cmd = Banco.Abrir();
        //    cmd.CommandText = "update clientes set ativo = 0 where id = " + Id;
        //    bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
        //    return result;
        //}
        //public bool Restaurar(int _id)
        //{
        //    var cmd = Banco.Abrir();
        //    cmd.CommandText = "update telefones set ativo = 1 where id = " + Id;
        //    bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
        //    return result;
        //}
    }
}
