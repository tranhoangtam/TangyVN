using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tangy.Models
{
	[Table("MenuItem")]
    public class MenuItem
    {
		[Required]
	    public int Id { get; set; }
		[Required(ErrorMessage = "Vui lòng nhập tên sản phẩm")]
		[MaxLength(255,ErrorMessage = "Độ dài tên sản phẩm không quá 250 ký tự")]
		[Display(Name = "Tên sản phẩm")]
	    public string Name { get; set; }
		[Display(Name = "Mô tả")]
	    public string Description { get; set; }
        [Display(Name = "Ảnh")]
        public string Image { get; set; }
		[Range(1,int.MaxValue,ErrorMessage = "Giá bán phải lớn hơn 1 đồng")]
		[Display(Name = "Giá bán")]
	    public double Price { get; set; }
		[Display(Name = "Số lượng")]
	    public double Quantity { get; set; }
		[Display(Name = "Độ tin cậy")]
	    public string Spicyness { get; set; }
		public enum EScipy
		{
			NA=0,Spicy=1,VerySpicy=2
		}
		[Display(Name = "Nhóm sản phẩm")]
		
		public int CategoryId { get; set; }
		[ForeignKey("CategoryId")]
		public virtual Category Category { get; set; }

		[Display(Name = "Loại sản phẩm")]
		public int SubCategoryId { get; set; }
		[ForeignKey("SubCategoryId")]
		public virtual  SubCategory SubCategory { get; set; }
	}
}
