using System;
using System.ComponentModel.DataAnnotations;

namespace MyPage.MVC.ViewModels
{
    public class ViewModelLocation : IViewModel
    {
        public Guid? LocationId { get; set; }
        
        [Required(ErrorMessage = "Fill a Name")]
        [MaxLength(150, ErrorMessage = "Name can't have more then 150")]
        [MinLength(2, ErrorMessage = "Name must have at least 2 characters")]
        public string Name { get; set; }

        public double Lat { get; set; }

        public double Lon { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegDate { get; set; }
    }
}
