﻿
using ShopOnlineSmart.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnlineSmart.Data.Entity
{
    public class Slide
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Url { set; get; }

        public string Image { get; set; }
        public int SortOrder { get; set; }
        public Status Status { set; get; }
    }
}