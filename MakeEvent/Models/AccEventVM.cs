using Microsoft.EntityFrameworkCore.Migrations;

namespace MakeEvent.Models
{
    
    public class AccEventVM
    {
        public User User { get; set; }

        public List<Event> Events { get; set; }
    }
}
