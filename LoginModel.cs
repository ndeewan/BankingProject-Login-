﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banking.Models
{
    public class LoginModel
    {
        public long Account_No { get; set; }
        public long CRN { get; set; }
        public string Password { get; set; }
    }
}