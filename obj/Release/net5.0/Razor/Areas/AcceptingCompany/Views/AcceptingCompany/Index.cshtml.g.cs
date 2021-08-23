#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a52aa44af69bd7c08d42fe118f998db8ede845c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AcceptingCompany_Views_AcceptingCompany_Index), @"mvc.1.0.view", @"/Areas/AcceptingCompany/Views/AcceptingCompany/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a52aa44af69bd7c08d42fe118f998db8ede845c9", @"/Areas/AcceptingCompany/Views/AcceptingCompany/Index.cshtml")]
    public class Areas_AcceptingCompany_Views_AcceptingCompany_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GloableCommunication.Areas.AcceptingCompany.Model.ViewModel.AcceptingCompanyViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\Index.cshtml"
  
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
    <button class=""w3-button"" style=""background-color: #e7e7e7;"" type=""submit"" onclick=""SearchData()""><i class=""fa fa-search""></i></button>
    <button class=""w3-button"" style=""background-color: #e7e7e7; color:blue;"" onclick=""ClearData()""><i class=""fa fa-undo""></i></button>
");
            WriteLiteral(@"    <button class=""w3-button"" style=""background-color: #e7e7e7;"" onclick=""Print()""><i class=""fa fa-print""></i></button>
    <button class=""w3-button"" style=""background-color: #e7e7e7;"" onclick=""exportData()"" id=""ExcelBtn"">
        <i class=""fa fa-file-excel-o""></i>
        <span class=""glyphicon glyphicon-download""></span>
    </button>
<p>
    <a asp-action=""Create"" style=""font-size:14px; padding-right:10px"">戻 る</a>
    <a asp-action=""Create"" style=""font-size:14px; padding-right:10px"">検 索</a>
    <a asp-action=""Create"" style=""font-size:14px; padding-right:10px"">ク リ ア</a>
");
            WriteLiteral(@"    <a asp-action=""Create"" style=""font-size:14px; padding-right:10px"">印 刷</a>
    <a style=""font-size:10px;"">エクセル</a><a asp-action=""Create"" style=""font-size:14px; padding-right:10px"">出力</a>
</p>

<div class=""w3-container w3-margin-top"">
    <h5 style=""text-align:center""><b><u>受 入 企 業 一 覧</u></b></h5>
</div>

    <div class=""w3-panel w3-card"">
        <form method=""post"" id=""SearchForm"">
            <input type=""hidden"" id=""AreaId"" name=""AreaId"" />
            <input type=""hidden"" id=""PerfectureId"" name=""PerfectureId"" />

            <h6><b>検索 オプション</b></h6>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-3 align-self-center""><label asp-for=""AcceptingCompanyCode"" class=""col-md-4 text-right"">受入企業CDを指定</label></div>
                    <div class=""col-md-3 align-self-center"">
                        <input type=""text"" id=""AcceptingCompanyCode"" name=""AcceptingCompanyCode"" style=""border: 2px solid #ccc;"" placeholder=""Search.."" class=");
            WriteLiteral("\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2907, "\"", 2915, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""AcceptingCompanyCode"" class=""text-danger""></span>
                    </div>
                    <div class=""col-md-2 align-self-center""><label asp-for=""AreaId"" class=""col-md-3 text-right"" style=""padding-right:15px;"">地域を指定</label></div>
                    <div class=""col-md-2 align-self-center"">
                        <button type=""button"" style=""padding: 5px 15px 5px 15px; background-color: #e7e7e7; border: 2px solid #ccc;"" href=""#"" onclick=""showAreaList()"">検索</button>
");
            WriteLiteral(@"                        <button type=""button"" onclick=""document.getElementById('AreaName').value = ''"" style=""padding: 5px 5px 5px 5px; background-color: #e7e7e7; border: 2px solid #ccc; color:blue;""><i class=""fa fa-undo""></i></button>
                    </div>
                    <div class=""col-md-2 align-self-center"">
                        <input  asp-for=""AreaName"" name=""AreaName"" id=""AreaName"" class=""form-control"" style=""border: 2px solid #ccc;"" readonly />
                        <span asp-validation-for=""AreaId"" class=""text-danger""></span>
                    </div>
                </div>
            </div>

            <div class=""form-group"" style=""padding-top:1px;"">
                <div class=""row"">
                    <div class=""col-md-6 align-self-center""></div>
                    <div class=""col-md-2 align-self-center""><label asp-for=""PerfectureId"" class=""col-md-3 text-right"" style=""padding-right:15px;"">県を指定</label></div>
                    <div class=""col-md-2 align-self-cente");
            WriteLiteral(@"r"">
                        <button type=""button"" style=""padding: 5px 15px 5px 15px; background-color: #e7e7e7; border: 2px solid #ccc;"" href=""#"" onclick=""showPerfectureList()"">検索</button>
                        <button type=""button"" id=""PerfectureId"" onclick=""document.getElementById('PerfectureName').value = ''"" style=""padding: 5px 5px 5px 5px; background-color: #e7e7e7; border: 2px solid #ccc; color:blue;""><i class=""fa fa-undo""></i></button>
                    </div>
                    <div class=""col-md-2 align-self-center"">
                        <input asp-for=""PerfectureName"" name=""PerfectureName"" id=""PerfectureName"" class=""form-control"" style=""border: 2px solid #ccc;"" readonly />
                        <span asp-validation-for=""PerfectureId"" class=""text-danger""></span>
                    </div>
                </div>
            </div>

            <div class=""form-group"" style=""padding-top:1px;"">
                <div class=""row"">
                    <div class=""col-md-8 align-self-c");
            WriteLiteral("enter\"></div>\r\n                    <div class=\"col-md-2 align-self-center\">\r\n                        <input id=\"A_Id1\" type=\"checkbox\" style=\"border: 2px solid #ccc;\" name=\"A_Id1\"");
            BeginWriteAttribute("value", " value=\"", 5851, "\"", 5859, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" />
                        <script>
                            $('#checkbox-value').text($('#A_Id1').val());

                            $(""#A_Id1"").on('change', function () {
                                if ($(this).is(':checked')) {
                                    $(this).attr('value', 'true');
                                } else {
                                    $(this).attr('value', 'false');
                                }
                                $('#checkbox-value').text($('#A_Id1').val());
                            });
                        </script>
                    </div>
                    <div class=""col-md-2 align-self-center"">
                        <label asp-for=""A_Id1"" class=""col-md-6 text-right"">受入をしている企業のみ</label>
                    </div>
                </div>
            </div>
</form>
    </div>

    <div class=""form-group"" style=""padding-top:1px;"">
        <div class=""row"">
            <div class=""col-md-1");
            WriteLiteral(@"0 align-self-center""></div>
            <div class=""col-md-1 align-self-center""><label asp-for=""RowCount"" class=""col-md-1 text-right"">件数</label></div>
            <div class=""col-md-1 align-self-center"">
                <input name=""RowCount"" id=""RowCount""");
            BeginWriteAttribute("value", " value=\"", 7143, "\"", 7151, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""border: 2px solid #ccc; color:black;"" class=""form-control"" disabled />
            </div>
        </div>
    </div>

    <div style=""overflow:auto"">
        <table id=""dtDesign"" style=""text-align:center"" class=""table table-bordered table-striped table-sm"" cellspacing=""0"" width=""100%"">
            <thead>
                <tr>
                    <th>
                        受入企業 CD
                    </th>
                    <th>
                        受入企業名
                    </th>
                    <th>
                        地域
                    </th>
                    <th>
                        県
                    </th>
                    <th>
                        受入人数
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody id=""databody"">
");
#nullable restore
#line 145 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 149 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AcceptingCompanyCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 152 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AcceptiingCompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 155 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AreaName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 158 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PerfectureName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 161 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Limit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 8877, "\"", 8951, 2);
            WriteAttributeValue("", 8884, "/AcceptingCompany/AcceptingCompany/Add/?Id=", 8884, 43, true);
#nullable restore
#line 165 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\Index.cshtml"
WriteAttributeValue("", 8927, item.AcceptingCompanyId, 8927, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" target=\"_blank\">編集</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 9031, "\"", 9112, 2);
            WriteAttributeValue("", 9038, "/AcceptingCompany/AcceptingCompany/DetailView/?Id=", 9038, 50, true);
#nullable restore
#line 166 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\Index.cshtml"
WriteAttributeValue("", 9088, item.AcceptingCompanyId, 9088, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" target=\"_blank\">詳細</a>\r\n                            <a class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 9215, "\"", 9368, 8);
            WriteAttributeValue("", 9225, "DeleteConfirmation(\'/AcceptingCompany/AcceptingCompany/IsDelete/?Id=", 9225, 68, true);
#nullable restore
#line 167 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\Index.cshtml"
WriteAttributeValue("", 9293, item.AcceptingCompanyId, 9293, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9317, "\',", 9317, 2, true);
            WriteAttributeValue(" ", 9319, "null,", 9320, 6, true);
            WriteAttributeValue(" ", 9325, "null,", 9326, 6, true);
            WriteAttributeValue(" ", 9331, "true,", 9332, 6, true);
            WriteAttributeValue(" ", 9337, "\'削除しますか？\',", 9338, 11, true);
            WriteAttributeValue(" ", 9348, "\'このデータを完全に消去しました。\')", 9349, 20, true);
            EndWriteAttribute();
            WriteLiteral(">削除</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 170 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n\r\n");
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
            WriteLiteral("<script>\r\n    function CloseModal() {\r\n        $(\'#listViewModal\').modal(\'hide\');\r\n    }\r\n</script>\r\n\r\n");
            WriteLiteral(@"<script>
    function showAreaList() {
        $('#listViewModal').modal({
            backdrop: 'static',
            keyboard: false
        });
        $('#formArea').html("""");
        $.ajax({
            method: ""GET"",
            url: ""/AcceptingCompany/AcceptingCompany/AreaListView"",
        })
            .done(function (msg) {
                $(""#formArea"").html(msg);

            });
    }
</script>

");
            WriteLiteral(@"
<script>
    function showPerfectureList() {
        $('#listViewModal').modal(); //open the modal
        $('#formArea').html(""""); // clear exsisting Areas
        $.ajax({
            method: ""GET"",
            url: ""/AcceptingCompany/AcceptingCompany/PerfectureListView"",
        })
            .done(function (msg) {
                $(""#formArea"").html(msg);

            });
    }
</script>

");
            WriteLiteral("<script>\r\n    function ClearData() {\r\n        document.getElementById(\"SearchForm\").reset();\r\n    }\r\n</script>\r\n\r\n\r\n");
            WriteLiteral("<script>\r\n    function goBack() {\r\n        window.location.href = \"/Home\";\r\n    }\r\n</script>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"<script language=""JavaScript"">
    var Rows = document.getElementById('dtDesign').getElementsByTagName('tr');
    var RowCount = Rows.length - 1;
    document.getElementById(""RowCount"").value = RowCount;

    //alert('Your table has ' + RowCount + ' rows.');
</script>

");
            WriteLiteral(@"
<script>
    function exportData() {
        /* Get the HTML data using Element by Id */
        var table = document.getElementById(""dtDesign"");

        /* Declaring array variable */
        var rows = [];

        //iterate through rows of table
        for (var i = 0, row; row = table.rows[i]; i++) {
            //rows would be accessed using the ""row"" variable assigned in the for loop
            //Get each cell value/column from the row
            column1 = row.cells[0].innerText;
            column2 = row.cells[1].innerText;
            column3 = row.cells[2].innerText;
            column4 = row.cells[3].innerText;
            column5 = row.cells[4].innerText;

            /* add a new records in the array */
            rows.push(
                [
                    column1,
                    column2,
                    column3,
                    column4,
                    column5
                ]
            );

        }
        csvContent = ""data:text/csv");
            WriteLiteral(@";charset=utf-8,"";
        /* add the column delimiter as comma(,) and each row splitted by new line character (\n) */
        rows.forEach(function (rowArray) {
            row = rowArray.join("","");
            csvContent += row + ""\r\n"";
        });

        /* create a hidden <a> DOM node and set its download attribute */
        var encodedUri = encodeURI(csvContent);
        var link = document.createElement(""a"");
        link.setAttribute(""href"", encodedUri);
        link.setAttribute(""download"", ""受入企業一覧.csv"");
        document.body.appendChild(link);
        /* download the data file named ""Stock_Price_Report.csv"" */
        link.click();
    }
</script>

");
            WriteLiteral("\r\n");
            WriteLiteral(@"<script>

    function SearchData() {

        let postData = new FormData();

        postData.append('AreaId', $(""#AreaId"").val());

        postData.append('PerfectureId', $(""#PerfectureId"").val());

        postData.append('AcceptingCompanyCode', $(""#AcceptingCompanyCode"").val());


        $.ajax({
            method: ""POST"",
            url: ""/AcceptingCompany/AcceptingCompany/SearchData/"",
            data: postData,
            contentType: false,
            processData: false,
        })
            .done(function (msg) {

                $(""#databody"").html(msg);

            });
    }

</script>

");
            WriteLiteral(@"<script>
    function Print() {

        var panel = document.getElementById(""dtDesign"");
        var printWindow = window.open('', '', 'height=800,width=800');
        printWindow.document.write('<html><head><title>DIV Contents</title>');
        printWindow.document.write('</head><body >');
        printWindow.document.write(panel.innerHTML);
        printWindow.document.write('</body></html>');
        printWindow.document.close();
        setTimeout
            (function () {
                printWindow.print();
            }, 500);
        return false;
    }
</script>

");
            WriteLiteral(@"<script>
    $(""input"").on(""keyup"", function () {
        var maxLength = $(this).attr(""maxlength"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GloableCommunication.Areas.AcceptingCompany.Model.ViewModel.AcceptingCompanyViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591