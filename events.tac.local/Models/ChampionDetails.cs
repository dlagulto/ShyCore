using Sitecore.ContentSearch.SearchTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace events.tac.local.Models
{
    public class ChampionDetails:SearchResultItem
    {
        public string ContentBody { get; set; }
        public string ContentHeading { get; set; }
        public string ChampionName { get; set; }
        public string ChampionLore { get; set; }
        public string ChampionRole { get; set; }
        public string ChampionRace { get; set; }
        public string StoryInfo { get; set; }
        public string ContentIntro { get; set; }

        public HtmlString Media { get; set; }
    }
}