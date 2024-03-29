#pragma checksum "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5a4bb7109600b7eb1691cef2cf5effcf7a116fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Success.cshtml", typeof(AspNetCore.Views_Home_Success))]
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
#line 1 "/Users/atessadailami/Desktop/MovieTime/Views/_ViewImports.cshtml"
using MovieTime;

#line default
#line hidden
#line 2 "/Users/atessadailami/Desktop/MovieTime/Views/_ViewImports.cshtml"
using MovieTime.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5a4bb7109600b7eb1691cef2cf5effcf7a116fa", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57f1eb6f061951957442380262c4dbc42581abef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 377, true);
            WriteLiteral(@"<div class=""jumbotron"">
    <h1>MovieTime</h1>
</div>

<a href=""/logout""><button class=""btn btn-info"">Logout</button></a>

<a href=""/movie/new""><button class=""btn btn-primary"">Add Movie</button></a>

<br><br>

<table class=""table"">
    <tr>
        <th>Title</th>
        <th>Address</th>
        <th>Start Time</th>
        <th>Planenr</th>
        <th>Actions</th>
    </tr>
");
            EndContext();
#line 19 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
     foreach(Movie movie in ViewBag.Movies)
    {

#line default
#line hidden
            BeginContext(427, 48, true);
            WriteLiteral("        <tr>\n            <td>\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 475, "\"", 502, 2);
            WriteAttributeValue("", 482, "/view/", 482, 6, true);
#line 23 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
WriteAttributeValue("", 488, movie.MovieId, 488, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(503, 22, true);
            WriteLiteral(">\n                    ");
            EndContext();
            BeginContext(526, 11, false);
#line 24 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
               Write(movie.Title);

#line default
#line hidden
            EndContext();
            BeginContext(537, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(539, 10, false);
#line 24 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
                            Write(movie.Year);

#line default
#line hidden
            EndContext();
            BeginContext(549, 56, true);
            WriteLiteral("\n                </a>\n            </td>\n            <td>");
            EndContext();
            BeginContext(606, 13, false);
#line 27 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
           Write(movie.Address);

#line default
#line hidden
            EndContext();
            BeginContext(619, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(642, 15, false);
#line 28 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
           Write(movie.StartTime);

#line default
#line hidden
            EndContext();
            BeginContext(657, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(680, 23, false);
#line 29 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
           Write(movie.Planner.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(703, 23, true);
            WriteLiteral("</td>\n            <td>\n");
            EndContext();
#line 31 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
                  
                    if(@ViewBag.UserId == @movie.PlannerId)
                    {

#line default
#line hidden
            BeginContext(827, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 853, "\"", 880, 2);
            WriteAttributeValue("", 860, "/edit/", 860, 6, true);
#line 34 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
WriteAttributeValue("", 866, movie.MovieId, 866, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(881, 36, true);
            WriteLiteral(">Edit</a>\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 917, "\"", 946, 2);
            WriteAttributeValue("", 924, "/delete/", 924, 8, true);
#line 35 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
WriteAttributeValue("", 932, movie.MovieId, 932, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(947, 12, true);
            WriteLiteral(">Delete</a>\n");
            EndContext();
#line 36 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
                    }
                    else
                    {
                        bool joined = false;
                        foreach(Join j in @movie.AttendingUsers)
                        {
                            if(j.UserId == @ViewBag.UserId)
                            {
                                joined = true;
                            }
                        }
                        if(joined)
                        {

#line default
#line hidden
            BeginContext(1418, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1448, "\"", 1476, 2);
            WriteAttributeValue("", 1455, "/leave/", 1455, 7, true);
#line 49 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
WriteAttributeValue("", 1462, movie.MovieId, 1462, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1477, 11, true);
            WriteLiteral(">Leave</a>\n");
            EndContext();
#line 50 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1569, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1599, "\"", 1626, 2);
            WriteAttributeValue("", 1606, "/join/", 1606, 6, true);
#line 53 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
WriteAttributeValue("", 1612, movie.MovieId, 1612, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1627, 10, true);
            WriteLiteral(">Join</a>\n");
            EndContext();
#line 54 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
                        }
                       
                    }
                

#line default
#line hidden
            BeginContext(1727, 32, true);
            WriteLiteral("            </td>\n        </tr>\n");
            EndContext();
#line 60 "/Users/atessadailami/Desktop/MovieTime/Views/Home/Success.cshtml"
    }

#line default
#line hidden
            BeginContext(1765, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
