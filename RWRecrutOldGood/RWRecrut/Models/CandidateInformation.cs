using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace RWRecrut.Models
{
    [Serializable]
    public class CandidateInformation
    {
        private const string CITY = "Город";
        private const string STREET = "Улица";
        private const string BUILDING_NUMBER = "Номер дома";
        private const string FLAT_NUMBER = "Номер квартиры";


        public string FirstName { get; set; }
        public string LastName { get; set; }

        //[Required]
        //[Display(Name = CITY)]
        //public string City { get; set; }

        //[Required]
        //[Display(Name = STREET)]
        //public string Street { get; set; }

        //[Required]
        //[Display(Name = BUILDING_NUMBER)]
        //public int Building { get; set; }

        //[Display(Name = FLAT_NUMBER)]
        //public int? Flat { get; set; }

        public CandidateInformation()
        {
            ContactModel = new CandidateContactModel();
            CandidateContacts = new List<CandidateContactModel>();
            CandidateSkills = new List<CandidateSkillModel>();
          //  { new CandidateContactModel(){NewContactData = "fd"},
            //                                                       new CandidateContactModel(){NewContactData = "f1d"}};
                //                                                     new CandidateContactModel(){NewContactData = "f2d"},
                  //                                                   new CandidateContactModel(){NewContactData = "f3d"},
                    //                                                 new CandidateContactModel(){NewContactData = "f4d"}};
        }

  //      public Candidate CurrentCandidate { get; set; }
  //      public Adress CurentAdress { get; set; }
     //   public List<Contact> CurrentContacts { get; set; }
      //  public List<Skill> CurrentSkills { get; set; }

        public void AddNewContact(CandidateContactModel contact)
        {
            try
            {
                CandidateContacts.Add(contact);
            }
            catch(Exception ex)
            {

            }
        }

        public List<CandidateContactModel> CandidateContacts
        {
            get;
            set;
        }
        public CandidateContactModel ContactModel
        {
            get;
            set;
        }


        public List<CandidateSkillModel> CandidateSkills
        {
            get;
            set;
        }

        public CandidateSkillModel NewSkill
        {
            get;
            set;
        }

        public void AddNewSkill(CandidateSkillModel skill)
        {
            try
            {
                CandidateSkills.Add(skill);
            }
            catch (Exception ex)
            {

            }
        }

        public Adress CandidateAdress
        {
            get;
            set;
        }
        //private SelectList _contactTypes;
        //public SelectList ContactTypes
        //{
        //    get { return _contactTypes; }
        //    set { _contactTypes = value; }
        //}

        //internal void AddNewContact(CandidateContactModel contact)
        //{
        //    _preparedContactModels.Add(contact);
        //}

        //private List<CandidateContactModel> _preparedContactModels = new List<CandidateContactModel>();
               
    }
}
