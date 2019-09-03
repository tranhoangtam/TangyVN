using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tangy.Models
{
    public class SubCategory
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name= "Tên loại")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Nhóm sản phẩm")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    } 
}
