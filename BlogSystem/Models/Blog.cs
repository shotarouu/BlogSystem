using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Display(Name ="タイトル")]
        public string Title { get; set; }
        [Display(Name = "投稿日時")]
        public DateTime postDate { get; set; }
        [Display(Name = "投稿内容")]
        public string Content { get; set; }   
    }
}