using EFGetStarted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class GetAllData
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
                avgAge = db.Respondent.Where(x => x.RespondentId != respondent.RespondentId).Average(x => x.Wiek);
            }
            return (avgAge);
        }

        public double GetAverageFiz(Respondent respondent)
        {
            double avgFiz;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId != respondent.RespondentId).SelectMany(x => x.StanyFizyczne).Average(x=>x.Poziom);
                avgFiz = group;
            }
            return (avgFiz);
        }

        public double GetAverageWiedzaMon(Respondent respondent)
        {
            double avgWiedzaMon;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId != respondent.RespondentId).SelectMany(x => x.TechnologiaWiedzas).Average(x => x.Poziom);
                avgWiedzaMon = group;
            }
            return (avgWiedzaMon);
        }

        public double GetAverageOdczuciaMon(Respondent respondent)
        {
            double avgOdczuciaMon;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId != respondent.RespondentId).SelectMany(x => x.MonitoringOdczucias).Average(x => x.Poziom);
                avgOdczuciaMon = group;
            }
            return (avgOdczuciaMon);
        }

        public double GetAverageWiedzaTech(Respondent respondent)
        {
            double avgWiedzaTech;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId != respondent.RespondentId).SelectMany(x => x.MonitoringOdczucias).Average(x => x.Poziom);
                avgWiedzaTech = group;
            }
            return (avgWiedzaTech);
        }

        public double GetResWiedzaTech(Respondent respondent)
        {
            double avgWiedzaTech;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId == respondent.RespondentId).SelectMany(x => x.MonitoringOdczucias).Average(x => x.Poziom);
                avgWiedzaTech = group;
            }
            return (avgWiedzaTech);
        }

        public double GetResFiz(Respondent respondent)
        {
            double avgFiz;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId == respondent.RespondentId).SelectMany(x => x.StanyFizyczne).Average(x => x.Poziom);
                avgFiz = group;
            }
            return (avgFiz);
        }

        public double GetResWiedzaMon(Respondent respondent)
        {
            double avgWiedzaMon;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId == respondent.RespondentId).SelectMany(x => x.TechnologiaWiedzas).Average(x => x.Poziom);
                avgWiedzaMon = group;
            }
            return (avgWiedzaMon);
        }

        public double GetResOdczuciaMon(Respondent respondent)
        {
            double avgOdczuciaMon;

            using (var db = new BloggingContext())
            {
                var group = db.Respondent.Where(x => x.RespondentId != respondent.RespondentId).SelectMany(x => x.MonitoringOdczucias).Average(x => x.Poziom);
                avgOdczuciaMon = group;
            }
            return (avgOdczuciaMon);
        }


    }
}
