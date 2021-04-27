using Edecasa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edecasa.Controllers
{
    class ItemController
    {
        public List<Item> getByPedidoId(int pedidoId)
        {
            List<Item> itens = new List<Item>();

            try
            {
                using (var ctx = new ModelContext())
                {
                    itens = ctx.Item
                        .Include("Produto")
                        .Include("Pedido")
                        .Where(o => o.PedidoId == pedidoId)
                        .ToList();

                    return itens;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        public List<Item> getAll()
        {
            List<Item> itens = new List<Item>();

            try
            {
                using (var ctx = new ModelContext())
                {
                    itens = ctx.Item
                        .Include("Produto")
                        .Include("Pedido")
                        .ToList();

                    return itens;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public Item create(Item item)
        {
            try
            {
                item.Id = 0;

                using (var ctx = new ModelContext())
                {
                    ctx.Item.Add(item);
                    ctx.SaveChanges();

                    return item;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public bool update(Item data)
        {
            if (data.Id == 0)
                return false;

            try
            {
                using (var ctx = new ModelContext())
                {
                    var item = ctx.Item.SingleOrDefault(o => o.Id == data.Id);

                    if (item == null)
                    {
                        Console.WriteLine("Este item não existe");
                        return false;
                    }

                    item.Quantidade = data.Quantidade;
                    item.Tamanho = data.Tamanho;
                    item.ProdutoId = data.ProdutoId;
                    item.PedidoId = data.PedidoId;

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
            if (id == 0)
                return false;

            try
            {
                using (var ctx = new ModelContext())
                {
                    var item = ctx.Item.SingleOrDefault(o => o.Id == id);

                    if (item == null)
                    {
                        Console.WriteLine("Este item não existe");
                        return false;
                    }

                    ctx.Item.Remove(item);

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
