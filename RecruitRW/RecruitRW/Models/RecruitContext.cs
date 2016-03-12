using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RecruitRW.Models
{
    public class RecruitContext : DbContext
    {
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