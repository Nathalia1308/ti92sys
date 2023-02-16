using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;

namespace ti92class
{
    public class Cliente
    {


        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }
        public bool Ativo { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public List<Telefone> Telefones { get; set; }

        public Cliente() { }
        public Cliente(int id, string nome, string cpf, string email, DateTime data, bool ativo, List<Telefone> telefones, List<Endereco> enderecos)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Data = data;
            Ativo = ativo;
            Telefones = telefones;
            Enderecos = enderecos;
        }

        public Cliente(string nome, string cpf, string email, DateTime data, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Data = data;
            Ativo = ativo;
        }
        public Cliente(int id)
        {
            Telefones = Telefone.ListarPorCliente(id);
            Enderecos = Endereco.ListarPorCliente(id);
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert clientes (nome, cpf, email, datacad, ativo) values ('" + Nome + "','" + Cpf + "','" + Email + "','" + Data + "'," + Ativo + ")";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            foreach (var telefone in Telefones)
            {
                telefone.Inserir(Id);
            }
            foreach (var endereco in Enderecos)
            {
                endereco.Inserir(Id);
            }


        }
        public static List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from clientes orde by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetDateTime(4), dr.GetBoolean(5), Telefone.ListarPorCliente(dr.GetInt32(0)), Endereco.ListarPorCliente(dr.GetInt32(0))));
            }
            return lista;
        }
        public static Cliente ObterPorId(int _id)
        {
            Cliente cliente = new Cliente();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from clientes where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente.Id = dr.GetInt32(0);
                cliente.Nome = dr.GetString(1);
                cliente.Cpf = dr.GetString(2);
                cliente.Email = dr.GetString(3);
                cliente.Data = dr.GetDateTime(4);
                cliente.Ativo = dr.GetBoolean(5);
                cliente.Telefones = Telefone.ListarPorCliente(dr.GetInt32(0));
                cliente.Enderecos = Endereco.ListarPorCliente(dr.GetInt32(0));
            }
            return cliente;
        }
        public void Atualizar(Cliente cliente)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update clientes set nome = '" + cliente.Nome + "', cpf = '" + cliente.Cpf + "', email = '" + cliente.Email + "', datacad =  '" + cliente.Data + "', ativo" + cliente.Ativo;
            cmd.ExecuteNonQuery();
        }
        public static List<Cliente> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from clientes where nome like '%" + _parte + "%' orde by nome; ";
            var dr = cmd.ExecuteReader();
            List<Cliente> lista = new List<Cliente>();
            while (dr.Read())
            {
                lista.Add(new Cliente(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetDateTime(4), dr.GetBoolean(5), Telefone.ListarPorCliente(dr.GetInt32(0)), Endereco.ListarPorCliente(dr.GetInt32(0))));

            }
            return lista;
        }
        public bool Arquivar(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update clientes set ativo = 0 where id = " + Id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
        public bool Restaurar(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update clientes set ativo = 1 where id = " + Id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
    }
}