using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hachi.Models.SubCategoryViewModels
{
    public class SubCategoryAndCategoryViewModel
    {
        //Làm điểu này sẽ hiển thị tên trên View thay vì là ID
        public SubCategory SubCategory { get; set; }

        public IEnumerable<Category> CategoryList { get; set; }

        public List<string> SubCategoryList { get; set; }

        [Display(Name = "New Sub Category")]

        public bool isNews { get; set; }
        public string StatusMessage { get; set; }
    }
}
