#pragma checksum "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BELT\BeltTake2\Views\Home\DashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc17da5d8b97b41c40654758681f2fe331b31847"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_DashBoard), @"mvc.1.0.view", @"/Views/Home/DashBoard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DashBoard.cshtml", typeof(MyApp.Namespace.Home.Views_Home_DashBoard))]
namespace MyApp.Namespace.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BELT\BeltTake2\Views\_ViewImports.cshtml"
using BeltTake2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc17da5d8b97b41c40654758681f2fe331b31847", @"/Views/Home/DashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"448eac9de4022d1607c2ed9ce36451daca09c8fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardWrapper>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(60, 371, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc17da5d8b97b41c40654758681f2fe331b318474724", async() => {
                BeginContext(66, 358, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
        <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(431, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(433, 1826, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc17da5d8b97b41c40654758681f2fe331b318476276", async() => {
                BeginContext(439, 96, true);
                WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <h2>Hi ");
                EndContext();
                BeginContext(536, 21, false);
#line 15 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BELT\BeltTake2\Views\Home\DashBoard.cshtml"
              Write(Model.LoggedUser.Name);

#line default
#line hidden
                EndContext();
                BeginContext(557, 145, true);
                WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"col\">\r\n            <a href=\"/\">Logout</a>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        ");
                EndContext();
                BeginContext(702, 363, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc17da5d8b97b41c40654758681f2fe331b318477331", async() => {
                    BeginContext(769, 289, true);
                    WriteLiteral(@"
        <div class=""form-group row"">
            <textarea  class =""col-sm-12 form-control h-100"" type=text name=""newIdea.Text"">
            </textarea>
        </div>
        <div class=""form-group row"">
            <input type=""submit"" value=""Add Idea!"">
        </div>
        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1065, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
#line 33 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BELT\BeltTake2\Views\Home\DashBoard.cshtml"
         foreach(Idea nIdea in Model.AllIdeas)
        {

#line default
#line hidden
                BeginContext(1146, 129, true);
                WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-sm-2\">\r\n                <div class=\"form-group row\">\r\n                    ");
                EndContext();
                BeginContext(1275, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc17da5d8b97b41c40654758681f2fe331b3184710167", async() => {
                    BeginContext(1312, 15, false);
#line 38 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BELT\BeltTake2\Views\Home\DashBoard.cshtml"
                                                   Write(nIdea.User.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(1327, 6, true);
                    WriteLiteral(" says:");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 38 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BELT\BeltTake2\Views\Home\DashBoard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.newIdea.User.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1341, 225, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-8\">\r\n                <div class=\"form-group row\">\r\n                    <textarea  class =\"col-sm-12 form-control h-100\" type=text name=\"nIdea.Text\">");
                EndContext();
                BeginContext(1567, 10, false);
#line 43 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BELT\BeltTake2\Views\Home\DashBoard.cshtml"
                                                                                            Write(nIdea.Text);

#line default
#line hidden
                EndContext();
                BeginContext(1577, 175, true);
                WriteLiteral("\r\n                    </textarea>\r\n                </div>\r\n                <div class=\"form-group row\">\r\n                    <div class=\"col-sm-4\">\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1752, "\"", 1780, 2);
                WriteAttributeValue("", 1759, "addLike/", 1759, 8, true);
#line 48 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BELT\BeltTake2\Views\Home\DashBoard.cshtml"
WriteAttributeValue("", 1767, nIdea.IdeaId, 1767, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1781, 122, true);
                WriteLiteral("> Like</a>\r\n                    </div>\r\n                    <div class=\"col-sm-8\">\r\n                        <p><a href=\"\">");
                EndContext();
                BeginContext(1904, 17, false);
#line 51 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BELT\BeltTake2\Views\Home\DashBoard.cshtml"
                                 Write(nIdea.Likes.Count);

#line default
#line hidden
                EndContext();
                BeginContext(1921, 129, true);
                WriteLiteral("</a> Like this!</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-2\">\r\n");
                EndContext();
#line 56 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BELT\BeltTake2\Views\Home\DashBoard.cshtml"
                 if(@nIdea.User.Name == @Model.LoggedUser.Name )
                {

#line default
#line hidden
                BeginContext(2135, 36, true);
                WriteLiteral("                    <a>Delete!</a>\r\n");
                EndContext();
#line 59 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BELT\BeltTake2\Views\Home\DashBoard.cshtml"
                }

#line default
#line hidden
                BeginContext(2190, 36, true);
                WriteLiteral("            </div>\r\n        </div>\r\n");
                EndContext();
#line 62 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BELT\BeltTake2\Views\Home\DashBoard.cshtml"
        }

#line default
#line hidden
                BeginContext(2244, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2259, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardWrapper> Html { get; private set; }
    }
}
#pragma warning restore 1591
