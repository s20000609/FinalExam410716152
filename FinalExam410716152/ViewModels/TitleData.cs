using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalExam410716152.ViewModels
{
    public class TitleData
    {
        [Display(Name = "標題")]
        [Required(ErrorMessage = "請輸入標題")]
        [MinLength(50, ErrorMessage = "欄位 標題 必須最大長度為50的字串")]
        
        public string Title { get; set; }

       
        [Required(ErrorMessage = "必填欄位")]
        
        public string Result { get; set; }

       
        [Required(ErrorMessage = "必填欄位")]
        
        public string Date{ get; set; }


    }
}