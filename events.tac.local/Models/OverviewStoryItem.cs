﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace events.tac.local.Models
{
    public class OverviewStoryItem
    {
        public OverviewStoryItem()
        {

        }
        public HtmlString ContentHeading { get; set; }
        public HtmlString DecorationBanner { get; set; }
        public string URL { get; set; }
    }
}