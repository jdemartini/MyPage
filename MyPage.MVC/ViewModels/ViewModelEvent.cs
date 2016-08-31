using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyPage.MVC.ViewModels
{
    public class ViewModelEvent : IViewModel
    {
        [Key]
        public Guid? EventId{ get; set; }

        [Required(ErrorMessage="Fill a title")]
        [MaxLength(150, ErrorMessage="Title can't have more then 150")]
        [MinLength(2, ErrorMessage="Title must have at least 2 characters")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Event Date")]
        public DateTime EventDate { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "Event place can't have more then 150")]
        [MinLength(2, ErrorMessage = "Event place must have at least 2 characters")]
        [DisplayName("Event Place")]
        public string EventPlace { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegDate { get; set; }

        public IEnumerable<ViewModelLocation> TransmissionPlaces { get; set; } 

    }
}