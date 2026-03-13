using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_Elizalde.Data
{
    public class BowlingInfo
    {
        [Key]
        public int BowlerId { get; set; }
        [Required]
        public string BowlerLastName { get; set; }
        [Required]
        public string BowlerFirstName { get; set; }
        public char? BowlerMiddleInit { get; set; }
        [Required]
        public string BowlerAddress { get; set; }
        [Required]
        public string BowlerCity { get; set; }
        [Required]
        public string BowlerState { get; set; }
        [Required]
        public string BowlerZip { get; set; }
        [Required]
        public string BowlerPhoneNumber { get; set; }
        [Required]
        public int TeamID { get; set; }

        [ForeignKey("TeamID")]
        public Team Team { get; set; }
    }
}
