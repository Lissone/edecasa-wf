using Edecasa.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Edecasa.Controllers
{
    public class FormasPagamentoController
    {
        public List<FormasPagamento> getAll()
        {
            List<FormasPagamento> tpPagamentos = new List<FormasPagamento>();

            try
            {
                using (var ctx = new ModelContext())
                {
                    tpPagamentos = ctx.FormasPagamento.ToList();

                    return tpPagamentos;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public FormasPagamento create(FormasPagamento tpPagamento)
        {
            try
            {
                tpPagamento.Id = 0;

                using (var ctx = new ModelContext())
                {
                    ctx.FormasPagamento.Add(tpPagamento);
                    ctx.SaveChanges();

                    return tpPagamento;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
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
                    var tpPagamento = ctx.FormasPagamento.SingleOrDefault(o => o.Id == id);

                    if (tpPagamento == null)
                    {
                        Console.WriteLine("Esta forma de pagamento não existe");
                        return false;
                    }

                    ctx.FormasPagamento.Remove(tpPagamento);

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
