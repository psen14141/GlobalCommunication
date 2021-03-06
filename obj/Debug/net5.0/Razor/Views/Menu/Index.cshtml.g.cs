#pragma checksum "D:\ProstyleTechnology\Project\GloableCommunication\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e692e914cb5d5f370fd1d114ac8fd1f0e180f04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
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
#line 1 "D:\ProstyleTechnology\Project\GloableCommunication\Views\_ViewImports.cshtml"
using GloableCommunication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ProstyleTechnology\Project\GloableCommunication\Views\_ViewImports.cshtml"
using GloableCommunication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e692e914cb5d5f370fd1d114ac8fd1f0e180f04", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f62707b2b221ab1219262a8c4e2ea9b680bb53", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\ProstyleTechnology\Project\GloableCommunication\Views\Menu\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <li class=""nav-item active"">
        <a href=""/"">
            <i class=""flaticon-home""></i>
            <p>メインメニュー</p>
            <span class=""badge badge-count"">5</span>
        </a>
    </li>
    <li class=""nav-section"">
        <span class=""sidebar-mini-icon"">
            <i class=""la la-ellipsis-h""></i>
        </span>
        <h4 class=""text-section"">Sections</h4>
    </li>
    <li class=""nav-item"">
        <a data-toggle=""collapse"" href=""#base"">
            <i class=""la la-university""></i>
            <p>実習生</p>
            <span class=""caret""></span>
        </a>
        <div class=""collapse"" id=""base"">
            <ul class=""nav nav-collapse"">
                <li>
                    <a href=""/Trainee/TraineeMaster/Index"">
                        <span class=""sub-item""> 実習生 一覧</span>
                    </a>
                </li>
                <li>
                    <a href=""/Trainee/TraineeMaster/AddNewTrinee"">
                        <span class=""sub-item"">実習");
            WriteLiteral(@"生新規登録</span>
                    </a>
                </li>
            </ul>
        </div>
    </li>
    <li class=""nav-item"">
        <a data-toggle=""collapse"" href=""#maps"">
            <i class=""flaticon-agenda-1""></i>
            <p>受入企業</p>
            <span class=""caret""></span>
        </a>
        <div class=""collapse"" id=""maps"">
            <ul class=""nav nav-collapse"">
                <li>
                    <a href=""/AcceptingCompany/AcceptingCompany/Index"">
                        <span class=""sub-item"">受入企業一覧</span>
                    </a>
                </li>
                <li>
                    <a href=""/AcceptingCompany/AcceptingCompany/Add"">
                        <span class=""sub-item"">受入企業新規登録</span>
                    </a>
                </li>
            </ul>
        </div>
    </li>
    <li class=""nav-item"">
        <a data-toggle=""collapse"" href=""#forms"">
            <i class=""la la-mortar-board""></i>
            <p>送出機関</p>
            <span c");
            WriteLiteral(@"lass=""caret""></span>
        </a>
        <div class=""collapse"" id=""forms"">
            <ul class=""nav nav-collapse"">
                <li>
                    <a href=""/SendingCompanies/SendingCompany/Index"">
                        <span class=""sub-item"">送出機関一覧</span>
                    </a>
                </li>
                <li>
                    <a href=""/SendingCompanies/SendingCompany/AddorEditView"">
                        <span class=""sub-item"">送出機関新規登録</span>
                    </a>
                </li>

            </ul>
        </div>
    </li>
    <li class=""nav-item"">
        <a data-toggle=""collapse"" href=""#tasks"">
            <i class=""la la-tasks""></i>
            <p>
                マスタメンテナンス
            </p>
            <span class=""caret""></span>
        </a>
        <div class=""collapse"" id=""tasks"">
            <ul class=""nav nav-collapse"">
                <li>
                    <a href=""/Occupations/Occupation/Index"">
                        <span c");
            WriteLiteral(@"lass=""sub-item"">実習職種一覧</span>
                    </a>
                </li>
                <li>
                    <a href=""/wrks/WorkManage/Index"">
                        <span class=""sub-item"">作業マスタ登録</span>
                    </a>
                </li>
                <li>
                    <a href=""/MasterMaintainance/Country/Index/"">
                        <span class=""sub-item"">国情報登録</span>
                    </a>
                </li>
                <li>
                    <a href=""/MasterMaintainance/Area/Index"">
                        <span class=""sub-item"">地域情報登録</span>
                    </a>
                </li>
                <li>
                    <a href=""/MasterMaintainance/UserId/Index"">
                        <span class=""sub-item"">ユーザーID登録</span>
                    </a>
                </li>
                <li>
                    <a href=""/MasterMaintainance/Prefecture/Index"">
                        <span class=""sub-item"">県一覧</span>
          ");
            WriteLiteral("          </a>\r\n                </li>\r\n\r\n\r\n            </ul>\r\n        </div>\r\n    </li>\r\n    ");
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
