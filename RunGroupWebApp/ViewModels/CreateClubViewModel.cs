using RunGroupWebApp.Data.Enums;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.ViewModels
{
    public class CreateClubViewModel
    {
        //this returns a GUID (Globally Unique Identification)...
        public string AppUserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public IFormFile Image { get; set; }
        public ClubCategory ClubCategory { get; set; }
    }
}
