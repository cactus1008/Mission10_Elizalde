using System.ComponentModel.DataAnnotations;

namespace Mission10_Elizalde.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }

        public string TeamName { get; set; }
    }
}
