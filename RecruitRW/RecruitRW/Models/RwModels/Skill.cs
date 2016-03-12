using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitRW.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public string SkillName { get; set; }

        public int SkillValue { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}