﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calander_test.Models
{
    [Serializable]
    public class DataModel
    {
        public string title { get; set; }
        public string start { get; set; }
        public string end { get; set; }
    }
}