#pragma checksum "E:\Projects\PR001 Core\Portal\Views\District\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "801f0759d2396a4d862152d980611588e1f66632"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_District_List), @"mvc.1.0.view", @"/Views/District/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/District/List.cshtml", typeof(AspNetCore.Views_District_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"801f0759d2396a4d862152d980611588e1f66632", @"/Views/District/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea73c18953461b2da0883cbece56eb399a5ce162", @"/Views/_ViewImports.cshtml")]
    public class Views_District_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1917, true);
            WriteLiteral(@"<div class=""content mt-3"">
    <div class=""animated fadeIn"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <div class=""page-title float-left"">
                            <h1>District</h1>
                        </div>
                        <button type=""button"" style=""min-width:100px"" class=""btn btn-primary float-right"" data-toggle=""modal"" data-target=""#mediumModal"" ng-click=""add()"">ADD</button>
                    </div>
                    <div class=""card-body table-scroll"" ng-init=""initialize()"">
                        <table id=""bootstrap-data-table"" class=""table table-striped table-bordered"">
                            <thead>
                                <tr>
                                    <th>District Name</th>
                                    <th>State Name</th>
                                    <th></th>
                                </tr>
 ");
            WriteLiteral(@"                           </thead>
                            <tbody>
                                <tr ng-repeat=""item in data"">
                                    <td>{{item.DistrictName}}</td>
                                    <td>{{item.StateMaster.StateName}}</td>
                                    <td>
                                        <span class=""icon-container pointer"" data-toggle=""modal"" data-target=""#mediumModal"" ng-click=""edit(item.DistrictID)"">
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
