using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Template.BL.Models
{
    public class DepartmentVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Required")]
        [MinLength(3, ErrorMessage = "Min Len 3")]
        [MaxLength(50, ErrorMessage = "Max Len 50")]
        public string Name { get; set; }

        [Required(ErrorMessage = "salary Required")]
        [Range(1, 10000, ErrorMessage = "Range Btw 1K : 10K")]
        public string salary { get; set; }
    }
}
