#pragma checksum "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\Sports_ORM\Views\Home\Level3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8504d31bc882cd333ebedcc2e77547e339ca696"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_Level3), @"mvc.1.0.view", @"/Views/Home/Level3.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Level3.cshtml", typeof(MyApp.Namespace.Home.Views_Home_Level3))]
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
#line 3 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\Sports_ORM\Views\_ViewImports.cshtml"
using Sports_ORM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8504d31bc882cd333ebedcc2e77547e339ca696", @"/Views/Home/Level3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ef1e671b6e8335d6a74079d4642b274a5e166e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Level3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\jancy\Desktop\Coding_Dojo\CSharp\ASpDotnetWebApplications\assignments\Sports_ORM\Views\Home\Level3.cshtml"
  
    ViewData["Title"] = "Level 3";

#line default
#line hidden
            BeginContext(43, 728, true);
            WriteLiteral(@"
<div class=""well"">
    <p>Using the SportsORM, complete all the following queries and show their results on Level3.cshtml.</p>
    <ol>
        <li>...all teams, past and present, that Alexander Bailey has played with</li>
        <li>...all players, past and present, with the Manitoba Tiger-Cats</li>
        <li>...all players who were formerly (but aren't currently) with the Wichita Vikings</li>
        <li>...every team that Emily Sanchez played for before she joined the Indiana Royals</li>
        <li>...everyone named ""Levi"" who has ever played in the Atlantic Federation of Amateur Baseball Players</li>
        <li>...all players, sorted by the number of teams they've played for</li>
    </ol>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
