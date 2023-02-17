using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        public Pedido() 
        { 
            Usuario = new Usuario();
            Cliente = new Cliente();
        }

        public Pedido(int id, DateTime data, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens = null)
        {
            Id = id;
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }

        public Pedido(DateTime data, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens = null)
        {
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }
        public void Inserir()
        {

        }
        public static List<Pedido> Listar()
        {
            List<Pedido> list = new List<Pedido>();
            
            return list;
        }
        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new Pedido();
            return pedido;
        }
        public bool Atualizar()
        {
            return false;
        }
        public bool Arquivar(int id)
        {
            return true;
        }
        public void Restaurar()
        {

        }
    }
}
