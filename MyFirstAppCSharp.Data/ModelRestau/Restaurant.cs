﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAppCSharp.Data.ModelRestau {
    public class Restaurant {
        public Address address { get; set; }
        public string borough { get; set; }
        public string cuisine { get; set; }
        public List<Grade> grades { get; set; }
        public string name { get; set; }
        public string restaurant_id { get; set; }
    }
    public class Address {
        public string building { get; set; }
        public Coord coord { get; set; }
        public string street { get; set; }
        public string zipcode { get; set; }
    }

    public class Grade {
        public long date { get; set; }
        public string grade { get; set; }
        public int score { get; set; }
    }

}
