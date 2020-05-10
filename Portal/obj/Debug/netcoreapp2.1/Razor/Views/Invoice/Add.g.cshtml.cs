#pragma checksum "E:\Projects\PR001 Core\Portal\Views\Invoice\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe967ba59b3251a61eb80927d223f321e323a281"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Add), @"mvc.1.0.view", @"/Views/Invoice/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/Add.cshtml", typeof(AspNetCore.Views_Invoice_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe967ba59b3251a61eb80927d223f321e323a281", @"/Views/Invoice/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea73c18953461b2da0883cbece56eb399a5ce162", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 581, true);
            WriteLiteral(@"<div class=""modal fade"" id=""mediumModal"" tabindex=""-1"" aria-labelledby=""staticModalLabel"" aria-hidden=""true"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""mediumModalLabel"">Invoice</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"" ng-click=""reset(form)"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            EndContext();
            BeginContext(581, 9127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05268890f49a41679a0039f32852cf6d", async() => {
                BeginContext(610, 9091, true);
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div>
                        <div class=""card"">
                            <div class=""card-header""><strong>{{header}}</strong></div>
                            <div class=""card-body card-block"">
                                <div class=""row"">
                                    <div class=""col"">
                                        <div class=""form-group"">
                                            <label for=""client"" class="" form-control-label"">Client<span class=""error"">*</span></label>

                                            <select id=""client"" name=""client"" data-placeholder=""Choose a Client..."" class=""standardSelect form-control"" tabindex=""1"" ng-class=""{'has-error': form.client.$error.required}"" ng-model=""ddl.selectedClient"" ng-required=""true"" ng-disabled=""isEditable""></select>
                                        </div>
                                    </div>
                                    <div class=""col");
                WriteLiteral(@""">
                                        <div class=""form-group"">
                                            <label for=""product"" class="" form-control-label"">Product<span class=""error"">*</span></label>
                                            <select id=""product"" name=""product"" data-placeholder=""Choose a Product..."" class=""standardSelect form-control"" tabindex=""1"" ng-class=""{'has-error': form.product.$error.required}"" ng-model=""ddl.selectedProduct"" ng-required=""true"" ng-disabled=""isEditable""></select>
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col"">
                                        <div class=""form-group"">
                                            <label for=""order"" class="" form-control-label"">Order<span class=""error"">*</span></label>

                                            <select id=""order"" name");
                WriteLiteral(@"=""order"" data-placeholder=""Choose a Order..."" class=""standardSelect form-control"" tabindex=""1"" ng-class=""{'has-error': form.order.$error.required}"" ng-model=""ddl.selectedOrder"" ng-required=""true"" ng-disabled=""isEditable""></select>
                                        </div>
                                    </div>
                                    <div class=""col"">
                                        <div class=""form-group"">
                                            <label for=""paymentStatus"" class="" form-control-label"">Payment Status<span class=""error"">*</span></label>

                                            <select id=""paymentStatus"" name=""paymentStatus"" data-placeholder=""Choose a Payment Status..."" class=""standardSelect form-control"" tabindex=""1"" ng-class=""{'has-error': form.paymentStatus.$error.required}"" ng-model=""ddl.selectedPaymentStatus"" ng-required=""true"" ng-disabled=""isEditable && IsPaid""></select>
                                        </div>
                            ");
                WriteLiteral(@"        </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col"">
                                        <div class=""form-group"">
                                            <label for=""paymentMode"" class="" form-control-label"">Payment Mode</label>

                                            <select id=""paymentMode"" name=""paymentMode"" data-placeholder=""Choose a Payment Mode..."" class=""standardSelect form-control"" tabindex=""1"" ng-class=""{'has-error': form.paymentMode.$error.required}"" ng-model=""ddl.selectedPaymentMode"" ng-required=""true""></select>
                                        </div>
                                    </div>
                                    <div class=""col"">
                                        <div class=""form-group"">
                                            <label class="" form-control-label"">Payment Date</label>
                                            <div class=""");
                WriteLiteral(@"input-group"">
                                                <div class=""input-group-addon""><i class=""fa fa-calendar""></i></div>
                                                <input type=""date"" class=""form-control"" name=""date"" tabindex=""7"" ng-model=""PaymentDate"" ng-disabled=""true"">

                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class=""card"" ng-show=""dispatchDetails.length > 0 || billingDetails.length > 0"">
                            <div class=""card-header""><strong class=""float-right"">Invoice Details</strong></div>
                            <div class=""card-body card-block"">
                                <div class=""row"" ng-repeat=""data in dispatchDetails"">
                                    <div class=""col col-7"">
                                        <div");
                WriteLiteral(@" class=""form-group"" align=""right"">
                                            <label for=""client"" style=""padding-left:50px"" class="" form-control-label""><b>{{data.InventoryName}} :</b></label>
                                        </div>
                                    </div>
                                    <div class=""col col-4"">
                                        <div class=""form-group"">
                                            <input class=""form-control"" style=""text-align:right"" ng-model=""data.Amount"" ng-change=""total()"" readonly>
                                        </div>
                                    </div>
                                    <div class=""col col-1"">

                                    </div>
                                </div>

                                <div class=""row"" ng-repeat=""data in billingDetails"">
                                    <div class=""col col-7"">
                                        <div class=""form-group"" align=""");
                WriteLiteral(@"right"">
                                            <label for=""client"" style=""padding-left:50px"" class="" form-control-label""><i><small>{{data.Header}} :</small></i></label>
                                        </div>
                                    </div>
                                    <div class=""col col-4"">
                                        <div class=""form-group"">
                                            <input class=""form-control"" style=""text-align:right"" ng-model=""data.Amount"" ng-change=""total()"" ng-disabled=""!IsDraft || data.IsSoftware"" autocomplete=""off"">
                                        </div>
                                    </div>
                                    <div class=""col col-1"">
                                        <span style=""padding-left:10px;padding-top:5px;"" ng-hide=""!IsDraft || data.IsSoftware""><i class=""fa fa-trash-o pointer"" data-toggle=""tooltip"" data-placement=""top"" title=""Remove"" ng-click=""removeHeader($index)""></i></span>
          ");
                WriteLiteral(@"                          </div>
                                </div>
                            </div>
                        </div>
                        <div class=""card"" ng-show=""dispatchDetails.length > 0 || billingDetails.length > 0"">
                            <div class=""card-body card-block"">
                                <div class=""row"">
                                    <div class=""col col-7"">
                                        <div class=""form-group"" align=""right"">
                                            <label for=""total"" style=""padding-left: 100px;"" class="" form-control-label""><b>Total Amount</b></label>
                                        </div>
                                    </div>
                                    <div class=""col col-4"">
                                        <div class=""form-group"">
                                            <input class=""form-control"" style=""text-align:right"" ng-model=""TotalAmount"" readonly>
                 ");
                WriteLiteral(@"                       </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button id=""close"" type=""button"" class=""btn btn-secondary float-left"" data-dismiss=""modal"" ng-click=""reset(form)"">Cancel</button>
                        <button id=""draft"" type=""submit"" class=""btn btn-primary"" data-dismiss=""modal"" ng-click=""submit(true)"" ng-disabled=""form.client.$pristine || form.product.$pristine || form.order.$pristine || form.paymentStatus.$pristine"" ng-show=""!isEditable"">Draft</button>
                        <button type=""submit"" ng-click=""submit(false)""  class=""btn btn-success"" data-dismiss=""modal"" ng-show=""isEditable"">Make Invoice</button>
                    </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9708, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
