﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1_PromotionEngine.Model
{
    public class ItemForCart : Product
    {
        public ItemForCart(string sKU, double price, int cuantity) : base(sKU, price)
        {
            Cuantity = cuantity;
        }

        public int Cuantity { get; set; }
    }
}
