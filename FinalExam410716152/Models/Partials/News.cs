﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalExam410716152.Models.Partials
{
    [MetadataType(typeof(NewsMetadata))]
    public partial class News
    {
        
    }
    public class NewsMetadata
    {
        public int Id { get; set; }
        
        
        [Required(ErrorMessage = "請輸入標題")]
        
        [MinLength(50, ErrorMessage = "欄位 標題 必須最大長度為50的字串")]
        public string Title { get; set; }
        
        
        [Required(ErrorMessage = "必填欄位")]
     
        public string Content { get; set; }
        
        
        
        [Required(ErrorMessage = "必填欄位")]
        
        
        public System.DateTime PublishDate { get; set; }
    }
}