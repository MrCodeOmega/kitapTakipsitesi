#pragma checksum "C:\Users\90545\source\repos\KitapiniOylaWeb\MVCWebUI\Views\Kitap\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f490b81f851ab9ad09424c0c1e432ecfc87625a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kitap_Index2), @"mvc.1.0.view", @"/Views/Kitap/Index2.cshtml")]
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
#line 1 "C:\Users\90545\source\repos\KitapiniOylaWeb\MVCWebUI\Views\_ViewImports.cshtml"
using MVCWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90545\source\repos\KitapiniOylaWeb\MVCWebUI\Views\_ViewImports.cshtml"
using MVCWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f490b81f851ab9ad09424c0c1e432ecfc87625a0", @"/Views/Kitap/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67de4b42a0c4efbf7b5dd9d40b254dff7d8feec3", @"/Views/_ViewImports.cshtml")]
    public class Views_Kitap_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KitapListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\90545\source\repos\KitapiniOylaWeb\MVCWebUI\Views\Kitap\Index2.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h4 style=\"color:darkgoldenrod\">Puan Sıralaması</h4>\r\n<table class=\"table table\">\r\n    <tr>\r\n        <th>Kitap Adı</th>\r\n        <th>Kitap Puanı</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\90545\source\repos\KitapiniOylaWeb\MVCWebUI\Views\Kitap\Index2.cshtml"
     foreach (var kitap in Model.Kitap)
    {
        if (kitap.Puan > 10)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 394, "\"", 412, 1);
#nullable restore
#line 22 "C:\Users\90545\source\repos\KitapiniOylaWeb\MVCWebUI\Views\Kitap\Index2.cshtml"
WriteAttributeValue("", 400, kitap.Resim, 400, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"40\" height=\"40\" />  ");
#nullable restore
#line 22 "C:\Users\90545\source\repos\KitapiniOylaWeb\MVCWebUI\Views\Kitap\Index2.cshtml"
                                                                  Write(kitap.KitapAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td><button class=\"btn btn-success\" style=\"border-radius:20\" disabled>");
#nullable restore
#line 24 "C:\Users\90545\source\repos\KitapiniOylaWeb\MVCWebUI\Views\Kitap\Index2.cshtml"
                                                                                 Write(kitap.Puan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button> </td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "C:\Users\90545\source\repos\KitapiniOylaWeb\MVCWebUI\Views\Kitap\Index2.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 678, "\"", 696, 1);
#nullable restore
#line 31 "C:\Users\90545\source\repos\KitapiniOylaWeb\MVCWebUI\Views\Kitap\Index2.cshtml"
WriteAttributeValue("", 684, kitap.Resim, 684, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"40\" height=\"40\" />  ");
#nullable restore
#line 31 "C:\Users\90545\source\repos\KitapiniOylaWeb\MVCWebUI\Views\Kitap\Index2.cshtml"
                                                                  Write(kitap.KitapAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td><button class=\"btn btn-warning\" style=\"border-radius:20\" disabled>");
#nullable restore
#line 33 "C:\Users\90545\source\repos\KitapiniOylaWeb\MVCWebUI\Views\Kitap\Index2.cshtml"
                                                                                 Write(kitap.Puan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button> </td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\90545\source\repos\KitapiniOylaWeb\MVCWebUI\Views\Kitap\Index2.cshtml"
        }




    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KitapListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
