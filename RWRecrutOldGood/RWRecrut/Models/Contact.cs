using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RWRecrut.Models
{
   public class Contact
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public int CintactTypeId { get; set; }
        public ContactType ContactType { get; set; }
        public string Info { get; set; }
    }
}
