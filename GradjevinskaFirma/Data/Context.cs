using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static GradjevinskaFirma.Data.Context;

namespace GradjevinskaFirma.Data
{
    public class Context : DbContext
    {
        
        public DbSet<RadnoMesto> RadnaMesta { get; set; }
        public DbSet<TipObracuna> TipoviObracuna { get; set; }
        public DbSet<VrstaZaposlenja> VrsteZaposlenja { get; set; }
        public DbSet<Radnik> Radnici { get; set; }
        public DbSet<Gradiliste> Gradilista { get; set; }
        public DbSet<DnevniIzvestaj> DnevniIzvestaji { get; set; }
        public DbSet<RadniSat> radniSati { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlite("Data Source = TamaraTest1.db");
        }


        public class RadnoMesto
        {
            [Key]
            public int ID_RM { get; set; }
            public string RM { get; set; }
            public virtual ICollection<Radnik> Radnici { get; set; }
        }

        public class TipObracuna
        {
            [Key]
            public int ID_Obracun { get; set; }
            public string Obracun { get; set; }
            public virtual ICollection<Radnik> Radnici { get; set;}
        }
        public class VrstaZaposlenja
        {
            [Key]
            public int ID_VZ { get; set; }
            public string VZ { get; set; }
            public virtual ICollection<Radnik> Radnici { get; set; }

        }
        public class Radnik
        {
            [Key]
            public int ID_Radnici { get; set; }
            public string JMBG { get; set; }
            public string PrezimeIme { get; set; }
            public string? SSS { get; set; }
            public TipObracuna? TipObracuna { get; set; }
           
            public RadnoMesto RadnaMesta { get; set; }
            public VrstaZaposlenja? VrstaZaposlenja { get; set; }
            public DateOnly PocetakOsiguranja { get; set; }
            public DateOnly PrestanakOsiguranja { get; set; }
        }
        public class Gradiliste
        {
            [Key]
            public int ID { get; set; }
            public string Naziv { get; set; }
            public string Adresa { get; set; }
        }
        public class DnevniIzvestaj
        {
            [Key]
            public int ID { get; set; }
            public Gradiliste Gradiliste { get; set; }
            public string Napomena { get; set; }
            public Radnik Podnosilac { get; set; }
            public DateTime Datum { get; set; }
            public virtual ICollection<RadniSat> RadniSati { get; set; }
        }
        public class RadniSat
        {
            [Key]
            public int ID { get; set; }
            public DnevniIzvestaj DnevniIzvestaj { get; set; }
            public Radnik Radnik { get; set; }
            public int Sati { get; set; }
        }
    }
}
