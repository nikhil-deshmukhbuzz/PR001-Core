#pragma checksum "E:\Projects\PR001 Core\Portal\Views\Order\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "702cf9ad263ef4723548493127b1e75e11a5e9e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_List), @"mvc.1.0.view", @"/Views/Order/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/List.cshtml", typeof(AspNetCore.Views_Order_List))]
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
#line 1 "E:\Projects\PR001 Core\Portal\Views\_ViewImports.cshtml"
using Portal;

#line default
#line hidden
#line 2 "E:\Projects\PR001 Core\Portal\Views\_ViewImports.cshtml"
using Portal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"702cf9ad263ef4723548493127b1e75e11a5e9e8", @"/Views/Order/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea73c18953461b2da0883cbece56eb399a5ce162", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3720, true);
            WriteLiteral(@"<div class=""content mt-3"">
    <div class=""animated fadeIn"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <div class=""page-title float-left"">
                            <h1>Order</h1>
                        </div>
                        <button type=""button"" style=""min-width:100px"" class=""btn btn-primary float-right"" data-toggle=""modal"" data-target=""#mediumModal"" ng-click=""add()"" ng-show=""isAdmin"">ADD</button>
                    </div>
                    <div class=""card-body table-scroll"" ng-init=""initialize()"">
                        <table id=""bootstrap-data-table"" class=""table table-striped table-bordered"">
                            <thead>
                                <tr>
                                    <th>Order Number</th>
                                    <th>Client Name</th>
                                    <th>Product Name</th>
             ");
            WriteLiteral(@"                       <th>Hardware(Q)</th>
                                    <th>Deadline</th>
                                    <th>Status</th>
                                    <th ng-show=""isAdmin""></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr ng-repeat=""item in data"">
                                    <td>{{item.OrderNumber}}</td>
                                    <td>{{item.ClientMaster.ClientName}}</td>
                                    <td>{{item.ProductMaster.ProductName}}</td>
                                    <td>{{item.HardwareQauntity}}</td>
                                    <td>{{item.DeadlineDate |date:'dd-MM-yyyy'}}</td>
                                    <td data-toggle=""modal"" data-target=""#mediumModalStatus"" class=""pointer"" ng-click=""orderStatus(item.OrderID)"">
                                        <span class=""badge badge-dark"" ng-if=""item.OrderStatus.");
            WriteLiteral(@"Status == 'Pending'""> {{item.OrderStatus.Status}} </span>
                                        <span class=""badge badge-primary"" ng-if=""item.OrderStatus.Status == 'Device Ready'""> {{item.OrderStatus.Status}} </span>
                                        <span class=""badge badge-secondary"" ng-if=""item.OrderStatus.Status == 'Billing'""> {{item.OrderStatus.Status}} </span>
                                        <span class=""badge badge-warning"" ng-if=""item.OrderStatus.Status == 'Delivered'""> {{item.OrderStatus.Status}} </span>
                                        <span class=""badge badge-success"" ng-if=""item.OrderStatus.Status == 'Payment'""> {{item.OrderStatus.Status}} </span>
                                        <span class=""badge badge-danger"" ng-if=""item.OrderStatus.Status == 'Cancel'""> {{item.OrderStatus.Status}} </span>
                                        <span class=""badge badge-dark"" ng-if=""item.OrderStatus.Status == 'OTHER'""> {{item.OrderStatus.Status}} </span>
                     ");
            WriteLiteral(@"               </td>
                                    <td ng-show=""isAdmin"">
                                        <span class=""icon-container pointer"" data-toggle=""modal"" data-target=""#mediumModal"" ng-click=""edit(item.OrderID)"">
                                            <span class=""ti-pencil-alt""></span>
                                        </span>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>

        </div>
    </div><!-- .animated -->
</div>");
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
