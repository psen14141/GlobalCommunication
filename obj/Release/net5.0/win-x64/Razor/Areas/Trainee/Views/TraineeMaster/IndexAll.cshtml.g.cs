#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\IndexAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0bb7c3f1c4bc29bcad77f3ca1a7977470fc201d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Trainee_Views_TraineeMaster_IndexAll), @"mvc.1.0.view", @"/Areas/Trainee/Views/TraineeMaster/IndexAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0bb7c3f1c4bc29bcad77f3ca1a7977470fc201d", @"/Areas/Trainee/Views/TraineeMaster/IndexAll.cshtml")]
    public class Areas_Trainee_Views_TraineeMaster_IndexAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GloableCommunication.Areas.Trainee.Models.ViewModel.TraineeMasterViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\IndexAll.cshtml"
  
    ViewData["Title"] = "IndexAll";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
");
            WriteLiteral("\r\n\r\n\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'#dtDesign\').DataTable();\r\n        $(\'.dataTables_length\').addClass(\'bs-select\');\r\n    });\r\n\r\n</script>\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 711, "\"", 719, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <div>
        <button class=""w3-button w3-green""><i class=""fa fa-arrow-left""></i></button>
        <button class=""w3-button w3-blue""><i class=""fa fa-check-circle""></i></button>
        <button class=""w3-button w3-light-green""><i class=""fa fa-refresh""></i></button>
        <button class=""w3-button w3-blue""><i class=""fa fa-window-close""></i></button>
        <button class=""w3-button w3-light-green""><i class=""fa fa-print""></i></button>
        <button class=""w3-button w3-gray""><i class=""fa fa-file""></i></button>
    </div>
    <div>
        <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">戻る</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">登録</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">クリア</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">前除</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">印刷</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-left");
            WriteLiteral(@":10px"">エクセル出力</a>

    </div>
</div>
<br />
<br />
<table id=""dtDesign"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
    <thead>
        <tr>
            <th>
                実習生
            </th>
            <th>
                期生
            </th>
            <th>
                氏名（英）
            </th>
            <th>
                氏名(カナ)
            </th>
            <th>
                性別
            </th>
            <th>
                入国日
            </th>
            <th>
                入国状況
            </th>
            <th>
                在留資格
            </th>
            <th>
                受入企業


            </th>
            <th>
                職種

            </th>
            <th>
                作業

            </th>
            <th>
                送出機関

            </th>
            <th>

            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 96 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\IndexAll.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\IndexAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.TraineeNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\IndexAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.EntranceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\IndexAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.TraineeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\IndexAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.KatakanaName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\IndexAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.SexFlag));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 115 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\IndexAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.EntryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                Acceptable\r\n            </td>\r\n            <td>\r\n                Sri Lanka\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\IndexAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.AcceptiingCompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\IndexAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.OccupationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 130 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\IndexAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.OccupationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ダイキランカ\r\n            </td>\r\n            <td>\r\n                <a class=\"btn btn-primary\" ");
            WriteLiteral(">編集</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 4057, "\"", 4124, 2);
            WriteAttributeValue("", 4064, "/Trainee/TraineeMaster/DetailViewTrainee/?Id=", 4064, 45, true);
#nullable restore
#line 137 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\IndexAll.cshtml"
WriteAttributeValue("", 4109, item.TraineeId, 4109, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" target=\"_blank\">詳細</a>\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 143 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\IndexAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GloableCommunication.Areas.Trainee.Models.ViewModel.TraineeMasterViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
