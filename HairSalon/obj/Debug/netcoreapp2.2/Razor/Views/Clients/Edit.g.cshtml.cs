#pragma checksum "/Users/teresarosinski/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aee96f31bfeb84ee8bae4c8a92cbe74aed3054ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Edit), @"mvc.1.0.view", @"/Views/Clients/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Edit.cshtml", typeof(AspNetCore.Views_Clients_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aee96f31bfeb84ee8bae4c8a92cbe74aed3054ff", @"/Views/Clients/Edit.cshtml")]
    public class Views_Clients_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/teresarosinski/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 38, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this Client: ");
            EndContext();
            BeginContext(98, 36, false);
#line 9 "/Users/teresarosinski/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
                 Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(134, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/teresarosinski/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(174, 39, false);
#line 13 "/Users/teresarosinski/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.HiddenFor(model => model.ClientId));

#line default
#line hidden
            EndContext();
            BeginContext(220, 34, false);
#line 15 "/Users/teresarosinski/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(260, 35, false);
#line 16 "/Users/teresarosinski/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(302, 42, false);
#line 18 "/Users/teresarosinski/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.LabelFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(350, 43, false);
#line 19 "/Users/teresarosinski/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.EditorFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(400, 41, false);
#line 21 "/Users/teresarosinski/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.LabelFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(447, 42, false);
#line 22 "/Users/teresarosinski/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.EditorFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(496, 37, false);
#line 24 "/Users/teresarosinski/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.LabelFor(model => model.Stylist));

#line default
#line hidden
            EndContext();
            BeginContext(539, 30, false);
#line 25 "/Users/teresarosinski/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.DropDownList("StylistId"));

#line default
#line hidden
            EndContext();
            BeginContext(571, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 28 "/Users/teresarosinski/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(614, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(619, 43, false);
#line 30 "/Users/teresarosinski/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.ActionLink("Back to Clients", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(662, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
