﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmentUWP1.Entity
{
   public class Credential
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public string acount_id { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public int status { get; set; }
    }
}
