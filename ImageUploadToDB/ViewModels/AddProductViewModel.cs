using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImageUploadToDB.ViewModels
{
    public class AddProductViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        [Display(Name = "Upload Image")]
        public HttpPostedFileBase ImageData { get; set; }
    }
}