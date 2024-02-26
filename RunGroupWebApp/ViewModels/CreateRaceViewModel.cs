using RunGroupWebApp.Data.Enums;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.ViewModels
{
    public class CreateRaceViewModel
    {
        public string AppUserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public IFormFile Image { get; set; }
        public RaceCategory RaceCategory { get; set; }
    }
}
