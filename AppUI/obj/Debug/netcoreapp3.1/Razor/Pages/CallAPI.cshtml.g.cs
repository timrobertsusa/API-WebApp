#pragma checksum "C:\Users\jamesvac\OneDrive\SW-Projects\Fun with Tim\Multi-001\AppUI\Pages\CallAPI.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "035808e2a67c68768fe45be5ddacf0473d6a64da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AppUI.Pages.Pages_CallAPI), @"mvc.1.0.razor-page", @"/Pages/CallAPI.cshtml")]
namespace AppUI.Pages
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
#line 1 "C:\Users\jamesvac\OneDrive\SW-Projects\Fun with Tim\Multi-001\AppUI\Pages\_ViewImports.cshtml"
using AppUI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"035808e2a67c68768fe45be5ddacf0473d6a64da", @"/Pages/CallAPI.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0081842acef573a3f1c5a7041e55a8fe360f4744", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CallAPI : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\jamesvac\OneDrive\SW-Projects\Fun with Tim\Multi-001\AppUI\Pages\CallAPI.cshtml"
  
    ViewData["Title"] = "Call API?";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\jamesvac\OneDrive\SW-Projects\Fun with Tim\Multi-001\AppUI\Pages\CallAPI.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<p>This page will call an API and display the data returned.</p>

<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core""> calling API's .NET Core</a>.</p>
    <p> Line 1 </p>

</div>
    
<table>
    <tbody> 
");
#nullable restore
#line 20 "C:\Users\jamesvac\OneDrive\SW-Projects\Fun with Tim\Multi-001\AppUI\Pages\CallAPI.cshtml"
             foreach (var record in @Model.WFRList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        Date: ");
#nullable restore
#line 24 "C:\Users\jamesvac\OneDrive\SW-Projects\Fun with Tim\Multi-001\AppUI\Pages\CallAPI.cshtml"
                         Write(Html.DisplayFor(modelItem => record.date));

#line default
#line hidden
#nullable disable
            WriteLiteral(", \r\n                    </td>\r\n                    <td>\r\n                        TempC: ");
#nullable restore
#line 27 "C:\Users\jamesvac\OneDrive\SW-Projects\Fun with Tim\Multi-001\AppUI\Pages\CallAPI.cshtml"
                          Write(Html.DisplayFor(modelItem => record.temperatureC));

#line default
#line hidden
#nullable disable
            WriteLiteral(", \r\n                    </td>\r\n                    <td>\r\n                        TempF: ");
#nullable restore
#line 30 "C:\Users\jamesvac\OneDrive\SW-Projects\Fun with Tim\Multi-001\AppUI\Pages\CallAPI.cshtml"
                          Write(Html.DisplayFor(modelItem => record.temperatureF));

#line default
#line hidden
#nullable disable
            WriteLiteral(", \r\n                    </td>\r\n                    <td>\r\n                        Summary: ");
#nullable restore
#line 33 "C:\Users\jamesvac\OneDrive\SW-Projects\Fun with Tim\Multi-001\AppUI\Pages\CallAPI.cshtml"
                            Write(Html.DisplayFor(modelItem => record.summary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\jamesvac\OneDrive\SW-Projects\Fun with Tim\Multi-001\AppUI\Pages\CallAPI.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CallAPIModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CallAPIModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CallAPIModel>)PageContext?.ViewData;
        public CallAPIModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591