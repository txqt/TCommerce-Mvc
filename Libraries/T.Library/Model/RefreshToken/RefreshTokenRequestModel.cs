﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Library.Model.RefreshToken
{
    public class RefreshTokenRequestModel
    {
        public string? RefreshToken { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
