using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ti92class
{
    public class Cliente
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set;}
        public string Email { get; set;}
        public DateTime Data { get; set;}
        public bool Ativo { get; set;}

        public Cliente() { }
        public Cliente(int id, string nome, int cpf, string email, DateTime data, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Data = data;
            Ativo = ativo;
        }

        public Cliente(string nome, int cpf, string email, DateTime data, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Data = data;
            Ativo = ativo;
        }
        private void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert clientes (nome, cpf, email, datacad, ativo) values ('" + Nome + "'," + Cpf + ",'" + Email + "','" + Data + "'," + Ativo + " )";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar()); 
        }
        public static List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd= Banco.Abrir();
            cmd.CommandText = "select * from "
        }
    }

}
