using Edecasa.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Edecasa.Controllers
{
    public class PedidoController
    {
        public List<Pedido> getAll()
        {
            List<Pedido> pedidos = new List<Pedido>();

            try
            {
                using (var ctx = new ModelContext())
                {
                    pedidos = ctx.Pedido
                        .Include("Cliente")
                        .Include("TpPagamento")
                        .ToList();

                    return pedidos;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public Pedido getOne(int id)
        {
            if (id == 0)
                return null;

            Pedido pedido = new Pedido();

            try
            {
                using (var ctx = new ModelContext())
                {
                    pedido = ctx.Pedido
                        .Include("Cliente")
                        .Include("TpPagamento")
                        .SingleOrDefault(o => o.Id == id);

                    return pedido;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public Pedido create(Pedido pedido)
        {
            try
            {
                pedido.Id = 0;

                using (var ctx = new ModelContext())
                {
                    ctx.Pedido.Add(pedido);
                    ctx.SaveChanges();

                    return pedido;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public bool update(Pedido data)
        {
            try
            {
                if (data.Id == 0)
                    return false;

                using (var ctx = new ModelContext())
                {
                    var pedido = ctx.Pedido.SingleOrDefault(o => o.Id == data.Id);

                    if (pedido == null)
                    {
                        Console.WriteLine("Este pedido não existe");
                        return false;
                    }

                    pedido.Valor = data.Valor;
                    pedido.Taxa = data.Taxa;
                    pedido.VlMotoqueiro = data.VlMotoqueiro;
                    pedido.Completado = data.Completado;
                    pedido.Data = data.Data;
                    pedido.ClienteId = data.ClienteId;
                    pedido.TpPagamentoId = data.TpPagamentoId;

                    ctx.SaveChanges();

                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool delete(int id)
        {
            try
            {
                if (id == 0)
                    return false;

                using (var ctx = new ModelContext())
                {
                    var pedido = ctx.Pedido.SingleOrDefault(o => o.Id == id);

                    if (pedido == null)
                    {
                        Console.WriteLine("Este pedido não existe");
                        return false;
                    }

                    ctx.Pedido.Remove(pedido);

                    ctx.SaveChanges();

                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
