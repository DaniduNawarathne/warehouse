﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectICT.Bill
{
    class userbill
    {
        public int EmployeeID { get; set; }

        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string user_type { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
