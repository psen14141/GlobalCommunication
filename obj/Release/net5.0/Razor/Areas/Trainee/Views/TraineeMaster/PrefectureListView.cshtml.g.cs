#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\PrefectureListView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5457fc72e0d4a84ec61e1dfabc07c43ea3fed69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Trainee_Views_TraineeMaster_PrefectureListView), @"mvc.1.0.view", @"/Areas/Trainee/Views/TraineeMaster/PrefectureListView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5457fc72e0d4a84ec61e1dfabc07c43ea3fed69", @"/Areas/Trainee/Views/TraineeMaster/PrefectureListView.cshtml")]
    public class Areas_Trainee_Views_TraineeMaster_PrefectureListView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GloableCommunication.DbModels.Perfecture>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\PrefectureListView.cshtml"
  
    ViewData["Title"] = "PrefectureListView";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <div>
        <button class=""w3-button w3-green"" data-dismiss=""modal""
                onclick=""ReturnBtn()""><i class=""fa fa-arrow-left""></i></button>
    </div>
    <div>
        <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">戻る</a>

    </div>
</div>

<style>
    tr:hover td {
        background-color: #0095ff;
        cursor: pointer;
    }

    /*table tr.active {
        background-color: #0095ff;
    }*/

    td .selectRow {
        border: 1px #DDD solid;
        padding: 5px;
        cursor: pointer;
    }

    .selected {
        background-color: #0095ff;
        color: #FFF;
    }
    .modal-nw {
        max-width: 50% !important;
        align-self: center !important;
    }
</style>

<div class="" w3-margin-top w3-gray"">
    <h5 style=""text-align:center"">県区一覧</h5>
</div>


<table id=""prefectureTable"" class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th style=""display:none"">
            </th>
");
            WriteLiteral("            <th>\r\n                県区CD\r\n            </th>\r\n            <th>\r\n                県区\r\n            </th>\r\n");
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 76 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\PrefectureListView.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td style=\"display:none\">\r\n                    ");
#nullable restore
#line 80 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\PrefectureListView.cshtml"
               Write(Html.DisplayFor(modelItem => item.PerfectureId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 83 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\PrefectureListView.cshtml"
               Write(Html.DisplayFor(modelItem => item.PerfectureCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\PrefectureListView.cshtml"
               Write(Html.DisplayFor(modelItem => item.PerfectureName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 98 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\PrefectureListView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<script>
    $(ModalBtn).prop(""disabled"", true);

    $(""#prefectureTable tr"").click(function () {
        $(this).addClass('selected').siblings().removeClass('selected');
        var value = $(this).find('td:nth-child(3)').html();
        var nameValueTrim = value.trim();
        $(""input[name='PerfectureName']"").val(nameValueTrim);
        var idValue = $(this).find('td:nth-child(1)').html();
        $(""input[name='PerfectureId']"").val(idValue);
        $(ModalBtn).prop(""disabled"", false);

    });

    function ReturnBtn() {
        $(""input[name='PerfectureId']"").val('');
        $(""input[name='PerfectureName']"").val('');
        $('#listViewModal').modal('hide');
    }

    $(document).ready(function () {
        $('#prefectureTable').DataTable({
            ""lengthMenu"": [5, 10, 15, 20, 30],
            ""language"": {
                ""search"": ""検索:"",
                ""paginate"": {
                    ""first"": ""一ページ目"",
                    ""last"": ""最後のページ");
            WriteLiteral(@""",
                    ""next"": ""次へ"",
                    ""previous"": ""前へ""
                },
                ""lengthMenu"": "" _MENU_ 件表示"",
                ""info"": ""検索結果 _TOTAL_ 以上 のうち _START_ ~ _END_件"",
                ""infoEmpty"": ""検索結果 0 以上 のうち 0 ~ 0件"",
                ""emptyTable"": ""条件に一致する結果は見つかりませんでした"",
                ""zeroRecords"": ""条件に一致する結果は見つかりませんでした"",
            },
        });
        $('.dataTables_length').addClass('bs-select');
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GloableCommunication.DbModels.Perfecture>> Html { get; private set; }
    }
}
#pragma warning restore 1591
