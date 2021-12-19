﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikroszimulacio.Entities
{
    public class Person
    {
        public int BirthYear { get; set; }
        public Gender Gender { get; set; }
        public int NbrOfChildren { get; set; }

        public bool IsActive { get; set; }

        public Person()
        {
            IsActive = true;
        }


    }
}
