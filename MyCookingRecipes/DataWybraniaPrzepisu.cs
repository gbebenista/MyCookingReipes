﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCookingRecipes
{
    public class DataWybraniaPrzepisu
    {
        public int IDDataWybraniaPrzepisu { get; set; }
        public int IdPrzepisu { get; set; }
        public DateTime DataWyBraniaPrzepisu { get; set; }

        public Przepisy Przepisy { get; set; }

    }
}