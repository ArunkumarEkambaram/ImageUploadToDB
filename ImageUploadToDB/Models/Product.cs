using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ImageUploadToDB.Models
{
    [Table("tblProduct")]
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public byte[] ProductImage { get; set; }//varbinary(max)
        
    }
}