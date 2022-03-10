using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Registeration.Models
{
    [Table("RaysLab", Schema = "dbo")]
    public class RaysLab
    {
            [Key]
            [Display(Name = "Rays_Lab_ID")]
            public int Rays_Lab_ID { get; set; }

            [Required]
            [Column(TypeName = "Varchar(150)")]
            [Display(Name = "Rays_Lab_Name")]
            public string Rays_Lab_Name { get; set; }

            [Required]
            [Column(TypeName = "Varchar(150)")]
            [Display(Name = "Rays_Lab_Address")]
            public string Rays_Lab_Address { get; set; }
        }
    }


