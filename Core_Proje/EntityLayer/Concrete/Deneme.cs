﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Deneme 
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
