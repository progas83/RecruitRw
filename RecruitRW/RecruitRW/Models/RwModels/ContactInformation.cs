using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RecruitRW.Models
{
    public class ContactInformation
    {
        [Key]
        public int Id { get; set; }


        public int ContactTypeName { get; set; }

        [ForeignKey("ContactTypeName")]
        public virtual ContactType ContactType { get; set; }

        public string Contact { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}