﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EagerLoading.Models
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

      
    }
}
