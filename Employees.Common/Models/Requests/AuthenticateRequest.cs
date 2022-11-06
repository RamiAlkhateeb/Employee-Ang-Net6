﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Common.Models.Requests
{
    public class AuthenticateRequest
    {
        [Required]
        public string UserEmail { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
