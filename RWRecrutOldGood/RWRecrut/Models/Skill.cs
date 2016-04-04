using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RWRecrut.Models
{
  public  class Skill
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public int SkillTypeId { get; set; }
        public SkillType SkillType { get; set; }
        public int SkillValue { get; set; }
    }
}
