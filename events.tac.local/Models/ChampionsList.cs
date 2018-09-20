using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace events.tac.local.Models
{
    public class ChampionsList
    {
        public IEnumerable<ChampionDetails> Stories { get; set; }
        public int TotalResultCount { get; set; }
        public int PageSize { get; set; }

    }
}