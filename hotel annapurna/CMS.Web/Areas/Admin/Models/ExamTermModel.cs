﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Web.Areas.Core.Models
{
    public class ExamTermModel
    {
        public long exam_term_id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        [Display(Name = "Title")]
        public string name { get; set; }

      

        [Display(Name = "Status")]
        public bool is_active { get; set; } = true;




      
      
        }
}
