using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class Endereco
    {
        public int Id { get; set; }

        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Uf { get; set; }

        public string Tipo { get; set; }

        public Endereco() { }

        public Endereco(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            Tipo = tipo;

        }

        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            Tipo = tipo;

        }
        public void Inserir(int cliente_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert enderecos (cliente_id, cep, logradouro, numero, complemento, bairro, cidade, estado, uf, tipo) values (" + cliente_id + "'" + Cep + "','" + Logradouro + "','" + Numero + "','" + Complemento + "','" + Bairro + "','" + Cidade + "','" + Estado + "','" + Uf + "','" + Tipo + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static List<Endereco> ListarPorCliente(int cliente_id)
        {
            List<Endereco> lista = new List<Endereco>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select estado, cidade, bairro from enderecos where cliente_id =" + cliente_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Endereco(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8), dr.GetString(9)));
            }
            return lista;
        }
        public static Endereco ObterPorId(int _id)
        {
            Endereco endereco = new Endereco();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from enderecos where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco.Id = dr.GetInt32(0);
                endereco.Cep = dr.GetString(1);
                endereco.Logradouro = dr.GetString(2);
                endereco.Numero = dr.GetString(3);
                endereco.Complemento = dr.GetString(4);
                endereco.Bairro = dr.GetString(5);
                endereco.Cidade = dr.GetString(6);
                endereco.Estado = dr.GetString(7);
                endereco.Uf = dr.GetString(8);
                endereco.Tipo = dr.GetString(9);
            }
            return endereco;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update enderecos set cep = '" + Cep + "', logradouro = '" + Logradouro + "',numero = '" + Numero + "', complemento = '" + Complemento + "', bairro = '" + Bairro + "', cidade = '" + Cidade + "', estado = '" + Estado + "', uf = '" + Uf + "', tipo = '" + Tipo;
            cmd.ExecuteNonQuery();
        }
        public static List<Endereco> BuscarPorCidade(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from enderecos where cidade like '%" + _parte + "%' order by cidade;";
            var dr = cmd.ExecuteReader();
            List<Endereco> lista = new List<Endereco>();
            while (dr.Read())
            {
                lista.Add(new Endereco(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8), dr.GetString(9)));
            }
            return lista;
        }
    }
}
