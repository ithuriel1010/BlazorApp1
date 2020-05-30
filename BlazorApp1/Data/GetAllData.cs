using EFGetStarted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class GetAllData     //Pobranie informacji o średnich poziomach respondenta i reszty osób zapisanych w bazie
    {
        Respondent respondent;

        public GetAllData(Respondent respondent)
        {
            this.respondent = respondent;
        }

        public double GetAverageAge(Respondent respondent)
        {
            double avgAge;

            using (var db = new BloggingContext())
            {
                avgAge = db.Respondent.Where(x => x.RespondentId != respondent.RespondentId).Average(x => x.Wiek);      //Obliczenie średniego wieku wszystkich respondentów
            }
            return (avgAge);
        }

        public double GetAverageFiz(Respondent respondent)
        {
            double avgFiz;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId != respondent.RespondentId).SelectMany(x => x.StanyFizyczne).Average(x=>x.Poziom);  //Obliczenie średniego poziomu stanu fizycznego wszystkich respondentów
                avgFiz = group;
            }
            return (avgFiz);
        }

        public double GetAverageWiedzaMon(Respondent respondent)
        {
            double avgWiedzaMon;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId != respondent.RespondentId).SelectMany(x => x.TechnologiaWiedzas).Average(x => x.Poziom);   //Obliczenie średniego poziomu wiedzy o technologii wszystkich respondentów
                avgWiedzaMon = group;
            }
            return (avgWiedzaMon);
        }

        public double GetAverageOdczuciaMon(Respondent respondent)
        {
            double avgOdczuciaMon;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId != respondent.RespondentId).SelectMany(x => x.MonitoringOdczucias).Average(x => x.Poziom);  //Obliczenie średniego poziomu odczuć do monitoringu wszystkich respondentów
                avgOdczuciaMon = group;
            }
            return (avgOdczuciaMon);
        }

        public double GetAverageWiedzaTech(Respondent respondent)
        {
            double avgWiedzaTech;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId != respondent.RespondentId).SelectMany(x => x.TechnologiaWiedzas).Average(x => x.Poziom);  //Obliczenie średniego poziomu wiedzy o technologii wszystkich respondentów
                avgWiedzaTech = group;
            }
            return (avgWiedzaTech);
        }

        public double GetResWiedzaTech(Respondent respondent)
        {
            double avgWiedzaTech;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId == respondent.RespondentId).SelectMany(x => x.TechnologiaWiedzas).Average(x => x.Poziom);   //Obliczenie średniego poziomu wiedzy o technologii respondenta
                avgWiedzaTech = group;
            }
            return (avgWiedzaTech);
        }

        public double GetResFiz(Respondent respondent)
        {
            double avgFiz;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId == respondent.RespondentId).SelectMany(x => x.StanyFizyczne).Average(x => x.Poziom);    //Obliczenie średniego poziomu stanu fizycznego respondenta
                avgFiz = group;
            }
            return (avgFiz);
        }

        public double GetResWiedzaMon(Respondent respondent)
        {
            double avgWiedzaMon;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId == respondent.RespondentId).SelectMany(x => x.MonitoringWiedzas).Average(x => x.Poziom);   //Obliczenie średniego poziomu wiedzy o monitoringu respondenta
                avgWiedzaMon = group;
            }
            return (avgWiedzaMon);
        }

        public double GetResOdczuciaMon(Respondent respondent)
        {
            double avgOdczuciaMon;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId != respondent.RespondentId).SelectMany(x => x.MonitoringOdczucias).Average(x => x.Poziom);  //Obliczenie średniego poziomu odczuć do monitoringu respondenta
                avgOdczuciaMon = group;
            }
            return (avgOdczuciaMon);
        }


    }
}
