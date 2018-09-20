using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using events.tac.local.Business;

namespace events.tac.local.Controllers
{
    public class ChampionsListController : Controller
    {
        private readonly StoriesProvider _provider;
        public ChampionsListController() : this(new StoriesProvider()) { }
        public ChampionsListController(StoriesProvider provider)
        {
            _provider = provider;
        }
        // GET: EventsList
        public ActionResult Index(int page = 1)
        {
            return View(_provider.GetChampionsList(page - 1));
        }
    }
}
