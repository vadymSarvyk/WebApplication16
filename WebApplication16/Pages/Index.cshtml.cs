﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication16.Pages
{
    public class IndexModel : PageModel
    {
        public string Name { get; set; }
        public int? Age { get; set; }
     
        public void OnGet()
        {
            
            Age = 37;
            Name = "Vadym";
        }
    }
}
