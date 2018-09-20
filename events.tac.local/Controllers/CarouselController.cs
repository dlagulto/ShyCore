using events.tac.local.Models;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace events.tac.local.Controllers
{
    public class CarouselController : Controller
    {
        // GET: Carousel
        public ActionResult Index()
        {
            var currentItem = RenderingContext.Current.Rendering.Item;
            var items = currentItem.Axes.GetDescendants();
            var filteredItems = items
                .Where(x => x.ParentID == currentItem.ID)
                .ToList();
            return PartialView(filteredItems);
            //(C) Tristan
        }

        public ActionResult CarouselChampion()
        {
            var currentItem = RenderingContext.Current.Rendering.Item;
            var items = currentItem.Axes.GetDescendants();
            var filteredItems = items
                .Where(x => x.ParentID == currentItem.ID)
                .ToList();
            return PartialView(filteredItems);
            //(C) Tristan
        }
    }
}

