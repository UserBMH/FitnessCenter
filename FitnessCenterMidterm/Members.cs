﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenterMidterm
{
    internal abstract class Members
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
        public string Membership { get; set; }

        public abstract void CheckIn(Club club); 
    }
}
