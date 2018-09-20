using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace events.tac.local.References
{
    public class RereferenceClass
    {
        public static TemplateID TemplateID = new TemplateID(new ID(""));
        public struct Fields
        {
            public static ID ContentHeading = new ID("");
            //...
        }


    }
    public struct ChampionDetails
    {
        public static TemplateID TemplateID = new TemplateID(new ID("E35DC7D9-CB17-438E-BB6F-FF9EB06F6700"));
        public struct Fields
        {
            public static readonly ID ContentHeading = new ID("");
        }
    }
}