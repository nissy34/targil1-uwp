﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
namespace BL
{
    public interface IBl
    {
        IEnumerable<Flower> GetAllFLowersByName(string name);
    }//
}
