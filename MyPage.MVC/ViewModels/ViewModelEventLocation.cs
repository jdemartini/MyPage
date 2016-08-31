using System;

namespace MyPage.MVC.ViewModels
{
    public class ViewModelEventLocation : IViewModel
    {
        public ViewModelEvent Event { get; set; }

        public ViewModelLocation Location { get; set; }

        public DateTime ScheduleTime { get; set; }

        public string Description { get; set; }
    }
}