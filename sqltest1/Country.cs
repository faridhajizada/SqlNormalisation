﻿using System;
using System.Collections.Generic;

namespace sqltest1

{
    public class Country
    {
    
            public int Id{ get; set; }
            public string Name { get; set; }
            public List<City> Cities { get; set; }

    }

}
