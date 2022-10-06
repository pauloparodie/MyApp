using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApp.HtmlHelpers
{
    public static class Helpers
    {
        public static MvcHtmlString PhotoNameHelper(this HtmlHelper helper, string photoName)
        {
            if (String.IsNullOrWhiteSpace(photoName))
            {
                return MvcHtmlString.Create("");
            }

            TagBuilder tag = new TagBuilder("span");
            tag.MergeAttribute("class", "w-auto bg-info text-dark rounded m-1");
            tag.SetInnerText(photoName);


            return MvcHtmlString.Create(tag.ToString(TagRenderMode.Normal));
        }
    }
}