#pragma checksum "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25ca485f6a190f5fe857b9e91ecf7b7aab56482a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_dashBoard), @"mvc.1.0.view", @"/Views/Home/dashBoard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/dashBoard.cshtml", typeof(MyApp.Namespace.Home.Views_Home_dashBoard))]
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
#line 3 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\_ViewImports.cshtml"
using newBelt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25ca485f6a190f5fe857b9e91ecf7b7aab56482a", @"/Views/Home/dashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86ace36481bf8a22f07c0c70c390658cad50cc57", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_dashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardWrapper>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deleteActivity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "joinActivity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "leaveActivity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(60, 367, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25ca485f6a190f5fe857b9e91ecf7b7aab56482a5166", async() => {
                BeginContext(66, 354, true);
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
            BeginContext(427, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(429, 3045, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25ca485f6a190f5fe857b9e91ecf7b7aab56482a6714", async() => {
                BeginContext(435, 193, true);
                WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col -sm-8\">\r\n            <h2>Dojo Activity Center</h2>\r\n        </div>\r\n        <div class=\"col-sm-2\">\r\n            <h2>Hi ");
                EndContext();
                BeginContext(629, 26, false);
#line 18 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
              Write(Model.LoggedUser.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(655, 465, true);
                WriteLiteral(@"</h2>
        </div>
        <div class=""col-sm-2"">
            <a href=""/logout"">Logout</a>
        </div>
    </div>
    <div class=""row"">
       <table class=""table table-striped"">
            <tr>
                <th>Activity</th>
                <th>Date and Time</th>
                <th>Duration</th>
                <th>Event Coordinator</th>
                <th>Number of Participants</th>
                <th>Action</th>
            </tr>
");
                EndContext();
#line 34 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
             foreach(var l in @Model.AllActivities)
            {

#line default
#line hidden
                BeginContext(1188, 50, true);
                WriteLiteral("                <tr>    \r\n                    <td>");
                EndContext();
                BeginContext(1239, 7, false);
#line 37 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                   Write(l.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1246, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1278, 32, false);
#line 38 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                   Write(l.ActivityDate.ToString("MM/dd"));

#line default
#line hidden
                EndContext();
                BeginContext(1310, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1312, 2, true);
                WriteLiteral("@ ");
                EndContext();
                BeginContext(1315, 34, false);
#line 38 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                                                        Write(l.TimeOfEvent.ToString("hh:mm tt"));

#line default
#line hidden
                EndContext();
                BeginContext(1349, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1381, 10, false);
#line 39 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                   Write(l.Duration);

#line default
#line hidden
                EndContext();
                BeginContext(1391, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1393, 15, false);
#line 39 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                               Write(l.DurationUnits);

#line default
#line hidden
                EndContext();
                BeginContext(1408, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 40 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                     if(@l.User!=null)
                    {

#line default
#line hidden
                BeginContext(1478, 24, true);
                WriteLiteral("                    <td>");
                EndContext();
                BeginContext(1503, 16, false);
#line 42 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                   Write(l.User.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1519, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 43 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(1598, 28, true);
                WriteLiteral("                        <td>");
                EndContext();
                BeginContext(1627, 8, false);
#line 46 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                       Write(l.UserId);

#line default
#line hidden
                EndContext();
                BeginContext(1635, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 47 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                    }

#line default
#line hidden
                BeginContext(1665, 25, true);
                WriteLiteral("                     <td>");
                EndContext();
                BeginContext(1691, 25, false);
#line 48 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                    Write(l.UsersInActivities.Count);

#line default
#line hidden
                EndContext();
                BeginContext(1716, 8, true);
                WriteLiteral("</td> \r\n");
                EndContext();
#line 51 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                         if(l.UserId == @Model.LoggedUser.UserId)
                        {

#line default
#line hidden
                BeginContext(1898, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1926, 225, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25ca485f6a190f5fe857b9e91ecf7b7aab56482a13599", async() => {
                    BeginContext(2034, 110, true);
                    WriteLiteral("\r\n                                <td><button type=\"submit\">Delete</button></td>\r\n                            ");
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
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ActivityId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 53 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                                                                                               WriteLiteral(l.ActivityId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["ActivityId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ActivityId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["ActivityId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2151, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 56 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"

                        }
                        else {
                        
                            if(l.UsersInActivities.SingleOrDefault(x=>x.UserId == @Model.LoggedUser.UserId)==null)
                            {
                                
                           

#line default
#line hidden
                BeginContext(2450, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(2482, 229, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25ca485f6a190f5fe857b9e91ecf7b7aab56482a17607", async() => {
                    BeginContext(2587, 117, true);
                    WriteLiteral("\r\n                                    <td> <button type=\"submit\">Join</button></td>\r\n                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ActivityId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 64 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                                                                                                WriteLiteral(l.ActivityId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["ActivityId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ActivityId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["ActivityId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2711, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 67 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                            
                                
                            }                        
                            else 
                            {


#line default
#line hidden
                BeginContext(2900, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(2932, 236, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25ca485f6a190f5fe857b9e91ecf7b7aab56482a21513", async() => {
                    BeginContext(3039, 122, true);
                    WriteLiteral("\r\n                                        <td> <button type=\"submit\">Leave</button></td>\r\n                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ActivityId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 73 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                                                                                                  WriteLiteral(l.ActivityId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["ActivityId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ActivityId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["ActivityId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3168, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 76 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
                       

                            }   

                        }

#line default
#line hidden
                BeginContext(3313, 23, true);
                WriteLiteral("                </tr>\r\n");
                EndContext();
#line 86 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\BeltFinal\newBelt\Views\Home\dashBoard.cshtml"
            }

#line default
#line hidden
                BeginContext(3351, 116, true);
                WriteLiteral("    </table>\r\n    <div class=\"row\">\r\n             <a href=\"addNewActivity\">Add Activiity</a>\r\n    </div>\r\n\r\n</div>\r\n");
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
            BeginContext(3474, 9, true);
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
