using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitRW.Models
{
    public class Candidate
    {
        public Candidate()
        {
            Contacts = new List<ContactInformation>();
            Skills = new List<Skill>();
        }
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime? ConversationDate { get; set; }

        public virtual ICollection<ContactInformation> Contacts { get; set; }

        public virtual Adress Adress { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }
    }
}