#pragma checksum "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ec48642913902870f568c85bb8aefca2162c489"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\_ViewImports.cshtml"
using CiberWeb;

#line default
#line hidden
#line 2 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\_ViewImports.cshtml"
using CiberWeb.Models;

#line default
#line hidden
#line 2 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ec48642913902870f568c85bb8aefca2162c489", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b97dd91164f8f2372590c0429a633e66a32fec36", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CiberWeb.Models.OrderModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OpenModal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-weight: bold; cursor: pointer; color: dodgerblue; float: right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("get"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#modal-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("OpenModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(114, 329, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ec48642913902870f568c85bb8aefca2162c4896767", async() => {
                BeginContext(139, 62, true);
                WriteLiteral("\r\n    <div>\r\n        <p>Enter category to search</p>\r\n        ");
                EndContext();
                BeginContext(201, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ec48642913902870f568c85bb8aefca2162c4897213", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 11 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Product.Category.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(263, 173, true);
                WriteLiteral("\r\n        <button type=\"submit\" class=\"btn btn-primary\" style=\"float:right; margin-top:20px; margin-bottom:20px\"><i class=\"fa fa-floppy-o\"></i> Search</button>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(443, 302, true);
            WriteLiteral(@"
<table class=""table table-striped"">
    <thead>
        <tr>
            <th>TT</th>
            <th>Product Name</th>
            <th>Category Name</th>
            <th>Customer Name</th>
            <th>Order Date</th>
            <th>Amount</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 27 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
          
            int count = 1 + (Model.PageList.PageNumber - 1) * Model.PageList.PageSize;
            if (!Model.PageList.Any())
            {

#line default
#line hidden
            BeginContext(900, 144, true);
            WriteLiteral("                <tr>\r\n                    <td colspan=\"6\" style=\"text-align:center\">Không tìm thấy kết quả phù hợp</td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
            }
            else
            {
                foreach (var item in Model.PageList)
                {

#line default
#line hidden
            BeginContext(1165, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1220, 5, false);
#line 40 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
                       Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1225, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1261, 17, false);
#line 41 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
                       Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1278, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1314, 26, false);
#line 42 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
                       Write(item.Product.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1340, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1376, 18, false);
#line 43 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
                       Write(item.Customer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1394, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1430, 37, false);
#line 44 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
                       Write(item.OrderDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1467, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1503, 11, false);
#line 45 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
                       Write(item.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(1514, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 47 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
                    count++;
                }
            }
        

#line default
#line hidden
            BeginContext(1623, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
#line 53 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
  
    if (Model != null && Model.PageList != null)
    {

#line default
#line hidden
            BeginContext(1708, 83, true);
            WriteLiteral("        <div class=\"col-md-8 col-sm-12\">\r\n            <div>\r\n                Trang ");
            EndContext();
            BeginContext(1793, 84, false);
#line 58 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
                  Write(Model.PageList.PageCount < Model.PageList.PageNumber ? 0 : Model.PageList.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1878, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(1882, 24, false);
#line 58 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
                                                                                                           Write(Model.PageList.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(1906, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1925, 126, false);
#line 59 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
           Write(Html.PagedListPager(Model.PageList, page => Url.Action("Index", new
           {
               page = page,
           })));

#line default
#line hidden
            EndContext();
            BeginContext(2051, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 65 "D:\Project\NoneVNPT\WebCiber\CiberWeb\CiberWeb\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2099, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2101, 240, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ec48642913902870f568c85bb8aefca2162c48916059", async() => {
                BeginContext(2313, 24, true);
                WriteLiteral("\r\n    Create New Order\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2341, 298, true);
            WriteLiteral(@"

<div id=""modal-container"">

</div>

<script>
    function OpenModal() {
        $(""#pAddModal"").modal(""show"");
    }
    function UpdateSuccess() {
        $(""#pAddModal"").modal(""hide"");
    }
    function UpdateFail(xhr) {
        $(""#pAddModal"").modal(""hide"");
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CiberWeb.Models.OrderModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
