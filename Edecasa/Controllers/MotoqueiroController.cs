using Edecasa.Models;
using System;
using System.Linq;

namespace Edecasa.Controllers
{
    public class MotoqueiroController
    {
        public Motoqueiro get()
        {
            Motoqueiro motoqueiro = new Motoqueiro();

            try
            {
                using (var ctx = new ModelContext())
                {
                    motoqueiro = ctx.Motoqueiro.SingleOrDefault();

                    return motoqueiro;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public Motoqueiro create(Motoqueiro motoqueiro)
        {
            try
            {
                motoqueiro.Id = 0;

                using (var ctx = new ModelContext())
                {
                    ctx.Motoqueiro.Add(motoqueiro);
                    ctx.SaveChanges();

                    return motoqueiro;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public bool delete()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var motoqueiro = ctx.Motoqueiro.SingleOrDefault();

                    if (motoqueiro == null)
                    {
                        Console.WriteLine("Motoqueiro não existe");
                        return false;
                    }

                    ctx.Motoqueiro.Remove(motoqueiro);
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
