﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class PageControl
    {
        private static Authorization auth;
        public static Authorization authorization
        {
            get
            {
                if (auth == null)
                    auth = new Authorization();
                return auth;
            }
        }
    }
}
