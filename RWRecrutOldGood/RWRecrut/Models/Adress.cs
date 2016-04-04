using System.ComponentModel.DataAnnotations;

namespace RWRecrut.Models
{
   public class Adress
    {
        private const string CITY = "Город";
        private const string STREET ="Улица";
        private const string BUILDING_NUMBER = "Номер дома";
        private const string FLAT_NUMBER = "Номер квартиры";

        public int Id { get; set; }

        [Required]
        [Display(Name = CITY)]
        public string City { get; set; }

        [Required]
        [Display(Name = STREET)]
        public string Street { get; set; }

        [Required]
        [Display(Name = BUILDING_NUMBER)]
        public int Building { get; set; }

        [Display(Name = FLAT_NUMBER)]
        public int? Flat { get; set; }
    }
}