﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.ViewModels.UserVM
{
    public class VerifyCodeViewModel
    {
        public string Country_code { get; set; }
        public string Phone { get; set; }
        public string Generated_code { get; set; }
    }
}
