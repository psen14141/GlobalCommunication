#pragma checksum "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\DetailView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cf9e5bfe5f3762283b1eabb27ae30dfc840ebb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_MasterMaintainance_Views_UserId_DetailView), @"mvc.1.0.view", @"/Areas/MasterMaintainance/Views/UserId/DetailView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf9e5bfe5f3762283b1eabb27ae30dfc840ebb4", @"/Areas/MasterMaintainance/Views/UserId/DetailView.cshtml")]
    public class Areas_MasterMaintainance_Views_UserId_DetailView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GloableCommunication.Areas.MasterMaintainance.Models.ViewModels.UserIdViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\DetailView.cshtml"
  
    ViewData["Title"] = "DetailView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">

<div class=""w3-padding w3-white"">
    <div>
        <button class=""w3-button w3-green"" onclick=""goBack()""><i class=""fa fa-arrow-left""></i></button>
        <button class=""w3-button w3-light-green"" onclick=""updateDiv()""><i class=""fa fa-refresh""></i></button>
");
            WriteLiteral(@"        <button class=""w3-button w3-light-blue"" onclick=""User.Print()""><i class=""fa fa-print""></i></button>
    </div>
    <div>
        <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">??????</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">??????</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-right:10px"">??????</a>
        <p style=""text-align:right"">?????????: 2018/08/10</p>
    </div>
</div>

<div class=""w3-container w3-margin-top w3-gray"">
    <h5 style=""text-align:center"">????????????ID??????</h5>
</div>

<div id=""divcontent"">
    <dl class=""row"">
        <dt class=""col-sm-2"">
");
            WriteLiteral("????????????ID\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\DetailView.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("?????????????????????\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\DetailView.cshtml"
       Write(Html.DisplayFor(model => model.UserCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("?????????\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\DetailView.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("???????????????\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\DetailView.cshtml"
       Write(Html.DisplayFor(model => model.InsertDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("???????????????\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\DetailView.cshtml"
       Write(Html.DisplayFor(model => model.UpdateDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n<script>\r\n\r\n    function goBack() {\r\n        window.location.href = \"/MasterMaintainance/UserId/\";\r\n    }\r\n\r\n</script>\r\n\r\n");
            WriteLiteral("<script>\r\n    function CloseModal() {\r\n        $(\'#listViewModal\').modal(\'hide\');\r\n    }\r\n</script>\r\n\r\n\r\n\r\n");
            WriteLiteral("<script>\r\n    function ClearData() {\r\n        document.getElementById(\"SearchForm\").reset();\r\n    }\r\n</script>\r\n\r\n");
            WriteLiteral("<script language=\"JavaScript\">\r\n    var Rows = document.getElementById(\'dtDesign\').getElementsByTagName(\'tr\');\r\n    var RowCount = Rows.length - 1;\r\n    document.getElementById(\"RowCount\").value = RowCount;\r\n</script>\r\n");
            WriteLiteral(@"<script type=""text/javascript"">
    function PrintDiv() {
        var divContents = document.getElementById(""divcontent"").innerHTML;
        var printWindow = window.open('', '', 'height=200,width=400');
        printWindow.document.write('<html><head><title>Print DIV Content</title>');
        printWindow.document.write('</head><body >');
        printWindow.document.write(divContents);
        printWindow.document.write('</body></html>');
        printWindow.document.close();
        printWindow.print();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GloableCommunication.Areas.MasterMaintainance.Models.ViewModels.UserIdViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
