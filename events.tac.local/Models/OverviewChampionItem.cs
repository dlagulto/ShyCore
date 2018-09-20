using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace events.tac.local.Models
{
    public class OverviewChampionItem
    {
        public OverviewChampionItem()
        {

        }
        public HtmlString ContentHeading { get; set; }
        public HtmlString Media { get; set; }
        public string URL { get; set; }
    }

}