#pragma checksum "E:\Projects\PR001 Core\Portal\Views\Home\Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da8cd9f721f928658d42ecf1d72d9f0730c5777e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Header), @"mvc.1.0.view", @"/Views/Home/Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Header.cshtml", typeof(AspNetCore.Views_Home_Header))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da8cd9f721f928658d42ecf1d72d9f0730c5777e", @"/Views/Home/Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea73c18953461b2da0883cbece56eb399a5ce162", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user-avatar rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sufee/images/admin.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 513, true);
            WriteLiteral(@"<!-- Header-->
<header id=""header"" class=""header"" style=""visibility:hidden"" ng-controller=""headerCTRL"">
    <div class=""header-menu"">
        <div class=""col-sm-7"">
            <a id=""menuToggle"" class=""menutoggle pull-left""><i class=""fa fa fa-tasks""></i></a>

        </div>
        <div class=""col-sm-5"">
            <div class=""user-area dropdown float-right"">
                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    ");
            EndContext();
            BeginContext(513, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d7ce04fd3af54f84b642bae96517c457", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(602, 2002, true);
            WriteLiteral(@"
                </a>
                <div class=""user-menu dropdown-menu"">
                    <a class=""nav-link"" href=""#"">My Profile</a>
                    <a class=""nav-link"" href=""#"" data-toggle=""modal"" data-target=""#passwordModal"" ng-click=""changePassword()"">Change Password</a>
                    <a class=""nav-link"" href=""/Account/SignOff""><i class=""fa fa-power-off""></i>&nbsp;&nbsp; Logout</a>
                </div>
            </div>
            <div id=""language-select"" align=""left"" style=""min-width:200px"">
                <div style=""font-size:12px; color:black;"" align=""right"">
                    {{username}}
                </div>
                <div class=""dropdown-menu"" aria-labelledby=""language"">
                    <div class=""dropdown-item"">
                        <span class=""flag-icon flag-icon-fr""></span>
                    </div>
                    <div class=""dropdown-item"">
                        <i class=""flag-icon flag-icon-es""></i>
                    </div>
");
            WriteLiteral(@"                    <div class=""dropdown-item"">
                        <i class=""flag-icon flag-icon-us""></i>
                    </div>
                    <div class=""dropdown-item"">
                        <i class=""flag-icon flag-icon-it""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""passwordModal"" tabindex=""-1"" aria-labelledby=""staticModalLabel"" aria-hidden=""true"" data-backdrop=""static"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""passwordModalLabel"">User</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"" ng-click=""reset(form)"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                ");
            EndContext();
            BeginContext(2604, 3203, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dcadf30f77e44cc8dabeb9942010b3f", async() => {
                BeginContext(2633, 3167, true);
                WriteLiteral(@"
                    <div class=""modal-body"">
                        <div>
                            <div class=""card"">
                                <div class=""card-header""><strong>Change Password</strong></div>
                                <div class=""card-body card-block"">
                                    <div class=""row"">
                                        <div class=""col col-5"">
                                            <div class=""form-group"">
                                                <label class="" form-control-label"">Old Password<span class=""error"">*</span></label>
                                                <div class=""input-group"">
                                                    <div class=""input-group-addon""><i class=""fa fa-user-circle""></i></div>
                                                    <input type=""password"" class=""form-control"" name=""oldpassword"" maxlength=""25"" ng-model=""oUser.OldPassword"" ng-class=""{ 'has-error' : form.oldpassword.$invalid");
                WriteLiteral(@" && !form.oldpassword.$pristine }"" required>
                                                </div>
                                                <small ng-show=""form.oldpassword.$invalid && !form.oldpassword.$pristine"" class=""error"">Old password is required.</small>

                                            </div>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col col-5"">
                                            <div class=""form-group"">
                                                <label class="" form-control-label"">New Password<span class=""error"">*</span></label>
                                                <div class=""input-group"">
                                                    <div class=""input-group-addon""><i class=""fa fa-lock""></i></div>
                                                    <input type=""password"" class=""form-c");
                WriteLiteral(@"ontrol"" name=""newpassword"" ng-model=""oUser.NewPassword"" minlength=""4"" maxlength=""15"" ng-class=""{ 'has-error' : form.newpassword.$invalid && !form.newpassword.$pristine }"" required>
                                                </div>
                                                <small ng-show=""form.newpassword.$invalid && !form.newpassword.$pristine"" class=""error"">Minimum 4 length of password.</small>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button id=""passwordclose"" type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                        <button type=""submit"" ng-click=""updatePassword()"" ng-disabled=""form.oldpassword.$invalid || form.newpassword.$invalid"" class=""btn ");
                WriteLiteral("btn-primary\" data-dismiss=\"modal\">Update</button>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
            BeginContext(5807, 81, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</header>\r\n<!-- Header-->\r\n\r\n\r\n");
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
