#pragma checksum "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f8ef6100bfc1d4ece9aa15872ada0528b02086d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\_ViewImports.cshtml"
using e_Commerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\_ViewImports.cshtml"
using e_Commerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f8ef6100bfc1d4ece9aa15872ada0528b02086d", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68e76bb49b97737e100bde32bcc960c89d4f2c0f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<e_Commerce.Models.ProductModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("example"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;width:50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-content"" >

    <div class=""page-content"">
        <div class=""container-fluid"">

            <!-- start page title -->
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""page-title-box d-flex align-items-center justify-content-between"">
                        <h4 class=""mb-0 font-size-18"">Orders</h4>
                        <div class=""page-title-right"">
                            <ol class=""breadcrumb m-0"">
                                <li class=""breadcrumb-item""><a href=""javascript: void(0);"">Ecommerce</a></li>
                                <li class=""breadcrumb-item active"">Orders</li>
                            </ol>
                        </div>

                    </div>
                </div>
            </div>
            <!-- end page title -->

            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
   ");
            WriteLiteral("                         <div class=\"row mb-2\">\r\n                                <div class=\"col-sm-4\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f8ef6100bfc1d4ece9aa15872ada0528b02086d8081", async() => {
                WriteLiteral("\r\n                                        <input type=\"text\" placeholder=\"Nhập Từ Khoá..\" name=\"s_name\">\r\n                                        <button type=\"submit\"><i class=\"fa fa-search\"></i></button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""col-sm-8"">
                                    <div class=""text-sm-right"">
                                        <button type=""button"" class=""btn btn-success btn-rounded waves-effect waves-light mb-2 mr-2""><i class=""mdi mdi-plus mr-1""></i>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f8ef6100bfc1d4ece9aa15872ada0528b02086d10386", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</button>
                                    </div>
                                </div><!-- end col-->
                            </div>
                            <div class=""table-responsive"">
                                
                                    <table class=""table table-centered table-nowrap"">
                                        <thead class=""thead-light"">
                                            <tr>
                                                <th style=""width: 20px;"">
                                                    <div class=""custom-control custom-checkbox"">
                                                        <input type=""checkbox"" class=""custom-control-input"" id=""customCheck1"">
                                                        <label class=""custom-control-label"" for=""customCheck1"">&nbsp;</label>
                                                    </div>
                                                </th>
                                   ");
            WriteLiteral("             <th>\r\n                                                    ");
#nullable restore
#line 58 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 61 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 64 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 67 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 70 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </th>
                                                <th>Xem Sản Phẩm</th>
                                                <th>Sửa</th>
                                                <th>Xoá</th>
                                            </tr>
                                        </thead>
                                        <tbody id=""product_all"">
");
#nullable restore
#line 78 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                             foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <tr>
                                                    <td>
                                                        <div class=""custom-control custom-checkbox"">
                                                            <input type=""checkbox"" class=""custom-control-input"" id=""customCheck2"">
                                                            <label class=""custom-control-label"" for=""customCheck2"">&nbsp;</label>
                                                        </div>
                                                    </td>

                                                    <td>
                                                        ");
#nullable restore
#line 89 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 92 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f8ef6100bfc1d4ece9aa15872ada0528b02086d17306", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5657, "~/image/product/", 5657, 16, true);
#nullable restore
#line 95 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 5673, item.Picture, 5673, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 98 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        <button class=\"btn btn-warning\" name=\"btn_update_stt\" data-id=\"");
#nullable restore
#line 101 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                                                                  Write(item.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                                                data-stt=\"");
#nullable restore
#line 102 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                      Write(item.Status==true?0:1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-name=\"");
#nullable restore
#line 102 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 103 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                              
                                                                if (item.Status == true)
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    ");
            WriteLiteral("Ẩn\r\n");
#nullable restore
#line 107 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                }
                                                                else
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    ");
            WriteLiteral("Hiện\r\n");
#nullable restore
#line 111 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                }
                                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </button>\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f8ef6100bfc1d4ece9aa15872ada0528b02086d22299", async() => {
                WriteLiteral("\r\n                                                            <i class=\"fa fa-eye\" aria-hidden=\"true\"></i>\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                                  WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f8ef6100bfc1d4ece9aa15872ada0528b02086d24934", async() => {
                WriteLiteral("\r\n                                                            <i class=\"fa fa-edit\"></i>\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                               WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        <button  name=\"delete\" class=\"btn btn-danger\" data-id=\"");
#nullable restore
#line 127 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                                                          Write(item.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fa fa-trash\"></i></button>\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 130 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                    </div>
                </div>
            </div>
            <!-- end row -->
        </div> <!-- container-fluid -->
    </div>
    <!-- End Page-content -->
    <!-- Modal -->
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 145 "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Product\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
        $('button[name=btn_update_stt]').click(function () {
            var id = $(this).attr('data-id');
            var stt = ($(this).attr('data-stt') == 0 ? false : true);
            $.ajax({
                method: ""PUT"",
                url: ""../api/Product_API/PutProductModel/"" + id,
                contentType: 'application/json; charset=UTF-8',
                data: JSON.stringify({ ""id"": id, ""status"": stt })
            })
                .done(function (msg) {
                    if (msg == '0') {
                        $.notify(""Warning: Cập Nhật thất bại"", ""warn"");
                    }
                    else {
                        var r = JSON.parse(msg)
                        if (r.stt =='True') {
                            $('button[name=btn_update_stt][data-id=' + r.id + ']').html('Ẩn');

                        }
                        else {
                            $('button[name=btn_update_stt][data-id=' + r.id + ']').html('Hiện');
        ");
                WriteLiteral(@"                }
                        $.notify(""Cập Nhật Trạng Thái Thành Công"", ""success"");
                    }
                });
        })
        $('button[name=delete]').click(function () {
            var id = $(this).attr('data-id');
            $.ajax({
                method: ""DELETE"",
                url: ""../api/Product_API/DeleteProductModel/"" + id,
            })
                .done(function (msg) {
                    $(""#product_all"").load(window.location.href + "" #product_all"");
                    $.notify(""Xoá Sản Phẩm Thành Công"", ""success"");
                });
        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<e_Commerce.Models.ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591