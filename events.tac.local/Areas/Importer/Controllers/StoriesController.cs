using events.tac.local.Areas.Importer.Models;
using Newtonsoft.Json;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.SecurityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace events.tac.local.Areas.Importer.Controllers
{
    public class StoriesController : Controller
    {
        // GET: Importer/Stories
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file, string parentPath)
        {
            IEnumerable<Story> stories = null;
            string message = null;
            using (var reader = new System.IO.StreamReader(file.InputStream))
            {
                var contents = reader.ReadToEnd();
                try
                {
                    stories = JsonConvert.DeserializeObject<IEnumerable<Story>>(contents);
                }
                catch (Exception ex)
                {

                    // to be added later
                }
            }

            Database database = Sitecore.Configuration.Factory.GetDatabase("master");
            Item parentItem = database.GetItem(parentPath);
            TemplateID templateID = new TemplateID(new ID("{66C2DF65-A818-444E-938F-90F24D790286}"));
            using (new SecurityDisabler())
            {
                foreach(var ev in stories)
                {

                        string name = ItemUtil.ProposeValidItemName(ev.ChampionName);
                        Item item = parentItem.Add(name, templateID);
                        item.Editing.BeginEdit();

                        item["ChampionLore"] = ev.ChampionLore;
                        item["ChampionName"] = ev.ChampionName;
                        item["ChampionRace"] = ev.ChampionRace;
                        item["ChampionRole"] = ev.ChampionRole;
                        item["ContentBody"] = ev.ContentBody;
                        item["ContentHeading"] = ev.ContentHeading;
                        item["ContentIntro"] = ev.ContentIntro;
                        item["StoryInfo"] = ev.StoryInfo;
                        item.Editing.EndEdit();

                }
            }
            return View();
        }
    }
}