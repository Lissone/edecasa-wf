using Edecasa.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edecasa.Controllers
{
    public class ClienteController
    {
        public Cliente getByTelefone(string telefone)
        {
            Cliente cliente = new Cliente();

            try
            {
                using (var ctx = new ModelContext())
                {
                    cliente = ctx.Cliente.SingleOrDefault(o => o.Telefone == telefone);

                    return cliente;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        public List<Cliente> getAll()
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                using (var ctx = new ModelContext())
                {
                    clientes = ctx.Cliente.ToList();

                    return clientes;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public Cliente create(Cliente cliente)
        {
            try
            {
                cliente.Id = 0;

                using (var ctx = new ModelContext())
                {
                    ctx.Cliente.Add(cliente);
                    ctx.SaveChanges();

                    return cliente;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public bool update(Cliente data)
        {
            if (data.Id == 0)
                return false;

            try
            {
                using (var ctx = new ModelContext())
                {
                    var cliente = ctx.Cliente.SingleOrDefault(o => o.Id == data.Id);

                    if (cliente == null)
                    {
                        Console.WriteLine("Este cliente não existe");
                        return false;
                    }

                    cliente.Telefone = data.Telefone;
                    cliente.Rua = data.Rua;
                    cliente.Bairro = data.Bairro;
                    cliente.Numero = data.Numero;
                    cliente.Complemento = data.Complemento;

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
                    var cliente = ctx.Cliente.SingleOrDefault(o => o.Id == id);

                    if (cliente == null)
                    {
                        Console.WriteLine("Este cliente não existe");
                        return false;
                    }

                    ctx.Cliente.Remove(cliente);

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
