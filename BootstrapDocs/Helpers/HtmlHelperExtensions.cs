using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using System.Web.Routing;

namespace System.Web.Mvc.Html
{
    public static class HtmlHelperExtensions
    {
        /// <summary>
        /// 輸出 LazyLoadImg 標籤。
        /// </summary>
        /// <param name="helper">擴充型別</param>
        /// <param name="path">圖片路徑</param>
        /// <param name="alternateText">alt 文字</param>
        /// <param name="width">寬度</param>
        /// <param name="height">高度</param>
        /// <param name="htmlAttributes">其他HTML屬性</param>
        /// <returns>含 data-original 屬性的 img 標籤。</returns>
        public static MvcHtmlString LazyLoadImg(this HtmlHelper helper,
            string path,
            string alternateText,
            string width,
            string height,
            object htmlAttributes = null)
        {
            var tag = new TagBuilder("img");
            tag.Attributes.Add("data-original", path);
            tag.Attributes.Add("width", width);
            tag.Attributes.Add("height", height);
            tag.Attributes.Add("alt", alternateText);

            if (htmlAttributes != null)
            {
                var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
                tag.MergeAttributes(attributes);
            }

            return new MvcHtmlString(tag.ToString(TagRenderMode.SelfClosing));
        }

        public static MvcHtmlString Image(this HtmlHelper helper, 
            string id, 
            string url,
            string alternateText)
        {
            return Image(helper, id, url, alternateText, null);
        }

        /// <summary>
        /// 輸出 HTML img 標籤。
        /// </summary>
        /// <param name="helper">擴充型別</param>
        /// <param name="id">id</param>
        /// <param name="url">URL</param>
        /// <param name="alternateText">alt 文字</param>
        /// <param name="htmlAttributes">其他HTML屬性</param>
        /// <returns>回傳 img 標籤。</returns>
        public static MvcHtmlString Image(this HtmlHelper helper, 
            string id, string url, string alternateText, object htmlAttributes)
        {
            // 建立一個 tag builder
            var builder = new TagBuilder("img");

            // 賦予它 id
            builder.GenerateId(id);

            // 增加屬性
            builder.MergeAttribute("src", url);
            builder.MergeAttribute("alt", alternateText);
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            // 產生
            return new MvcHtmlString(builder.ToString(TagRenderMode.SelfClosing));
        }

        /// <summary>
        /// 回傳目前所在的 Controller 與 Action 名稱。
        /// </summary>
        /// <param name="helper">擴充型別</param>
        /// <returns></returns>
        public static string ShowControllerAndActionName(this HtmlHelper helper)
        {
            var currentControllerName =
                (string)helper.ViewContext.RouteData.Values["controller"];

            var currentActionName =
                (string)helper.ViewContext.RouteData.Values["action"];

            return string.Format(
                "<h3>您現在的Controller為【{0}】Action為【{1}】</h3>",
                currentControllerName,
                currentActionName);
        }

        public static bool IsCurrentController(this HtmlHelper helper,
            string controllerName)
        {
            var currentControllerName =
                (string)helper.ViewContext.RouteData.Values["controller"];

            if (currentControllerName.Equals(controllerName, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }

        public static bool IsCurrentAction(this HtmlHelper helper,
            string actionName,
            string controllerName)
        {
            var currentControllerName =
                (string)helper.ViewContext.RouteData.Values["controller"];

            var currentActionName =
                (string)helper.ViewContext.RouteData.Values["action"];

            if (currentControllerName.Equals(controllerName, StringComparison.CurrentCultureIgnoreCase)
                &&
                currentActionName.Equals(actionName, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }

        public static bool IsCurrentPage(this HtmlHelper helper,
            string actionName,
            string controllerName,
            string IdName)
        {
            var currentControllerName =
                (string)helper.ViewContext.RouteData.Values["controller"];

            var currentActionName =
                (string)helper.ViewContext.RouteData.Values["action"];

            var currentIdName =
                (string)helper.ViewContext.RouteData.Values["id"];

            if (currentControllerName.Equals(controllerName, StringComparison.CurrentCultureIgnoreCase)
                &&
                currentActionName.Equals(actionName, StringComparison.CurrentCultureIgnoreCase)
                &&
                currentIdName.Equals(IdName, StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }
            return true;
        }




    }
}