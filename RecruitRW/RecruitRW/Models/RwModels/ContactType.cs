using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RecruitRW.Models
{
    public class ContactType
    {
        [Key]
        public int Id { get; set; }

        public string TypeName { get; set; }
    }
}