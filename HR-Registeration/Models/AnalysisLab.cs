using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Registeration.Models
{
    [Table("AnalysisLab", Schema = "dbo")]
    public class AnalysisLab
    {
        [Key]
       
        [Display(Name = "Analysis_Lab_Id")]
        public int Analysis_Lab_ID { get; set; }

        [Required]
        [Column(TypeName = "Varchar(150)")]
        [Display(Name = "Analysis_Lab_Name")]
        public string Analysis_Lab_Name { get; set; }

        [Required]
        [Column(TypeName = "Varchar(150)")]
        [Display(Name = "Analysis_Lab_Address")]
        public string Analysis_Lab_Address { get; set; }
    }
}
