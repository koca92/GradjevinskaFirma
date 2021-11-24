using GradjevinskaFirma.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Linq;
using static GradjevinskaFirma.Data.Context;

namespace GradjevinskaFirma.Controllers
{
    public class APIController : Controller
    { 
        [Route("Api/AddGradiliste")]
        public IActionResult AddGradiliste(string naziv, string adresa)
        {
            using(var db = new Context())
            {
                var gradiliste = new Context.Gradiliste();
                gradiliste.Naziv = naziv;
                gradiliste.Adresa = adresa;
                db.Gradilista.Add(gradiliste);
                db.SaveChanges();
            }
            return RedirectToAction("Gradilista", "Home");
        }
        [Route("Api/AddRadnik")]
        public IActionResult AddRadnik(string prezimeime, string jmbg, int radnomesto)
        {
            using(var context = new Context())
            {
                var radnik = new Radnik();
                radnik.JMBG= jmbg;
                radnik.PrezimeIme = prezimeime;
                radnik.RadnaMesta = context.RadnaMesta.Where(q => q.ID_RM==radnomesto).FirstOrDefault();
                context.Radnici.Add(radnik);
                context.SaveChanges();
            }
            return RedirectToAction("Radnici", "Home");
        }
        public IActionResult AddIzvestaj(int GradilisteID, int PodnosilacZahteva, string Datum, string napomena, string RadniSati)
        {
            var cont = new Context();

            /*
             * {"GradilisteID":"1","PodnosilacZahteva":"1","Datum":"2021-11-02","Napomena":"","RadniSati":"1|21"}*/
            
            

            DnevniIzvestaj dz = new DnevniIzvestaj();
            
            dz.Podnosilac = cont.Radnici.Where(r=>r.ID_Radnici == PodnosilacZahteva).FirstOrDefault<Radnik>();
            dz.Napomena = napomena;
            dz.Gradiliste = cont.Gradilista.Where(g => g.ID == GradilisteID).FirstOrDefault<Gradiliste>();
            dz.Datum = DateTime.Parse(Datum);

            RadniSat radniSat = new RadniSat();

            List<RadniSat> radniSati = new List<RadniSat>();
            var radnis = RadniSati.Split(";");
            foreach(var r in radnis)
            {
                var k = r.Split("|");
                var rs = new RadniSat();
                rs.Radnik = cont.Radnici.Where(m => m.ID_Radnici == int.Parse(k[0])).FirstOrDefault<Radnik>();
                rs.DnevniIzvestaj = dz;
                rs.Sati = int.Parse(k[1]);
                
                radniSati.Add(rs);

            }
            cont.DnevniIzvestaji.Add(dz);
            cont.radniSati.AddRange(radniSati);

            cont.SaveChanges();
            

            return RedirectToAction("DnevniIzvestaj", "Home"); ;
        }
    }
}
