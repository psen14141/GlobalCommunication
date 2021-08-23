#pragma checksum "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7637ce954bf3199ce1a4f5d72d98e33bd36d11af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SendingCompanies_Views_SendingCompany_Index), @"mvc.1.0.view", @"/Areas/SendingCompanies/Views/SendingCompany/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7637ce954bf3199ce1a4f5d72d98e33bd36d11af", @"/Areas/SendingCompanies/Views/SendingCompany/Index.cshtml")]
    public class Areas_SendingCompanies_Views_SendingCompany_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GloableCommunication.Areas.SendingCompanies.Model.ViewModels.SendingCompanyViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    label {
        color: #1b1c20 !important;
        font-size: 14px !important;
    }

    button {
        color: #1b1c20 !important;
        font-size: 14px !important;
    }
    input {
        color: #1b1c20 !important;
        font-size: 14px !important;
    }
</style>



<script>
    $(document).ready(function () {
        $('#dtDesign').DataTable({
            ""lengthMenu"": [10, 20, 30, 40, 50],
            ""language"": {
                ""search"": ""検索:"",
                ""paginate"": {
                    ""first"": ""一ページ目"",
                    ""last"": ""最後のページ"",
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
        $('.dat");
            WriteLiteral(@"aTables_length').addClass('bs-select');
    });
</script>



<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">


<div class=""w3-padding w3-white"">
    <p>
        <button class=""w3-button w3-green"" onclick=""goBack()""><i class=""fa fa-arrow-left""></i></button>
        <button type=""submit"" onclick=""SearchData()"" class=""w3-button w3-blue""><i class=""fa fa-search""></i></button>
        <button class=""w3-button w3-light-green"" onclick=""IndexReset()""><i class=""fa fa-undo""></i></button>
");
            WriteLiteral(@"        <button class=""w3-button"" style=""background-color: #e7e7e7;"" onclick=""Sending.Print()""><i class=""fa fa-print""></i></button>
        <button id=""btnExcel"" class=""w3-button w3-light-gray""><i class=""fa fa-file-excel-o""></i></button>
    <p>
        <a asp-action=""Create"" style=""font-size:15px; padding-right:10px"">戻る</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-right:10px"">検索</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-right:10px"">クリア</a>
");
            WriteLiteral(@"        <a asp-action=""Create"" style=""font-size:15px; padding-right:10px"">印刷</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-right:10px"">エクセル出力</a>

    </p>
</div>

<div class=""w3-container w3-margin-top w3-gray"">
    <h5 style=""text-align:center""><b>送出機関一覧</b></h5>
</div>

<div class=""w3-panel w3-card"" style=""padding: 20px;"">
    <form method=""post"" id=""SearchForm"">
");
            WriteLiteral(@"        <input type=""hidden"" id=""CountryId"" name=""CountryId"" />
        <input type=""hidden"" id=""AreaId"" name=""AreaId"" />
        <input type=""hidden"" id=""CheckStatus"" name=""CheckStatus""/>
        <h6><b>検索 オプション</b></h6>

        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-md-3 align-self-center""><label asp-for=""SendingComapny"" class=""col-md-4 text-right"">送出機園CDを指定</label></div>
                <div class=""col-md-3 align-self-center"">
                    <input type=""text"" id=""SendingComapny"" name=""SendingComapny"" style=""border: 2px solid #ccc;"" placeholder=""検索 ..."" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3911, "\"", 3919, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    <span asp-validation-for=""SendingComapny"" class=""text-danger""></span>
                </div>
                <div class=""col-md-2 align-self-center""><label asp-for=""AreaId"" class=""col-md-3 text-right"" style=""padding-right:15px;"">国を指定</label></div>
                <div class=""col-md-2 align-self-center"">
                    <button type=""button"" class=""btn btn-secondary"" style=""padding: 5px 15px 5px 15px; color:white!important;"" href=""#"" onclick=""showCountryList()"">検索</button>
                    <button type=""button"" class=""fa fa-undo"" onclick=""document.getElementById('CountryName').value = ''; document.getElementById('CountryId').value = '';"" style=""padding: 5px 5px 5px 5px; background-color: #e7e7e7; border: 2px solid #ccc; color:blue;""></button>
                </div>
                <div class=""col-md-2 align-self-center"">
                    <input asp-for=""CountryName"" name=""CountryName"" id=""CountryName"" readonly class=""form-control"" />
                    <span asp-val");
            WriteLiteral(@"idation-for=""AreaId"" class=""text-danger""></span>
                </div>
            </div>
        </div>

        <div class=""form-group"" style=""padding-top:1px;"">
            <div class=""row"">
                <div class=""col-md-6 align-self-center""></div>
                <div class=""col-md-2 align-self-center""><label asp-for=""PerfectureId"" class=""col-md-3 text-right"" style=""padding-right:15px;"">地域を指定</label></div>
                <div class=""col-md-2 align-self-center"">
                    <button type=""button"" class=""btn btn-secondary"" style=""padding: 5px 15px 5px 15px; color:white!important;"" href=""#"" onclick=""showAreaList()"">検索</button>
                    <button type=""button"" class=""fa fa-undo"" onclick=""document.getElementById('AreaName').value = ''; document.getElementById('AreaId').value = ''"" style=""padding: 5px 5px 5px 5px; background-color: #e7e7e7; border: 2px solid #ccc; color:blue;""></button>
                </div>
                <div class=""col-md-2 align-self-center"">
         ");
            WriteLiteral(@"           <input asp-for=""AreaName"" name=""AreaName"" id=""AreaName"" readonly class=""form-control"" />
                    <span asp-validation-for=""AreaId"" class=""text-danger""></span>
                </div>
            </div>
        </div>
    </form>
</div>

<p style=""text-align:right; padding-right:50px"">件数 &nbsp; &nbsp;0</p>

<p>
    <!--<a href=""/SendingCompanies/SendingCompany/AddorEditView/""--> ");
            WriteLiteral(@" <!--class=""btn btn-primary"" onclick=""showAddOrEditUi(0)"">追加</a>-->
</p>
<div style=""overflow:auto"" >
    <table id=""dtDesign"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"" >
        <thead>
            <tr>
                <th>
");
            WriteLiteral(" 送出機関CD\r\n                </th>\r\n");
            WriteLiteral("                <th>\r\n");
            WriteLiteral(" 送出機関名\r\n                </th>\r\n");
            WriteLiteral("                <th>\r\n");
            WriteLiteral(" 国\r\n                </th>\r\n                <th>\r\n");
            WriteLiteral(" 地域\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody id=\"datatbody\">\r\n");
#nullable restore
#line 156 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 160 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SendingComapny));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 163 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SendingName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 166 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CountryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 169 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AreaName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 8218, "\"", 8298, 2);
            WriteAttributeValue("", 8225, "/SendingCompanies/SendingCompany/AddorEditView/?Id=", 8225, 51, true);
#nullable restore
#line 173 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
WriteAttributeValue("", 8276, item.SendingCompanyId, 8276, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">編集</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 8358, "\"", 8435, 2);
            WriteAttributeValue("", 8365, "/SendingCompanies/SendingCompany/DetailView/?Id=", 8365, 48, true);
#nullable restore
#line 174 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
WriteAttributeValue("", 8413, item.SendingCompanyId, 8413, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">詳細</a>\r\n                        <a class=\"btn btn-danger\" style=\"color: white;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 8540, "\"", 8686, 8);
            WriteAttributeValue("", 8550, "DeleteConfirmation(\'/SendingCompanies/SendingCompany/Delete/?Id=", 8550, 64, true);
#nullable restore
#line 175 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
WriteAttributeValue("", 8614, item.SendingCompanyId, 8614, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8636, "\',", 8636, 2, true);
            WriteAttributeValue(" ", 8638, "null,", 8639, 6, true);
            WriteAttributeValue(" ", 8644, "null,", 8645, 6, true);
            WriteAttributeValue(" ", 8650, "true,", 8651, 6, true);
            WriteAttributeValue(" ", 8656, "\'削除しますか？\',", 8657, 11, true);
            WriteAttributeValue(" ", 8667, "\'このデータを完全に消去しまか?\')", 8668, 19, true);
            EndWriteAttribute();
            WriteLiteral(">削除</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 178 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n");
            WriteLiteral(@"
<div hidden>
    <table id=""ExcelPrint"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
        <thead>
            <tr>
                <th>送出機関CD</th>
                <th>送出機関名</th>
                <th>国</th>
                <th>地域</th>
            </tr>
        </thead>
        <tbody id=""datatbody2"">
");
#nullable restore
#line 198 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 201 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SendingComapny));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 202 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SendingName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 203 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CountryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 204 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AreaName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 206 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n");
            WriteLiteral(@"<div id=""listViewModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-nw"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body"" id=""formArea"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" href=""#"" onclick=""CloseModal()"" id=""ModalBtn"" class=""btn btn-primary"">選択</button>
            </div>
        </div>
    </div>
</div>
");
            WriteLiteral(@"
<script>
    function CloseModal() {
        $('#listViewModal').modal('hide');
    }
</script>

<script>
    function showCountryList() {
        $('#listViewModal').modal({
            backdrop: 'static',
            keyboard: false
        }); //open the modal
        $('#formArea').html(""""); // clear exsisting Areas
        $.ajax({
            method: ""GET"",
            url: ""/SendingCompanies/SendingCompany/CountyListView"",
        })
            .done(function (msg) {
                $(""#formArea"").html(msg);
            });
    }
</script>

<script>
    function showAreaList() {
        $('#listViewModal').modal(); //open the modal
        $('#formArea').html(""""); // clear exsisting Areas
        $.ajax({
            method: ""GET"",
            url: ""/SendingCompanies/SendingCompany/AreaListView"",
        })
            .done(function (msg) {
                $(""#formArea"").html(msg);

            });
    }
</script>


<script>
    function IndexReset() {
     ");
            WriteLiteral("   document.getElementById(\"SearchForm\").reset();\r\n        location.reload();\r\n    }\r\n</script>\r\n\r\n\r\n");
            WriteLiteral(@"<script>
    function goBack() {
        window.history.back();
    }
</script>

<script>
    $(""#btnExcel"").click(function () {
        tableToExcel('ExcelPrint', 'W3C Example Table');
    });


    var tableToExcel = (function () {
        var uri = 'data:application/vnd.ms-excel;base64,'
            , template = '<html xmlns:o=""urn:schemas-microsoft-com:office:office"" xmlns:x=""urn:schemas-microsoft-com:office:excel"" xmlns=""http://www.w3.org/TR/REC-html40""><head><!--[if gte mso 9]><xml><x:ExcelWorkbook><x:ExcelWorksheets><x:ExcelWorksheet><x:Name>{worksheet}</x:Name><x:WorksheetOptions><x:DisplayGridlines/></x:WorksheetOptions></x:ExcelWorksheet></x:ExcelWorksheets></x:ExcelWorkbook></xml><![endif]--></head><body><table>{table}</table></body></html>'
            , base64 = function (s) { return window.btoa(unescape(encodeURIComponent(s))) }
            , format = function (s, c) { return s.replace(/{(\w+)}/g, function (m, p) { return c[p]; }) }
        return function (table, name) {
     ");
            WriteLiteral(@"       if (!table.nodeType) table = document.getElementById(table)
            var ctx = { worksheet: name || 'Worksheet', table: table.innerHTML }
            window.location.href = uri + base64(format(template, ctx))
        }
    })()
</script>


<script>


    function SearchData() {

        let postData = new FormData();

        postData.append('CountryId', $(""#CountryId"").val());

        postData.append('AreaId', $(""#AreaId"").val());

        postData.append('SendingComapny', $(""#SendingComapny"").val());


        $.ajax({
            method: ""POST"",
            url: ""/SendingCompanies/SendingCompany/GetSearchData/"",
            data: postData,
            contentType: false,
            processData: false,
        })
            .done(function (msg) {

                $(""#datatbody"").html(msg);
                $(""#datatbody2"").html(msg);
            });
    }


</script>


<script>
    $(""input"").on(""keyup"", function () {
        var maxLength = $(this).attr");
            WriteLiteral(@"(""maxlength"");
        if (maxLength == $(this).val().length) {
            alert(""Characters length exceeds the Limit, please input less than "" + maxLength + "" characters"");
        }
    })

    $(""textarea"").on(""keyup"", function () {
        var maxLength = $(this).attr(""maxlength"");
        if (maxLength == $(this).val().length) {
            alert(""Characters length exceeds the Limit, please input less than "" + maxLength + "" characters"");
        }
    })
</script>

<script>

    var Sending = new function () {

        this.Print = function () {
            var dtDesign = document.getElementById('ExcelPrint');
            //var Design = dtDesign.length - 1;

            var style = ""<style>"";
            style = style + ""table {width: 100%;font: 17px Calibri;}"";
            style = style + ""table, th, td {border: solid 1px #DDD; border-collapse: collapse;"";
            style = style + ""padding: 2px 3px;text-align: left;}"";
            style = style + ""</style>"";

            ");
            WriteLiteral(@"var win = window.open('', '', 'height=700,width=700');
            win.document.write(style);          //  add the style.
            win.document.write(dtDesign.outerHTML);
            win.document.close();
            win.print();
        }
    }
</script>

<script>
    function showAddOrEditUi() {
        location.replace(""/SendingCompanies/SendingCompany/AddorEditView/"")
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GloableCommunication.Areas.SendingCompanies.Model.ViewModels.SendingCompanyViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591