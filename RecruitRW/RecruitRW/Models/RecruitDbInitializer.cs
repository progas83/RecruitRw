using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RecruitRW.Models
{
    public class RecruitDbInitializer : DropCreateDatabaseIfModelChanges<RecruitContext>
    {
        protected override void Seed(RecruitContext context)
        {
            context.ContactTypes.Add(new ContactType { TypeName = "Tel" });
            context.ContactTypes.Add(new ContactType { TypeName = "E-Mail" });
            context.ContactTypes.Add(new ContactType { TypeName = "Mobile" });
            context.ContactTypes.Add(new ContactType { TypeName = "ICQ" });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}