using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RecruitRW.Models
{
    public class Adress
    {
        [Key,ForeignKey("Candidate")]
        public int CandidateId { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Street { get; set; }
        public int HouseNum { get; set; }
        public int FlatNum { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}