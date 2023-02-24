using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ti92class
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime ArquivadoEm { get; set; }
        public List<ItemPedido> Itens { get; set; }
        public string Hashcode { get; set; }
        
        public Pedido() 
        { 
            Usuario = new Usuario();
            Cliente = new Cliente();
            Itens = new List<ItemPedido>();
        }

        public Pedido(int id,string hashcode, DateTime data, string status, double desconto, Cliente cliente, Usuario usuario, DateTime arquivadoEm ,List<ItemPedido> itens = null)
        {
            Id = id;
            Hashcode = hashcode;
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
            ArquivadoEm = arquivadoEm;
        }
        public Pedido(Cliente cliente, Usuario usuario)
        {
            Data = new DateTime();
            Status = "A";
            Desconto = 0;
            Cliente = cliente;
            Usuario = usuario;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert pedidos (data, status, desconto, hashcode, cliente_id, usuario_id) values (default, default, 0, @hashcode, @client, @usuar)";
           
            cmd.Parameters.Add("@client", MySqlDbType.Int32).Value = Cliente.Id;
            cmd.Parameters.Add("@user", MySqlDbType.Int32).Value = Usuario.Id;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update pedidos set hashcode = @hashcode + '(select @@identity)' where id = (select @@identity)";
            cmd.Parameters.Clear();
            Random rand = new Random();
            cmd.Parameters.Add("@hashcode", MySqlDbType.VarChar).Value = "P"+rand.Next(10001,99999).ToString();
            cmd.ExecuteNonQuery();
        }
        public static List<Pedido> Listar()
        {
            List<Pedido> list = new List<Pedido>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where arquivado_em is null ord by id desc;";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Pedido(dr.GetInt32(0), dr.GetString(1), dr.GetDateTime(2), dr.GetString(3),dr.GetDouble(4), Cliente.ObterPorId(dr.GetInt32(4)), Usuario.ObterPorId(dr.GetInt32(5)), dr.GetDateTime(6), ItemPedido.Listar(dr.GetInt32(0))));
            }

            return list;
        }
        public static List<Pedido> Arquivados()
        {
            List<Pedido> list = new List<Pedido>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where arquivado_em is not null ord by id desc;";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Pedido(dr.GetInt32(0), dr.GetString(1), dr.GetDateTime(2), dr.GetString(3), dr.GetDouble(4), Cliente.ObterPorId(dr.GetInt32(4)), Usuario.ObterPorId(dr.GetInt32(5)), dr.GetDateTime(6), ItemPedido.Listar(dr.GetInt32(0))));
            }

            return list;
        }
        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new Pedido();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where id = "+id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedido.Id = dr.GetInt32(0);
                pedido.Data = dr.GetDateTime(1);
                pedido.Status= dr.GetString(2);
                pedido.Desconto = dr.GetDouble(3);
                pedido.Cliente = Cliente.ObterPorId(dr.GetInt32(4));
                pedido.Usuario = Usuario.ObterPorId(dr.GetInt32(5));
                pedido.Hashcode = dr.GetString(6);
                pedido.ArquivadoEm = dr.GetDateTime(7);
                pedido.Itens = ItemPedido.Listar(dr.GetInt32(0));
            }
            return pedido;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update pedidos set status = @status, descont = @desconto where id = @id;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.Parameters.AddWithValue("@desconto", Desconto);
            cmd.ExecuteNonQuery();
        }
        public void Arquivar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update pedidos set arquivado_em = now () where id =;" +Id;
            cmd.ExecuteNonQuery();
            
        }
        public void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update pedidos set arquivado_em = null where id =;" + id;
            cmd.ExecuteNonQuery();
        }
        public double ObterTotal()
        {

        }
    }
}
