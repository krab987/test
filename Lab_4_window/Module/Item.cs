﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_window.Module
{
    public class Item
    {
        public Item left, right; //покажчик на пiддерева
        public string inf;
        public Item(string inf)
        {
            this.inf = inf;
        }
    }
}
