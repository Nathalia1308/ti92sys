using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class Produto
    {
       

        public int Id { get; set;}
        public string Descricao { get; set;}
        public string Unidade { get; set;}
        public string CodBar { get; set;}
        public double Preco { get; set;}
        public double Desconto { get; set;}
        public bool Descontinuado { get; set;}

        
        // Métodos contrutores
        public Produto()
        {
        }
        public Produto(int id, string descricao, string unidade, string codBar, double preco, double desconto, bool descontinuado=false)
        {
            Id = id;
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }

        public Produto(string descricao, string unidade, string codBar, double preco, double desconto, bool descontinuado=false)
        {
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }

        // Métodos da classe 
        public void Inserir()
        {
            // Gravar um novo produto na tabela niveis
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert produtos (descricao, unidade, codbar, preco, desconto, descontinuado) values ('" + Descricao + "','" + Unidade + "','" + CodBar + "'," + Preco + "," + Desconto + ",0)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        public static List<Produto> Listar()
        {
           
            List<Produto> lista = new List<Produto>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from produtos order by descricao asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) // Enquanto houver próximo registro 
            {
                lista.Add(new Produto(
                 dr.GetInt32(0),
                 dr.GetString(1),
                 dr.GetString(2),
                 dr.GetString(3),
                 dr.GetDouble(4),
                 dr.GetDouble(5),
                 dr.GetBoolean(6)
                    )
                );
            }
            dr.Close();
            // retorna a lista preenchida
            return lista;
        }
        public static Produto ObterPorId(int _id)
        {
            Produto produto = new Produto();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from produtos where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto.Id = dr.GetInt32(0);
                produto.Descricao = dr.GetString(1);
                produto.Unidade = dr.GetString(2);
                produto.CodBar = dr.GetString(3);
                produto.Preco = dr.GetDouble(4);
                produto.Desconto = dr.GetDouble(5);
                produto.Descontinuado = dr.GetBoolean(6);
            }

            return produto;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update produtos set descricao = '" + Descricao + "', unidade = '" + Unidade + "', codbar = '" + CodBar + "', preco = '" + Preco + "', desconto ='" + Desconto + "', descontinuado = '" + Descontinuado + "' where id = " + Id;
            cmd.ExecuteNonQuery();
        }
        public bool Arquivar(int _id) // arquivando
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update produtos set descontinuado = 0 where id = " + Id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;

        }
        public bool Reutaurar(int _id) // arquivando
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update produtos set descontinuado = 1 where id = " + Id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;

        }
        public static List<Produto> BuscarPorDescricao(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from produtos where descricao like '%" + _parte + "%' order by descricao;";
            var dr = cmd.ExecuteReader();
            List<Produto> lista = new List<Produto>();
            while (dr.Read()) // Enquanto houver próximo registro 
            {
                lista.Add(new Produto(
                 dr.GetInt32(0),
                 dr.GetString(1),
                 dr.GetString(3),
                 dr.GetString(2),
                 dr.GetDouble(4),
                 dr.GetDouble(5),
                 dr.GetBoolean(6)
                    )
                );
            }
            return lista;
        }
    }

}
