#pragma checksum "C:\Users\korov\source\repos\AllplantsSelector\Views\Dish\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81a63506856ac7bcd100e22090e243f63e2dd0de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dish_Index), @"mvc.1.0.view", @"/Views/Dish/Index.cshtml")]
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
#line 1 "C:\Users\korov\source\repos\AllplantsSelector\Views\_ViewImports.cshtml"
using AllplantsSelector;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\korov\source\repos\AllplantsSelector\Views\_ViewImports.cshtml"
using AllplantsSelector.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81a63506856ac7bcd100e22090e243f63e2dd0de", @"/Views/Dish/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49dce5dd9073bedc1df3d096d63cd20397a1f91d", @"/Views/_ViewImports.cshtml")]
    public class Views_Dish_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AllplantsSelector.Models.Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\korov\source\repos\AllplantsSelector\Views\Dish\Index.cshtml"
      
    ViewData["Title"]= "Dish of the day";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Dishes</h1>\r\n    \r\n");
#nullable restore
#line 8 "C:\Users\korov\source\repos\AllplantsSelector\Views\Dish\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>");
#nullable restore
#line 10 "C:\Users\korov\source\repos\AllplantsSelector\Views\Dish\Index.cshtml"
    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 10 "C:\Users\korov\source\repos\AllplantsSelector\Views\Dish\Index.cshtml"
                Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 10 "C:\Users\korov\source\repos\AllplantsSelector\Views\Dish\Index.cshtml"
                               Write(item.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 11 "C:\Users\korov\source\repos\AllplantsSelector\Views\Dish\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AllplantsSelector.Models.Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
