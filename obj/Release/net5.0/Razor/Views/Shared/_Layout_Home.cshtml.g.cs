#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\Shared\_Layout_Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b4dfb0d1044374f3f89c4d870382281971c7ff5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout_Home), @"mvc.1.0.view", @"/Views/Shared/_Layout_Home.cshtml")]
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
#line 1 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\_ViewImports.cshtml"
using GloableCommunication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\_ViewImports.cshtml"
using GloableCommunication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b4dfb0d1044374f3f89c4d870382281971c7ff5", @"/Views/Shared/_Layout_Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f62707b2b221ab1219262a8c4e2ea9b680bb53", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("vertical-layout vertical-menu-modern  navbar-floating footer-static  "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-open", new global::Microsoft.AspNetCore.Html.HtmlString("click"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-menu", new global::Microsoft.AspNetCore.Html.HtmlString("vertical-menu-modern"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-col", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html class=\"loading\" lang=\"en\" data-textdirection=\"ltr\">\n<!-- BEGIN: Head-->\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b4dfb0d1044374f3f89c4d870382281971c7ff54957", async() => {
                WriteLiteral(@"
    <!-- CSS Files -->
    <link rel=""stylesheet"" href=""/assets/css/bootstrap.min.css"">

    <!--   Core JS Files   -->
    <script src=""/assets/js/core/jquery.3.2.1.min.js""></script>
    <script src=""/assets/js/core/popper.min.js""></script>
    <script src=""/assets/js/core/bootstrap.min.js""></script>

    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui"">
    <meta name=""description"" content=""Vuexy admin is super flexible, powerful, clean &amp; modern responsive bootstrap 4 admin template with unlimited possibilities."">
    <meta name=""keywords"" content=""admin template, Vuexy admin template, dashboard template, flat admin template, responsive admin template, web app"">
    <meta name=""author"" content=""PIXINVENT"">
    <title>");
#nullable restore
#line 20 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\Shared\_Layout_Home.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - GloableCommunication</title>
    <link rel=""apple-touch-icon"" href=""/main-tmpl/app-assets/images/ico/apple-icon-120.png"">
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""/main-tmpl/app-assets/images/ico/favicon.ico"">
    <link href=""https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,300;0,400;0,500;0,600;1,400;1,500;1,600"" rel=""stylesheet"">

    <!-- BEGIN: Vendor CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/app-assets/vendors/css/vendors.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/app-assets/vendors/css/charts/apexcharts.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/app-assets/vendors/css/extensions/toastr.min.css"">

    <!-- BEGIN: Vendor CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/app-assets/vendors/css/forms/wizard/bs-stepper.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/app-assets/vendors/css/forms/select/select2.min.css"">
    <!-- END: Vendor CSS-->
    <!-- END: Ven");
                WriteLiteral(@"dor CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/app-assets/css/plugins/forms/form-wizard.css"">
    <!-- BEGIN: Theme CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/app-assets/css/bootstrap.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/app-assets/css/bootstrap-extended.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/app-assets/css/colors.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/app-assets/css/components.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/app-assets/css/themes/dark-layout.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/app-assets/css/themes/bordered-layout.css"">

    <!-- BEGIN: Page CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/app-assets/css/core/menu/menu-types/vertical-menu.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/app-assets/css/pages/dashboard-ecommerce.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/");
                WriteLiteral(@"main-tmpl/app-assets/css/plugins/charts/chart-apex.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/app-assets/css/plugins/extensions/ext-component-toastr.css"">
    <!-- END: Page CSS-->
    <!-- BEGIN: Custom CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""/main-tmpl/assets/css/style.css"">
    <!-- END: Custom CSS-->
    <link href=""/main-tmpl/assets/fonts/flaticon/flaticon.css"" rel=""stylesheet"" />
");
                WriteLiteral(@"
    <script src=""/jquery/DataTables/datatables.js""></script>
    <link href=""/jquery/DataTables/datatables.css"" rel=""stylesheet"" />
    <script src=""/jquery/datetime/js/bootstrap-datetimepicker.min.js""></script>
    <link href=""/jquery/datetime/css/bootstrap-datetimepicker.css"" rel=""stylesheet"" />
    <script src=""/sweetalert/sweetalert2.all.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<!-- END: Head-->\n<!-- BEGIN: Body-->\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b4dfb0d1044374f3f89c4d870382281971c7ff510265", async() => {
                WriteLiteral(@"

    <!-- BEGIN: Header-->
    <nav class=""header-navbar navbar navbar-expand-lg align-items-center floating-nav navbar-light navbar-shadow"" style=""background-color: #28c76f;"">
        <div class=""navbar-container d-flex content"">

            <ul class=""nav navbar-nav align-items-center ml-auto"">
                <li class=""nav-item nav-search"">
                    <a class=""nav-link nav-link-search""><i class=""ficon"" data-feather=""search""></i></a>
                    <div class=""search-input"">
                        <div class=""search-input-icon""><i data-feather=""search""></i></div>
                        <input class=""form-control input"" type=""text"" placeholder=""Explore Vuexy..."" tabindex=""-1"" data-search=""search"">
                        <div class=""search-input-close""><i data-feather=""x""></i></div>
                        <ul class=""search-list search-list-main""></ul>
                    </div>
                </li>
                <li class=""nav-item dropdown dropdown-notification mr-25"">
              ");
                WriteLiteral(@"      <a class=""nav-link"" href=""javascript:void(0);"" data-toggle=""dropdown""><i class=""ficon"" data-feather=""bell""></i><span class=""badge badge-pill badge-danger badge-up"">5</span></a>
                    <ul class=""dropdown-menu dropdown-menu-media dropdown-menu-right"">
                        <li class=""dropdown-menu-header"">
                            <div class=""dropdown-header d-flex"">
                                <h4 class=""notification-title mb-0 mr-auto"">Notifications</h4>
                                <div class=""badge badge-pill badge-light-primary"">6 New</div>
                            </div>
                        </li>
                        <li class=""scrollable-container media-list"">
                            <a class=""d-flex"" href=""javascript:void(0)"">
                                <div class=""media d-flex align-items-start"">
                                    <div class=""media-left"">
                                        <div class=""avatar""><img src=""/main-tmpl/app-assets/image");
                WriteLiteral(@"s/portrait/small/avatar-s-15.jpg"" alt=""avatar"" width=""32"" height=""32""></div>
                                    </div>
                                    <div class=""media-body"">
                                        <p class=""media-heading""><span class=""font-weight-bolder"">Congratulation Sam ????</span>winner!</p><small class=""notification-text""> Won the monthly best seller badge.</small>
                                    </div>
                                </div>
                            </a><a class=""d-flex"" href=""javascript:void(0)"">
                                <div class=""media d-flex align-items-start"">
                                    <div class=""media-left"">
                                        <div class=""avatar""><img src=""/main-tmpl/app-assets/images/portrait/small/avatar-s-3.jpg"" alt=""avatar"" width=""32"" height=""32""></div>
                                    </div>
                                    <div class=""media-body"">
                                        <p class=""media");
                WriteLiteral(@"-heading""><span class=""font-weight-bolder"">New message</span>&nbsp;received</p><small class=""notification-text""> You have 10 unread messages</small>
                                    </div>
                                </div>
                            </a><a class=""d-flex"" href=""javascript:void(0)"">
                                <div class=""media d-flex align-items-start"">
                                    <div class=""media-left"">
                                        <div class=""avatar bg-light-danger"">
                                            <div class=""avatar-content"">MD</div>
                                        </div>
                                    </div>
                                    <div class=""media-body"">
                                        <p class=""media-heading""><span class=""font-weight-bolder"">Revised Order ????</span>&nbsp;checkout</p><small class=""notification-text""> MD Inc. order updated</small>
                                    </div>
                       ");
                WriteLiteral(@"         </div>
                            </a>
                            <div class=""media d-flex align-items-center"">
                                <h6 class=""font-weight-bolder mr-auto mb-0"">System Notifications</h6>
                                <div class=""custom-control custom-control-primary custom-switch"">
                                    <input class=""custom-control-input"" id=""systemNotification"" type=""checkbox""");
                BeginWriteAttribute("checked", " checked=\"", 8785, "\"", 8795, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <label class=""custom-control-label"" for=""systemNotification""></label>
                                </div>
                            </div><a class=""d-flex"" href=""javascript:void(0)"">
                                <div class=""media d-flex align-items-start"">
                                    <div class=""media-left"">
                                        <div class=""avatar bg-light-danger"">
                                            <div class=""avatar-content""><i class=""avatar-icon"" data-feather=""x""></i></div>
                                        </div>
                                    </div>
                                    <div class=""media-body"">
                                        <p class=""media-heading""><span class=""font-weight-bolder"">Server down</span>&nbsp;registered</p><small class=""notification-text""> USA Server is down due to hight CPU usage</small>
                                    </div>
                                </div>
       ");
                WriteLiteral(@"                     </a><a class=""d-flex"" href=""javascript:void(0)"">
                                <div class=""media d-flex align-items-start"">
                                    <div class=""media-left"">
                                        <div class=""avatar bg-light-success"">
                                            <div class=""avatar-content""><i class=""avatar-icon"" data-feather=""check""></i></div>
                                        </div>
                                    </div>
                                    <div class=""media-body"">
                                        <p class=""media-heading""><span class=""font-weight-bolder"">Sales report</span>&nbsp;generated</p><small class=""notification-text""> Last month sales report generated</small>
                                    </div>
                                </div>
                            </a><a class=""d-flex"" href=""javascript:void(0)"">
                                <div class=""media d-flex align-items-start"">
            ");
                WriteLiteral(@"                        <div class=""media-left"">
                                        <div class=""avatar bg-light-warning"">
                                            <div class=""avatar-content""><i class=""avatar-icon"" data-feather=""alert-triangle""></i></div>
                                        </div>
                                    </div>
                                    <div class=""media-body"">
                                        <p class=""media-heading""><span class=""font-weight-bolder"">High memory</span>&nbsp;usage</p><small class=""notification-text""> BLR Server using high memory</small>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""dropdown-menu-footer""><a class=""btn btn-primary btn-block"" href=""javascript:void(0)"">Read all notifications</a></li>
                    </ul>
                </li>
                <li class=""nav-item dropdown dropdown-user"">
  ");
                WriteLiteral(@"                  <a class=""nav-link dropdown-toggle dropdown-user-link"" id=""dropdown-user"" href=""javascript:void(0);"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <div class=""user-nav d-sm-flex d-none""><span class=""user-name font-weight-bolder"">Jhon</span><span class=""user-status"">Admin</span></div><span class=""avatar""><img class=""round"" src=""/main-tmpl/app-assets/images/portrait/small/avatar-s-11.jpg"" alt=""avatar"" height=""40"" width=""40""><span class=""avatar-status-online""></span></span>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdown-user"">
                        <a class=""dropdown-item"" href=""page-profile.html""><i class=""mr-50"" data-feather=""user""></i> Profile</a>
                        <div class=""dropdown-divider""></div><a class=""dropdown-item"" href=""page-account-settings.html""><i class=""mr-50"" data-feather=""settings""></i> Settings</a><a class=""dropdown-item"" href=""page-auth-login-v2.html""");
                WriteLiteral(@"><i class=""mr-50"" data-feather=""power""></i> Logout</a>
                    </div>
                </li>
            </ul>
        </div>
    </nav>
    <ul class=""main-search-list-defaultlist d-none"">
        <li class=""d-flex align-items-center"">
            <a href=""javascript:void(0);"">
                <h6 class=""section-label mt-75 mb-0"">Files</h6>
            </a>
        </li>
        <li class=""auto-suggestion"">
            <a class=""d-flex align-items-center justify-content-between w-100"" href=""app-file-manager.html"">
                <div class=""d-flex"">
                    <div class=""mr-75""><img src=""/main-tmpl/app-assets/images/icons/xls.png"" alt=""png"" height=""32""></div>
                    <div class=""search-data"">
                        <p class=""search-data-title mb-0"">Two new item submitted</p><small class=""text-muted"">Marketing Manager</small>
                    </div>
                </div><small class=""search-data-size mr-50 text-muted"">&apos;17kb</small>
            </a>
        </li>
   ");
                WriteLiteral(@"     <li class=""auto-suggestion"">
            <a class=""d-flex align-items-center justify-content-between w-100"" href=""app-file-manager.html"">
                <div class=""d-flex"">
                    <div class=""mr-75""><img src=""/main-tmpl/app-assets/images/icons/jpg.png"" alt=""png"" height=""32""></div>
                    <div class=""search-data"">
                        <p class=""search-data-title mb-0"">52 JPG file Generated</p><small class=""text-muted"">FontEnd Developer</small>
                    </div>
                </div><small class=""search-data-size mr-50 text-muted"">&apos;11kb</small>
            </a>
        </li>
        <li class=""auto-suggestion"">
            <a class=""d-flex align-items-center justify-content-between w-100"" href=""app-file-manager.html"">
                <div class=""d-flex"">
                    <div class=""mr-75""><img src=""/main-tmpl/app-assets/images/icons/pdf.png"" alt=""png"" height=""32""></div>
                    <div class=""search-data"">
                        <p class=""search-d");
                WriteLiteral(@"ata-title mb-0"">25 PDF File Uploaded</p><small class=""text-muted"">Digital Marketing Manager</small>
                    </div>
                </div><small class=""search-data-size mr-50 text-muted"">&apos;150kb</small>
            </a>
        </li>
        <li class=""auto-suggestion"">
            <a class=""d-flex align-items-center justify-content-between w-100"" href=""app-file-manager.html"">
                <div class=""d-flex"">
                    <div class=""mr-75""><img src=""/main-tmpl/app-assets/images/icons/doc.png"" alt=""png"" height=""32""></div>
                    <div class=""search-data"">
                        <p class=""search-data-title mb-0"">Anna_Strong.doc</p><small class=""text-muted"">Web Designer</small>
                    </div>
                </div><small class=""search-data-size mr-50 text-muted"">&apos;256kb</small>
            </a>
        </li>
        <li class=""d-flex align-items-center"">
            <a href=""javascript:void(0);"">
                <h6 class=""section-label mt-75 mb-0"">Members<");
                WriteLiteral(@"/h6>
            </a>
        </li>
        <li class=""auto-suggestion"">
            <a class=""d-flex align-items-center justify-content-between py-50 w-100"" href=""app-user-view.html"">
                <div class=""d-flex align-items-center"">
                    <div class=""avatar mr-75""><img src=""/main-tmpl/app-assets/images/portrait/small/avatar-s-8.jpg"" alt=""png"" height=""32""></div>
                    <div class=""search-data"">
                        <p class=""search-data-title mb-0"">John Doe</p><small class=""text-muted"">UI designer</small>
                    </div>
                </div>
            </a>
        </li>
        <li class=""auto-suggestion"">
            <a class=""d-flex align-items-center justify-content-between py-50 w-100"" href=""app-user-view.html"">
                <div class=""d-flex align-items-center"">
                    <div class=""avatar mr-75""><img src=""/main-tmpl/app-assets/images/portrait/small/avatar-s-1.jpg"" alt=""png"" height=""32""></div>
                    <div class=""search-data"">");
                WriteLiteral(@"
                        <p class=""search-data-title mb-0"">Michal Clark</p><small class=""text-muted"">FontEnd Developer</small>
                    </div>
                </div>
            </a>
        </li>
        <li class=""auto-suggestion"">
            <a class=""d-flex align-items-center justify-content-between py-50 w-100"" href=""app-user-view.html"">
                <div class=""d-flex align-items-center"">
                    <div class=""avatar mr-75""><img src=""/main-tmpl/app-assets/images/portrait/small/avatar-s-14.jpg"" alt=""png"" height=""32""></div>
                    <div class=""search-data"">
                        <p class=""search-data-title mb-0"">Milena Gibson</p><small class=""text-muted"">Digital Marketing Manager</small>
                    </div>
                </div>
            </a>
        </li>
        <li class=""auto-suggestion"">
            <a class=""d-flex align-items-center justify-content-between py-50 w-100"" href=""app-user-view.html"">
                <div class=""d-flex align-items-center""");
                WriteLiteral(@">
                    <div class=""avatar mr-75""><img src=""/main-tmpl/app-assets/images/portrait/small/avatar-s-6.jpg"" alt=""png"" height=""32""></div>
                    <div class=""search-data"">
                        <p class=""search-data-title mb-0"">Anna Strong</p><small class=""text-muted"">Web Designer</small>
                    </div>
                </div>
            </a>
        </li>
    </ul>
    <ul class=""main-search-list-defaultlist-other-list d-none"">
        <li class=""auto-suggestion justify-content-between"">
            <a class=""d-flex align-items-center justify-content-between w-100 py-50"">
                <div class=""d-flex justify-content-start""><span class=""mr-75"" data-feather=""alert-circle""></span><span>No results found.</span></div>
            </a>
        </li>
    </ul>
    <!-- END: Header-->
    <!-- BEGIN: Main Menu-->
    <div class=""main-menu menu-fixed menu-light menu-accordion menu-shadow"" data-scroll-to-active=""true"">
        <div class=""navbar-header"">
            <ul class=""");
                WriteLiteral(@"nav navbar-nav flex-row"">
                <li class=""nav-item mr-auto"">
                    <a class=""navbar-brand"" href=""#"">
                        <img src=""/main-tmpl/app-assets/images/logo/logo.png"" style=""width: 105px;"">
                    </a>
                </li>
                <li class=""nav-item nav-toggle""><a class=""nav-link modern-nav-toggle pr-0"" data-toggle=""collapse""><i class=""d-block d-xl-none text-primary toggle-icon font-medium-4"" data-feather=""x""></i><i class=""d-none d-xl-block collapse-toggle-icon font-medium-4  text-primary"" data-feather=""disc"" data-ticon=""disc""></i></a></li>
            </ul>
        </div>
        <div class=""shadow-bottom""></div>
        <div class=""main-menu-content"">
            <ul class=""navigation navigation-main"" id=""main-menu-navigation"" data-menu=""menu-navigation"">
                <li class="" nav-item"">
                    <a class=""d-flex align-items-center"" href=""index.html""><i data-feather=""home""></i><span class=""menu-title text-truncate"" data-i18n=""Dashb");
                WriteLiteral(@"oards"">?????????</span><span class=""badge badge-light-warning badge-pill ml-auto mr-1"">2</span></a>

                </li>
                <li class="" navigation-header"">
                    <span data-i18n=""Apps &amp; Pages"">????????????</span><i data-feather=""more-horizontal""></i>
                </li>
                <li class="" nav-item"">
                    <a class=""d-flex align-items-center"" href=""#.html""><i ></i><span class=""menu-title text-truncate flaticon-user-5"" style="" margin-left: -56px;"">&nbsp;&nbsp;???????????????????????????</span></a>
                </li>
                <li class="" nav-item"">
                    <a class=""d-flex align-items-center "" href=""#.html""><i");
                BeginWriteAttribute("class", " class=\"", 20722, "\"", 20730, 0);
                EndWriteAttribute();
                WriteLiteral(@"></i><span class=""menu-title text-truncate  flaticon-add-user "" style="" margin-left: -56px;"">&nbsp;&nbsp;?????????????????????</span></a>
                </li>
                <li class="" nav-item"">
                    <a class=""d-flex align-items-center"" href=""#.html""><i ></i><span class=""menu-title text-truncate flaticon-shopping-bag"" style="" margin-left: -56px;"">&nbsp;&nbsp;??????????????????</span></a>
                </li>
                <li class="" nav-item"">
                    <a class=""d-flex align-items-center"" href=""#.html""><i></i><span class=""menu-title text-truncate flaticon-shopping-bag"" style="" margin-left: -56px;"">&nbsp;&nbsp;????????????????????????</span></a>
                </li>
                <li class="" nav-item"">
                    <a class=""d-flex align-items-center"" href=""#.html""><i ></i><span class=""menu-title text-truncate flaticon-desk"" style="" margin-left: -56px;"">&nbsp;&nbsp;??????????????????</span></a>
                </li>
                <li class="" nav-item"">
                    <a class=""d-flex align-items-center"" href=""#.h");
                WriteLiteral(@"tml""><i ></i><span class=""menu-title text-truncate flaticon-desk"" style="" margin-left: -56px;"">&nbsp;&nbsp;????????????????????????</span></a>
                </li>
                <li class="" nav-item"">
                    <a class=""d-flex align-items-center"" href=""#.html""><i ></i><span class=""menu-title text-truncate flaticon-database"" style="" margin-left: -56px;"">&nbsp;&nbsp;???????????????????????????</span></a>
                </li>
                <li class="" nav-item"">
                    <a class=""d-flex align-items-center"" href=""#.html""><i></i><span class=""menu-title text-truncate flaticon-power"" style="" margin-left: -56px;"">&nbsp;&nbsp;???????????????</span></a>
                </li>

            </ul>
        </div>
    </div>
    <!-- END: Main Menu-->
    <!-- BEGIN: Content-->
    <div class=""app-content content "">
        <div class=""content-overlay""></div>
        <div class=""header-navbar-shadow""></div>
        <div class=""content-wrapper"">
            ");
#nullable restore
#line 335 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\Shared\_Layout_Home.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
        <!-- END: Content-->

        <div class=""sidenav-overlay""></div>
        <div class=""drag-target""></div>

        <!-- BEGIN: Footer-->
        <footer class=""footer footer-static footer-light"">
            <p class=""clearfix mb-0""><span class=""float-md-left d-block d-md-inline-block mt-25"">Design & Developed &copy; , 2021<a class=""ml-25"" href=""https://prostyle.technology"" target=""_blank"">Prostyle Technology</a><span class=""d-none d-sm-inline-block"">, All rights Reserved</span></span></p>
        </footer>
        <button class=""btn btn-primary btn-icon scroll-top"" type=""button""><i data-feather=""arrow-up""></i></button>
        <!-- END: Footer-->
        <!-- BEGIN: Vendor JS-->
        <script src=""/main-tmpl/app-assets/vendors/js/vendors.min.js""></script>
        <!-- BEGIN Vendor JS-->
        <!-- BEGIN: Page Vendor JS-->
        <script src=""/main-tmpl/app-assets/vendors/js/charts/apexcharts.min.js""></script>
        <script src=""/main-tmpl/app-assets/vendors/js/extensions/toastr");
                WriteLiteral(@".min.js""></script>
        <!-- END: Page Vendor JS-->
        <!-- BEGIN: Theme JS-->
        <script src=""/main-tmpl/app-assets/js/core/app-menu.js""></script>
        <script src=""/main-tmpl/app-assets/js/core/app.js""></script>
        <!-- END: Theme JS-->
        <script src=""/main-tmpl/app-assets/js/scripts/forms/form-wizard.js""></script>
        <!-- BEGIN: Page JS-->
        <script src=""/main-tmpl/app-assets/js/scripts/pages/dashboard-ecommerce.js""></script>
        <!-- END: Page JS-->
        <!-- BEGIN: Page Vendor JS-->
        <script src=""/main-tmpl/app-assets/vendors/js/forms/wizard/bs-stepper.min.js""></script>
        <script src=""/main-tmpl/app-assets/vendors/js/forms/select/select2.full.min.js""></script>
        <script src=""/main-tmpl/app-assets/vendors/js/forms/validation/jquery.validate.min.js""></script>
        <!-- END: Page Vendor JS-->
        <!-- BEGIN: Theme JS-->
        <script src=""/main-tmpl/app-assets/js/core/app-menu.js""></script>
        <script src=""/main-tmpl/app-assets/js");
                WriteLiteral("/core/app.js\"></script>\n        <!-- END: Theme JS-->\n        <!-- BEGIN: Page JS-->\n        <script src=\"/main-tmpl/app-assets/js/scripts/forms/form-wizard.js\"></script>\n        <!-- END: Page JS-->\n        ");
#nullable restore
#line 375 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\Shared\_Layout_Home.cshtml"
   Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <script>$(window).on(\'load\', function() {\n          if (feather) {\n              feather.replace({\n                  width: 14,\n                  height: 14\n              });\n          }\n      })</script>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<!-- END: Body-->\n\n</html>");
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
