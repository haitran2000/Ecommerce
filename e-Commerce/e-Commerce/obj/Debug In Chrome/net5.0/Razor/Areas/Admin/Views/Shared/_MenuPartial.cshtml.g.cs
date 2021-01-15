#pragma checksum "C:\Users\H\Desktop\ASP.NET\e-Commerce\e-Commerce\Areas\Admin\Views\Shared\_MenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b8828f7588f21a7f46ca6b6f34ca18aaac54d96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__MenuPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_MenuPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8828f7588f21a7f46ca6b6f34ca18aaac54d96", @"/Areas/Admin/Views/Shared/_MenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68e76bb49b97737e100bde32bcc960c89d4f2c0f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__MenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""vertical-menu"">

    <div data-simplebar="""" class=""h-100"">

        <!--- Sidemenu -->
        <div id=""sidebar-menu"">
            <!-- Left Menu Start -->
            <ul class=""metismenu list-unstyled"" id=""side-menu"">
                <li class=""menu-title"">Menu</li>

                <li>
                    <a href=""javascript: void(0);"" class=""waves-effect"">
                        <i class=""bx bx-home-circle""></i><span class=""badge badge-pill badge-info float-right"">03</span>
                        <span>Bảng Điều Khiển</span>
                    </a>
                </li>
                <li class=""menu-title"">Apps</li>
                <li>
                    <a href=""javascript: void(0);"" class=""has-arrow waves-effect"">
                        <i class=""bx bx-store""></i>
                        <span>Quản Lý</span>
                    </a>
                    <ul class=""sub-menu"" aria-expanded=""false"">
                        <li><a href=""ecommerce-products.html"">Products</a></li>
        ");
            WriteLiteral(@"                <li><a href=""ecommerce-product-detail.html"">Product Detail</a></li>
                        <li><a href=""ecommerce-orders.html"">Orders</a></li>
                        <li><a href=""ecommerce-customers.html"">Customers</a></li>
                        <li><a href=""ecommerce-cart.html"">Cart</a></li>
                        <li><a href=""ecommerce-checkout.html"">Checkout</a></li>
                        <li><a href=""ecommerce-shops.html"">Shops</a></li>
                        <li><a href=""ecommerce-add-product.html"">Add Product</a></li>
                    </ul>
                </li>
                <li>
                    <a href=""javascript: void(0);"" class=""has-arrow waves-effect"">
                        <i class=""bx bxs-user-detail""></i>
                        <span>Liên Hệ</span>
                    </a>
                    <ul class=""sub-menu"" aria-expanded=""false"">
                        <li><a href=""contacts-grid.html"">User Grid</a></li>
                    </ul>
                </li>

");
            WriteLiteral(@"                <li class=""menu-title"">Pages</li>

                <li>
                    <a href=""javascript: void(0);"" class=""has-arrow waves-effect"">
                        <i class=""bx bx-user-circle""></i>
                        <span>Tài Khoản</span>
                    </a>
                    <ul class=""sub-menu"" aria-expanded=""false"">
                        <li><a href=""auth-login.html"">Đăng Nhập</a></li>
                        <li><a href=""auth-register.html"">Đăng Ký</a></li>
                        <li><a href=""auth-recoverpw.html"">Khôi Phục Mật Khẩu</a></li>
                        <li><a href=""auth-lock-screen.html"">Khoá</a></li>
                    </ul>
                </li>
                <li>
                    <a href=""javascript: void(0);"" class=""has-arrow waves-effect"">
                        <i class=""bx bx-list-ul""></i>
                        <span>Bảng</span>
                    </a>
                    <ul class=""sub-menu"" aria-expanded=""false"">
                        <li><a ");
            WriteLiteral(@"href=""tables-basic.html"">Basic Tables</a></li>
                        <li><a href=""tables-datatable.html"">Data Tables</a></li>
                        <li><a href=""tables-responsive.html"">Responsive Table</a></li>
                        <li><a href=""tables-editable.html"">Editable Table</a></li>
                    </ul>
                </li>
            </ul>
        </div>
        <!-- Sidebar -->
    </div>
</div>");
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