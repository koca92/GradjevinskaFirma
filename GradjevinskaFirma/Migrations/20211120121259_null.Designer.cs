// <auto-generated />
using System;
using GradjevinskaFirma.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GradjevinskaFirma.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211120121259_null")]
    partial class @null
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("GradjevinskaFirma.Data.Context+DnevniIzvestaj", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TEXT");

                    b.Property<int>("GradilisteID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Napomena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PodnosilacID_Radnici")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("GradilisteID");

                    b.HasIndex("PodnosilacID_Radnici");

                    b.ToTable("DnevniIzvestaji");
                });

            modelBuilder.Entity("GradjevinskaFirma.Data.Context+Gradiliste", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Gradilista");
                });

            modelBuilder.Entity("GradjevinskaFirma.Data.Context+Radnik", b =>
                {
                    b.Property<int>("ID_Radnici")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("PocetakOsiguranja")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("PrestanakOsiguranja")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrezimeIme")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RadnaMestaID_RM")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SSS")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TipObracunaID_Obracun")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("VrstaZaposlenjaID_VZ")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID_Radnici");

                    b.HasIndex("RadnaMestaID_RM");

                    b.HasIndex("TipObracunaID_Obracun");

                    b.HasIndex("VrstaZaposlenjaID_VZ");

                    b.ToTable("Radnici");
                });

            modelBuilder.Entity("GradjevinskaFirma.Data.Context+RadniSat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DnevniIzvestajID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RadnikID_Radnici")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sati")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("DnevniIzvestajID");

                    b.HasIndex("RadnikID_Radnici");

                    b.ToTable("radniSati");
                });

            modelBuilder.Entity("GradjevinskaFirma.Data.Context+RadnoMesto", b =>
                {
                    b.Property<int>("ID_RM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RM")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID_RM");

                    b.ToTable("RadnaMesta");
                });

            modelBuilder.Entity("GradjevinskaFirma.Data.Context+TipObracuna", b =>
                {
                    b.Property<int>("ID_Obracun")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Obracun")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID_Obracun");

                    b.ToTable("TipoviObracuna");
                });

            modelBuilder.Entity("GradjevinskaFirma.Data.Context+VrstaZaposlenja", b =>
                {
                    b.Property<int>("ID_VZ")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("VZ")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID_VZ");

                    b.ToTable("VrsteZaposlenja");
                });

            modelBuilder.Entity("GradjevinskaFirma.Data.Context+DnevniIzvestaj", b =>
                {
                    b.HasOne("GradjevinskaFirma.Data.Context+Gradiliste", "Gradiliste")
                        .WithMany()
                        .HasForeignKey("GradilisteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GradjevinskaFirma.Data.Context+Radnik", "Podnosilac")
                        .WithMany()
                        .HasForeignKey("PodnosilacID_Radnici")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gradiliste");

                    b.Navigation("Podnosilac");
                });

            modelBuilder.Entity("GradjevinskaFirma.Data.Context+Radnik", b =>
                {
                    b.HasOne("GradjevinskaFirma.Data.Context+RadnoMesto", "RadnaMesta")
                        .WithMany("Radnici")
                        .HasForeignKey("RadnaMestaID_RM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GradjevinskaFirma.Data.Context+TipObracuna", "TipObracuna")
                        .WithMany("Radnici")
                        .HasForeignKey("TipObracunaID_Obracun");

                    b.HasOne("GradjevinskaFirma.Data.Context+VrstaZaposlenja", "VrstaZaposlenja")
                        .WithMany("Radnici")
                        .HasForeignKey("VrstaZaposlenjaID_VZ");

                    b.Navigation("RadnaMesta");

                    b.Navigation("TipObracuna");

                    b.Navigation("VrstaZaposlenja");
                });

            modelBuilder.Entity("GradjevinskaFirma.Data.Context+RadniSat", b =>
                {
                    b.HasOne("GradjevinskaFirma.Data.Context+DnevniIzvestaj", "DnevniIzvestaj")
                        .WithMany("RadniSati")
                        .HasForeignKey("DnevniIzvestajID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GradjevinskaFirma.Data.Context+Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("RadnikID_Radnici")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DnevniIzvestaj");

                    b.Navigation("Radnik");
                });

            modelBuilder.Entity("GradjevinskaFirma.Data.Context+DnevniIzvestaj", b =>
                {
                    b.Navigation("RadniSati");
                });

            modelBuilder.Entity("GradjevinskaFirma.Data.Context+RadnoMesto", b =>
                {
                    b.Navigation("Radnici");
                });

            modelBuilder.Entity("GradjevinskaFirma.Data.Context+TipObracuna", b =>
                {
                    b.Navigation("Radnici");
                });

            modelBuilder.Entity("GradjevinskaFirma.Data.Context+VrstaZaposlenja", b =>
                {
                    b.Navigation("Radnici");
                });
#pragma warning restore 612, 618
        }
    }
}
