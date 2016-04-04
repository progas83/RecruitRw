using RWRecrut.Models.StoreInteractors;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace RWRecrut.Models
{
    public class CandidateContactModel
    {
        public CandidateContactModel()
        {
            SelectedId = -1;
        }
       
        [System.Web.Mvc.HiddenInput(DisplayValue = false)]
        public int SelectedId { get; set; }

        //public IEnumerable<SelectListItem> ContactTypeList
        //{
        //    get
        //    {
        //        return GetSelectListItemsOf(DataProvider.Instance.GetContactTypes());
        //    }
        //}

        private string _newContactType;
        private string _newContactData;

     //   [Required]
        public string NewContactType
        {
            get { return _newContactType; }
            set
            {
               // if(!ExistingContactTypeMatchingTo(value??string.Empty))
                _newContactType = value;
            }
        }

        
       

     //   [Required]
        public string NewContactData
        {
            get { return _newContactData; }
            set { _newContactData = value; }
        }

        //private IEnumerable<SelectListItem> GetSelectListItemsOf(IEnumerable<ContactType> contactTypes)
        //{
        //    List<SelectListItem> selectedList = new List<SelectListItem>();
        //    foreach (var typeName in contactTypes)
        //    {
        //        selectedList.Add(new SelectListItem { Value = typeName.Id.ToString(), Text = typeName.Type });
        //    }
        //    return selectedList;
        //}

        //private bool ExistingContactTypeMatchingTo(string contactType)
        //{
        //    bool result = false;
        //    IEnumerable<ContactType> contactTypes = DataProvider.Instance.GetContactTypes();
        //    ContactType matching = contactTypes.Where(x => x.Type.ToUpper().Equals(contactType.ToUpper())).FirstOrDefault();
        //    if (matching != null)
        //    {
        //        result = true;
        //        SelectedId = matching.Id;
        //        _newContactType = matching.Type;
        //    }

        //    return result;
        //}
    }
}