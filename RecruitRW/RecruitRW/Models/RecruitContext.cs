using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RecruitRW.Models
{
    public class RecruitContext : DbContext
    {
        //   private string connectionString=@"Data Source = ILYAPC\SQLEXPRESS; AttachDbFilename=|DataDirectory|RwDataBase.mdf;Integrated Security = true";
        //public RecruitContext() :  base(@"Data Source = ILYAPC\LIONDB; AttachDbFilename=|DataDirectory|RwDataBase1.mdf;Integrated Security = False")//
        public RecruitContext() : base("RwDataBase")
        {
            //Database.SetInitializer<RecruitContext>(new CreateDatabaseIfNotExists<RecruitContext>());
            //   Database.SetInitializer<RecruitContext>(new RecruitDbInitializer());

        }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<ContactInformation> ContactInformations { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}