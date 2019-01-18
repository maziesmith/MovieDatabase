#pragma checksum "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ee20630ca4e824fe0ace09bfdefcbb60710f758"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Index.cshtml", typeof(AspNetCore.Views_Movie_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\_ViewImports.cshtml"
using MovieDatabase.UI;

#line default
#line hidden
#line 2 "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\_ViewImports.cshtml"
using MovieDatabase.UI.Models;

#line default
#line hidden
#line 1 "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\Movie\Index.cshtml"
using MovieDatabase.BL.Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee20630ca4e824fe0ace09bfdefcbb60710f758", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7353434f3879dfeabdadc1f02e2f26442d04d64a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieDatabase.BL.Domain.Media>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\Movie\Index.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(147, 28, true);
            WriteLiteral("\r\n<h2>Bekeken films</h2>\r\n\r\n");
            EndContext();
            BeginContext(175, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6b6e698618b48f383bdd0d3ca485806", async() => {
                BeginContext(223, 124, true);
                WriteLiteral("\r\n    <p>\r\n        Title: <input type=\"text\" name=\"SearchString\">\r\n        <input type=\"submit\" value=\"Filter\"/>\r\n    </p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(354, 248, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>Nr</td>\r\n        <td>Titel</td>\r\n        <td>Type</td>\r\n        <td>Datum bekeken</td>\r\n        <td>Acteur 1</td>\r\n        <td>Acteur 2</td>\r\n        <td>Acteur 3</td>\r\n        <td></td>\r\n    </tr>\r\n");
            EndContext();
#line 29 "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\Movie\Index.cshtml"
     foreach (var item in Model)
    {
        string name1 = "";
        string name2 = "";
        string name3 = "";
        string shortDate = "";
        if (item.WatchDate != null)
        {
            shortDate = item.WatchDate.Value.ToShortDateString();
        }
        try
        {
            List<ActorAct> actorActs = item.ActorActs.ToList();
            name1 = actorActs.ElementAt(0).Actor.Name;
            name2 = actorActs.ElementAt(1).Actor.Name;
            name3 = actorActs.ElementAt(2).Actor.Name;
        }
        catch (ArgumentOutOfRangeException e)
        {
            // do nothing
        }
        catch (ArgumentNullException e2)
        {
            // do nothing
        }
        var detailMethod = item.MediaType == MediaType.Movie ? "DetailMovie" : "DetailSeries";
        var editMethod = item.MediaType == MediaType.Movie ? "EditMovie" : "EditSeries";

#line default
#line hidden
            BeginContext(1526, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1557, 33, false);
#line 57 "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(media => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1614, 70, false);
#line 58 "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\Movie\Index.cshtml"
           Write(Html.ActionLink(item.Title, detailMethod, "Movie", new {id = item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1684, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1708, 34, false);
#line 59 "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\Movie\Index.cshtml"
           Write(item.MediaType.MediaTypeToString());

#line default
#line hidden
            EndContext();
            BeginContext(1742, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1766, 9, false);
#line 60 "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\Movie\Index.cshtml"
           Write(shortDate);

#line default
#line hidden
            EndContext();
            BeginContext(1775, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1799, 5, false);
#line 61 "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\Movie\Index.cshtml"
           Write(name1);

#line default
#line hidden
            EndContext();
            BeginContext(1804, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1828, 5, false);
#line 62 "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\Movie\Index.cshtml"
           Write(name2);

#line default
#line hidden
            EndContext();
            BeginContext(1833, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1857, 5, false);
#line 63 "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\Movie\Index.cshtml"
           Write(name3);

#line default
#line hidden
            EndContext();
            BeginContext(1862, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1904, 68, false);
#line 65 "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\Movie\Index.cshtml"
           Write(Html.ActionLink("Bewerken", editMethod, "Movie", new {id = item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1972, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1993, 69, false);
#line 66 "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\Movie\Index.cshtml"
           Write(Html.ActionLink("Delete", "DeleteMedia", "Movie", new {id = item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(2062, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 69 "D:\_MovieDatabase\moviedatabase\MovieDatabase.UI\Views\Movie\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2105, 8, true);
            WriteLiteral("</table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieDatabase.BL.Domain.Media>> Html { get; private set; }
    }
}
#pragma warning restore 1591
