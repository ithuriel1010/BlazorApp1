using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted
{
    public class BloggingContext : DbContext    //Klasa z definicją wszystkich tabel w bazie danych
    {
        public DbSet<Respondent> Respondent { get; set; }
        public DbSet<Choroba> Choroba { get; set; }
        public DbSet<OsobaBliska> OsobaBliska { get; set; }
        public DbSet<StanFizyczny> StanFizyczny { get; set; }
        public DbSet<MonitoringOdczucia> MonitoringOdczucia { get; set; }
        public DbSet<MonitoringWiedza> MonitoringWiedza { get; set; }
        public DbSet<AwariaWiedza> AwariaWiedza { get; set; }
        public DbSet<TechnologiaWiedza> TechnologiaWiedza { get; set; }
        public DbSet<OdczuciawDomu> OdczuciawDomu { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseNpgsql("Host = 192.168.1.197; Database=ankiety;Username=ankiety;Password=AnkietY");
    }   
    
    public class Respondent
    {
        public int RespondentId { get; set; }
        public bool Sex { get; set; }
        public bool Grupa { get; set; }
        public int Wiek { get; set; }
        public string Wyksztalcenie { get; set; }
        public ICollection<Choroba> Choroby { get; set; }
        public ICollection<StanFizyczny> StanyFizyczne { get; set; }
        public ICollection<OsobaBliska> OsobyBliskie { get; set; }
        public ICollection<OdczuciawDomu> OdczuciawDomus { get; set; }
        public ICollection<TechnologiaWiedza> TechnologiaWiedzas { get; set; }
        public ICollection<AwariaWiedza> AwariaWiedzas { get; set; }
        public ICollection<MonitoringOdczucia> MonitoringOdczucias { get; set; }
        public ICollection<DoswiadczenieZSeniorem> DoswiadczenieZSeniorems { get; set; }
        public ICollection<MonitoringWiedza> MonitoringWiedzas { get; set; }




        public void Update(bool sex, bool grupa, int wiek, string wyksztalcenie, List<Choroba> choroby, List<StanFizyczny> stanyFizyczne, List<OsobaBliska> osobyBliskie,
            List<OdczuciawDomu> odczuciawDomu, List<TechnologiaWiedza> technologiaWiedza, List<AwariaWiedza> awariaWiedza, List<MonitoringOdczucia> monitoringOdczucia,
            List<DoswiadczenieZSeniorem> doswiadczenieZSeniorem, List<MonitoringWiedza> monitoringWiedza)
        {
            Sex = sex;
            Grupa = grupa;
            Wiek = wiek;
            Wyksztalcenie = wyksztalcenie;
            Choroby = choroby;
            StanyFizyczne = stanyFizyczne;
            OsobyBliskie = osobyBliskie;
            OdczuciawDomus = odczuciawDomu;
            TechnologiaWiedzas = technologiaWiedza;
            AwariaWiedzas = awariaWiedza;
            MonitoringOdczucias = monitoringOdczucia;
            DoswiadczenieZSeniorems = doswiadczenieZSeniorem;
            MonitoringWiedzas = monitoringWiedza;
        }

    }
    public class Choroba
    {
        public Respondent Respondent { get; set; }
        public int ChorobaId { get; set; }
        public string Nazwa { get; set; }

    }
    public class OsobaBliska
    {
        public Respondent Respondent { get; set; }
        public int OsobaBliskaId { get; set; }
        public string Nazwa { get; set; }

    }
    public class OdczuciawDomu
    {
        public Respondent Respondent { get; set; }
        public int OdczuciawDomuId { get; set; }
        public int Poziom { get; set; }

    }
    public class StanFizyczny
    {
        public Respondent Respondent { get; set; }
        public int StanFizycznyId { get; set; }
        public int Poziom { get; set; }
    }
    public class MonitoringOdczucia
    {
        public Respondent Respondent { get; set; }
        public int MonitoringOdczuciaId { get; set; }
        public int Poziom { get; set; }
    }
    public class MonitoringWiedza
    {
        public Respondent Respondent { get; set; }
        public int MonitoringWiedzaId { get; set; }
        public int Poziom { get; set; }
    }
    public class AwariaWiedza
    {
        public Respondent Respondent { get; set; }
        public int AwariaWiedzaId { get; set; }
        public int Poziom { get; set; }
    }

    public class DoswiadczenieZSeniorem
    {
        public Respondent Respondent { get; set; }
        public int DoswiadczenieZSenioremId { get; set; }
        public int Poziom { get; set; }
    }
    public class TechnologiaWiedza
    {
        public Respondent Respondent { get; set; }
        public int TechnologiaWiedzaId { get; set; }
        public int Poziom { get; set; }
    }
}