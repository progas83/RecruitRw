using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RWRecrut.Models
{
    public class Candidate
    {
        private const string FIRST_NAME = "Имя";
        private const string LAST_NAME = "Фамилия";
        private const string PUBLISH_DATE = "Дата добавления";
        private const string INTERVIEW_DATE = "Дата собеседования";
        private const string ADRESS = "Адрес";
        private const string CONTACTS = "Контактная информация";
        private const string SKILL = "Перечень умений и навыков";

        public int Id { get; set; }

        [Required]
        [Display(Name = FIRST_NAME)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = LAST_NAME)]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Display(Name = PUBLISH_DATE)]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [Display(Name = INTERVIEW_DATE)]
        public DateTime? InterviewDate { get; set; }

        [Display(Name = ADRESS)]
        public int AdressId { get; set; }
        public Adress Adress { get; set; }

        //[Required]
        //[Display(Name = CONTACTS)]
        //public List<Contact> ContactInformation { get; set; }

        //[Required]
        //[Display(Name = SKILL)]
        //public List<Skill> CandidateSkills { get; set; }
    }
}