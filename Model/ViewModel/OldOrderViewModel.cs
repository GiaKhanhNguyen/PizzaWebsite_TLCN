﻿using Model.EnityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    [Serializable]
    public class OldOrderViewModel
    {
        public Order Order { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public Product Product { get; set; }
    }
}
