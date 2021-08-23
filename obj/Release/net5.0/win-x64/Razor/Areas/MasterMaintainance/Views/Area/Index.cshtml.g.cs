#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc3223d2dd2c46ecdac5c45600dd65c367aeb0a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_MasterMaintainance_Views_Area_Index), @"mvc.1.0.view", @"/Areas/MasterMaintainance/Views/Area/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc3223d2dd2c46ecdac5c45600dd65c367aeb0a3", @"/Areas/MasterMaintainance/Views/Area/Index.cshtml")]
    public class Areas_MasterMaintainance_Views_Area_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GloableCommunication.Areas.MasterMaintainance.Models.ViewModels.AreaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $('#dtDesign').DataTable();
        $('.dataTables_length').addClass('bs-select');
    });
</script>

<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">

<p>
    <button class=""w3-button w3-green"" onclick=""goBack()""><i class=""fa fa-arrow-left""></i></button>
    <button class=""w3-button"" style=""background-color: #e7e7e7; color:blue;"" onclick=""ClearData()""><i class=""fa fa-undo""></i></button>
    <button class=""w3-button"" style=""background-color: #e7e7e7;"" onclick=""Accepting.Print()""><i class=""fa fa-print""></i></button>
    <button class=""w3-button"" style=""background-color: #e7e7e7;"" onclick=""exportData()"" id=""ExcelBtn"">
        <i class=""fa fa-file-excel-o""></i>
      ");
            WriteLiteral(@"  <span class=""glyphicon glyphicon-download""></span>
    </button>
<p>
    <a asp-action=""Create"" style=""font-size:14px; padding-right:10px"">戻 る</a>
    <a asp-action=""Create"" style=""font-size:14px; padding-right:10px"">ク リ ア</a>
    <a asp-action=""Create"" style=""font-size:14px; padding-right:10px"">印 刷</a>
    <a style=""font-size:10px;"">エクセル</a><a asp-action=""Create"" style=""font-size:14px; padding-right:10px"">出力</a>
</p>

<div class=""w3-container w3-margin-top"">
    <h5 style=""text-align:center""><b><u>地 域 一 覧</u></b></h5>
</div>

<p>
    <a class=""btn btn-primary"" href=""#"" onclick=""AreaInformation(0)"">追加</a>
</p>

<form method=""post"" id=""SearchForm"">
    <table id=""dtDesign"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
        <thead>
            <tr>
");
            WriteLiteral("                <th>\r\n                    地域 CD\r\n                </th>\r\n                <th>\r\n                    地域 名\r\n                </th>\r\n");
            WriteLiteral("                <th>\r\n                    国 名\r\n                </th>\r\n");
            WriteLiteral("                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 72 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 79 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AreaCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AreaName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 85 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CountryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a href=\"#\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3463, "\"", 3502, 3);
            WriteAttributeValue("", 3473, "AreaInformation(", 3473, 16, true);
#nullable restore
#line 88 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\Index.cshtml"
WriteAttributeValue("", 3489, item.AreaId, 3489, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3501, ")", 3501, 1, true);
            EndWriteAttribute();
            WriteLiteral(">編集</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3538, "\"", 3597, 2);
            WriteAttributeValue("", 3545, "/MasterMaintainance/Area/DetailView/?Id=", 3545, 40, true);
#nullable restore
#line 89 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\Index.cshtml"
WriteAttributeValue("", 3585, item.AreaId, 3585, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" target=\"_blank\">詳細</a>\r\n");
            WriteLiteral("                        <a class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3814, "\"", 3945, 8);
            WriteAttributeValue("", 3824, "DeleteConfirmation(\'/MasterMaintainance/Area/IsDelete/?Id=", 3824, 58, true);
#nullable restore
#line 91 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\Index.cshtml"
WriteAttributeValue("", 3882, item.AreaId, 3882, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3894, "\',", 3894, 2, true);
            WriteAttributeValue(" ", 3896, "null,", 3897, 6, true);
            WriteAttributeValue(" ", 3902, "null,", 3903, 6, true);
            WriteAttributeValue(" ", 3908, "true,", 3909, 6, true);
            WriteAttributeValue(" ", 3914, "\'削除しますか？\',", 3915, 11, true);
            WriteAttributeValue(" ", 3925, "\'このデータを完全に消去しました。\')", 3926, 20, true);
            EndWriteAttribute();
            WriteLiteral(">削除</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 94 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</form>\r\n\r\n");
            WriteLiteral(@"<div class=""modal"" id=""AddView"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">地 域 マ ス タ 登 録</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div id=""formArea"" class=""modal-body""></div>
            </div>
            <div class=""modal-footer"">
                <button type=""button""");
            BeginWriteAttribute("id", " id=\"", 4818, "\"", 4823, 0);
            EndWriteAttribute();
            WriteLiteral(@" onclick=""SaveChanges()"" class=""btn btn-primary"">登録</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">クローズ</button>
            </div>
        </div>
    </div>
</div>

<script>
    function AreaInformation(id) {
        $('#AddView').modal('show');
        $('#formArea').html('');
        $.ajax({
            method: ""GET"",
            url: ""/MasterMaintainance/Area/AddView/"" + id,
        }).done(function (data) {
            $('#formArea').html(data);
        });

    }
    function SaveChanges() {

        let postData = new FormData();
        postData.append('AreaId', $(""#AreaId"").val());
        postData.append('AreaCode', $(""#AreaCode"").val());
        postData.append('AreaName', $(""#AreaName"").val());
        postData.append('InsertDateTime', $(""#InsertDateTime"").val());
        postData.append('UpdateDateTime', $(""#UpdateDateTime"").val());
        postData.append('CountryId', $(""#CountryId"").val());
        postData.append('IsDe");
            WriteLiteral(@"leteArea', false);
        ;
        $.ajax({
            method: ""POST"",
            url: ""/MasterMaintainance/Area/SaveChanges/"",
            data: postData,
            contentType: false,
            processData: false,
        }).done(function (data) {
            $('#AddView').modal('hide');
            location.reload();
            alert('Data has Saved')
        });
    }

</script>


");
            WriteLiteral("<script>\r\n    function ClearData() {\r\n        document.getElementById(\"SearchForm\").reset();\r\n    }\r\n</script>\r\n\r\n");
            WriteLiteral("<script>\r\n        function goBack() {\r\n                window.location.href = \"/Home\";\r\n        }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GloableCommunication.Areas.MasterMaintainance.Models.ViewModels.AreaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
