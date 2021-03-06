﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageUploadToDB.ViewModels
{
    public class DisplayProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public string ProductImage { get; set; }
    }
}