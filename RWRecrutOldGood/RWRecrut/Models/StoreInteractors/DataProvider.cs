
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
namespace RWRecrut.Models.StoreInteractors
{
    public class DataProvider
    {
        private static DataProvider _dataProvider;
        private static object _padlock = new object();

        public static DataProvider Instance
        {
            get
            {
                if (_dataProvider == null)
                {
                    lock (_padlock)
                        if (_dataProvider == null)
                            _dataProvider = new DataProvider();
                }

                return _dataProvider;
            }
        }


        //public IEnumerable<SelectListItem> GetContactTypes()
        //{
        //    using(var store = new RWRDataContext())
        //    {
        //        List<SelectListItem> selectedList = new List<SelectListItem>();
        //        foreach(var typeName in store.ContactTypes)
        //        {
        //            selectedList.Add(new SelectListItem { Value = typeName.Id.ToString(), Text = typeName.Type });
        //        }
        //        return  selectedList;
        //    }
        //}

        public IEnumerable<ContactType> GetContactTypes()
        {
            List<ContactType> resultList = new List<ContactType>();
            try
            {
             
                using (var store = new RWRDataContext())
                {
                    foreach (var item in store.ContactTypes)
                        resultList.Add(item);
                    
                }
                return resultList;
            }
            catch(Exception ex)
            {
                return resultList;
            }
           
            
        }



        internal void CheckUserInputContactType(CandidateContactModel contact)
        {
            
        }
    }
}