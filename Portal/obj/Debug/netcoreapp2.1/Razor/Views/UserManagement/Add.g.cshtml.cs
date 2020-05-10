#pragma checksum "E:\Projects\PR001 Core\Portal\Views\UserManagement\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af277912aabb6e5be90c1dfd961de90a25e0433d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserManagement_Add), @"mvc.1.0.view", @"/Views/UserManagement/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserManagement/Add.cshtml", typeof(AspNetCore.Views_UserManagement_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af277912aabb6e5be90c1dfd961de90a25e0433d", @"/Views/UserManagement/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea73c18953461b2da0883cbece56eb399a5ce162", @"/Views/_ViewImports.cshtml")]
    public class Views_UserManagement_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 574, true);
            WriteLiteral(@"<div class=""modal fade"" id=""mediumModal"" tabindex=""-1"" aria-labelledby=""staticModalLabel"" aria-hidden=""true"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""mediumModalLabel""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"" ng-click=""reset(form)"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            EndContext();
            BeginContext(574, 3895, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ae6c4fe409441c88269183432585881", async() => {
                BeginContext(603, 3859, true);
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div>
                        <div class=""card"">
                            <div class=""card-header""><strong>{{header}}</strong></div>
                            <div class=""card-body card-block"">
                                <div class=""row"">
                                    <div class=""col"">
                                        <div class=""form-group"">
                                            <label class="" form-control-label"">Name</label>
                                            <div class=""input-group"">
                                                <div class=""input-group-addon""><i class=""fa fa-user-circle""></i></div>
                                                <input class=""form-control"" name=""name"" maxlength=""25"" ng-model=""oUser.Name"" ng-class=""{ 'has-error' : form.name.$invalid && !form.name.$pristine }"" required ng-disabled=""true"">
                                            </div>
                      ");
                WriteLiteral(@"                      <small ng-show=""form.name.$invalid && !form.name.$pristine"" class=""error"">Name is required.</small>

                                        </div>
                                    </div>
                                    <div class=""col"">
                                        <div class=""form-group"">
                                            <label class="" form-control-label"">UserName</label>
                                            <div class=""input-group"">
                                                <div class=""input-group-addon""><i class=""fa fa-sign-in""></i></div>
                                                <input class=""form-control"" name=""name"" maxlength=""20"" ng-model=""oUser.UserName"" ng-class=""{ 'has-error' : form.username.$invalid && !form.username.$pristine }"" required ng-disabled=""true"">
                                            </div>
                                            <small ng-show=""form.username.$invalid && !form.username.$pristine""");
                WriteLiteral(@" class=""error"">Username is required.</small>
                                        </div>
                                    </div>
                                </div>

                                <div class=""row"">
                                    <div class=""col col-5"">
                                        <div class=""form-group"">
                                            <label class="" form-control-label"">Password<span class=""error"">*</span></label></label>
                                            <div class=""input-group"">
                                                <div class=""input-group-addon""><i class=""fa fa-lock""></i></div>
                                                <input type=""password"" class=""form-control"" name=""password"" ng-model=""oUser.Password"" maxlength=""15"" ng-class=""{ 'has-error' : form.password.$invalid && !form.password.$pristine }"" minlength=""4"" autocomplete=""off"" required>
                                            </div>
                        ");
                WriteLiteral(@"                    <small ng-show=""form.password.$invalid && !form.password.$pristine"" class=""error"">Minimum 4 length of password.</small>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button id=""close"" type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"" ng-click=""reset(form)"">Cancel</button>
                    <button type=""submit"" ng-click=""submit(form)"" ng-disabled=""form.password.$invalid"" class=""btn btn-primary"" data-dismiss=""modal"">{{submitTxt}}</button>
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
            BeginContext(4469, 38, true);
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
