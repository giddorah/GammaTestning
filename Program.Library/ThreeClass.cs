﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Library
{
    public class ThreeClass
    {
        public bool ThreeReturner(int input)
        {
            if (input % 3 == 0)
            {
                return true;
            }
            return false;
        }
    }
}