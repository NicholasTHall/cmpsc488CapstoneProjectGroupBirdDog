#pragma checksum "C:\Users\Nicholas\source\repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\IndexAsync.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "293b459a4c2e1a138566d76e98c909dc94f9634d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexAsync), @"mvc.1.0.view", @"/Views/Home/IndexAsync.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/IndexAsync.cshtml", typeof(AspNetCore.Views_Home_IndexAsync))]
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
#line 1 "C:\Users\Nicholas\source\repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\_ViewImports.cshtml"
using WebTest;

#line default
#line hidden
#line 2 "C:\Users\Nicholas\source\repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\_ViewImports.cshtml"
using WebTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"293b459a4c2e1a138566d76e98c909dc94f9634d", @"/Views/Home/IndexAsync.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd0367e1ab19b265a544dc18b55df4c8735f4ed4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexAsync : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebTest.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Nicholas\source\repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\IndexAsync.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
            BeginContext(90, 516, true);
            WriteLiteral(@"
<h2>Products</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Product Id
            </th>
            <th>
                Name
            </th>
            <th>
                Description
            </th>
            <th>
                manufacturer
            </th>
            <th>
                price
            </th>
            <th>
                volume
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 34 "C:\Users\Nicholas\source\repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\IndexAsync.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(638, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(687, 42, false);
#line 37 "C:\Users\Nicholas\source\repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\IndexAsync.cshtml"
           Write(Html.DisplayFor(modelItem => item.prod_id));

#line default
#line hidden
            EndContext();
            BeginContext(729, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(785, 44, false);
#line 40 "C:\Users\Nicholas\source\repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\IndexAsync.cshtml"
           Write(Html.DisplayFor(modelItem => item.prod_name));

#line default
#line hidden
            EndContext();
            BeginContext(829, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(885, 44, false);
#line 43 "C:\Users\Nicholas\source\repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\IndexAsync.cshtml"
           Write(Html.DisplayFor(modelItem => item.prod_desc));

#line default
#line hidden
            EndContext();
            BeginContext(929, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(985, 39, false);
#line 46 "C:\Users\Nicholas\source\repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\IndexAsync.cshtml"
           Write(Html.DisplayFor(modelItem => item.manu));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1080, 40, false);
#line 49 "C:\Users\Nicholas\source\repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\IndexAsync.cshtml"
           Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 67, true);
            WriteLiteral("\r\n            </td>            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1188, 41, false);
#line 52 "C:\Users\Nicholas\source\repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\IndexAsync.cshtml"
           Write(Html.DisplayFor(modelItem => item.volume));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 71, true);
            WriteLiteral("\r\n            </td>\r\n            <td>                \r\n                ");
            EndContext();
            BeginContext(1300, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a3f37d7161d4cc294cf25352558ca7c", async() => {
                BeginContext(1355, 11, true);
                WriteLiteral("Add To Cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\Nicholas\source\repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\IndexAsync.cshtml"
                                            WriteLiteral(item.prod_id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1370, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\Nicholas\source\repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\IndexAsync.cshtml"
}

#line default
#line hidden
            BeginContext(1409, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebTest.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
