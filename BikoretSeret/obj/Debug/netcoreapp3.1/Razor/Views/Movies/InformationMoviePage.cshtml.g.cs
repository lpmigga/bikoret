#pragma checksum "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbd7cf2c111983e536f98f39896026443cd5ff5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_InformationMoviePage), @"mvc.1.0.view", @"/Views/Movies/InformationMoviePage.cshtml")]
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
#nullable restore
#line 1 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\_ViewImports.cshtml"
using BikoretSeret;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\_ViewImports.cshtml"
using BikoretSeret.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbd7cf2c111983e536f98f39896026443cd5ff5f", @"/Views/Movies/InformationMoviePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6af10b92cab8901dffffff534b99f473d06ce008", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_InformationMoviePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert-info border-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("commentButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "commentButton", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
 if (ViewBag.movie != null)
{
    if (TempData.ContainsKey("name"))
    {
        string userName = TempData["name"].ToString();
        TempData["name"] = userName;
        if (userName.Equals("manager") || ViewBag.found == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbd7cf2c111983e536f98f39896026443cd5ff5f5847", async() => {
                WriteLiteral("delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
                                                               WriteLiteral(ViewBag.movie.name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
        }
    }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
                

    string imageBase64Data = Convert.ToBase64String(ViewBag.movie.ImageData);
    string imageDataUrl = string.Format("data:image/jpg;base64,{0}", imageBase64Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
            WriteLiteral("    <div>\r\n        <h1 id=\"mTitle\" class=\"bigTitle\"><strong>");
#nullable restore
#line 33 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
                                            Write(ViewBag.movie.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h1>\r\n        <br />\r\n        <br />\r\n        <p>\r\n            <img style=\"width:300px; float:right; margin-left:15px;\"");
            BeginWriteAttribute("src", " src=\"", 1604, "\"", 1623, 1);
#nullable restore
#line 37 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
WriteAttributeValue("", 1610, imageDataUrl, 1610, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </p>\r\n        <h3 id=\"mTitle\" class=\"subT\"> Category : <strong>");
#nullable restore
#line 39 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
                                                    Write(ViewBag.movie.category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3>\r\n        <br />\r\n        <h5 dir=\"auto\" id=\"mTitle\" class=\"subT\"><strong>");
#nullable restore
#line 41 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
                                                   Write(ViewBag.movie.summery);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h5>\r\n");
#nullable restore
#line 42 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
         if (TempData.ContainsKey("name"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbd7cf2c111983e536f98f39896026443cd5ff5f10859", async() => {
                WriteLiteral("you want to add comment ? press here");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
                                                                                                                                WriteLiteral(ViewBag.movie.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>all the comments about this movie down here</h2>\r\n    </div>\r\n");
#nullable restore
#line 48 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
    for (int i = 0; i < ViewBag.comments.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>");
#nullable restore
#line 50 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
       Write(ViewBag.comments[i].userName);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 50 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
                                     Write(ViewBag.comments[i].comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 51 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
         if (TempData.ContainsKey("name"))
        {
            string userName = TempData["name"].ToString();
            TempData["name"] = userName;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
             if (ViewBag.comments[i].userName.Equals(userName) || userName.Equals("manager"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbd7cf2c111983e536f98f39896026443cd5ff5f15351", async() => {
                WriteLiteral("you want to add comment ? press here");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
                                                                                                            WriteLiteral(ViewBag.comments[i].id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\bt-user\Documents\656645898\bikoret\BikoretSeret\Views\Movies\InformationMoviePage.cshtml"
         
    }

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
