using System.ComponentModel.DataAnnotations;

namespace Mission10_Elizalde.Data
{
    public class Team
    {
        // This is all the info we need from the teams table to be passed
        [Key]
        public int TeamID { get; set; }

        public string TeamName { get; set; }
    }
}
