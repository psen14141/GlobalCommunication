#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0cdf21c3202b409c9fc96621ceeb91539eec0d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_MasterMaintainance_Views_UserId_Index), @"mvc.1.0.view", @"/Areas/MasterMaintainance/Views/UserId/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0cdf21c3202b409c9fc96621ceeb91539eec0d0", @"/Areas/MasterMaintainance/Views/UserId/Index.cshtml")]
    public class Areas_MasterMaintainance_Views_UserId_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GloableCommunication.DbModels.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\Index.cshtml"
  
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

<h2>ユーザーID登録</h2>
<br />
<br />
<br />

    <div class=""row"">
        <div class=""col-sm"">

            <button class=""btn btn-primary""><i class=""fa fa-home""></i> 戻る</button>
            <button href=""#"" onclick=""UserInformation(0)"" class=""btn btn-success""><i class=""fa fa-folder""></i> 登録</button>
            <button class=""btn btn-warning""><i class=""fa fa-trash""></i> クリア</button>
            <button class=""btn btn-danger""><i class=""fa fa-close""></i> 削除</button>



");
            WriteLiteral("        </div>\r\n        <div class=\"col-sm\">\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n<br />\r\n<br />\r\n<br />\r\n\r\n<table id=\"dtDesign\" class=\"table table-striped table-bordered table-sm\" cellspacing=\"0\" width=\"100%\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th>\r\n                ユーザーID\r\n            </th>\r\n            <th>\r\n                パスワード\r\n            </th>\r\n");
            WriteLiteral("\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 69 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("\r\n            <td>\r\n                <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2617, "\"", 2658, 3);
            WriteAttributeValue("", 2627, "Countrynformation(", 2627, 18, true);
#nullable restore
#line 89 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\Index.cshtml"
WriteAttributeValue("", 2645, item.UserId, 2645, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2657, ")", 2657, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n                <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2721, "\"", 2762, 3);
            WriteAttributeValue("", 2731, "Countrynformation(", 2731, 18, true);
#nullable restore
#line 90 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\Index.cshtml"
WriteAttributeValue("", 2749, item.UserId, 2749, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2761, ")", 2761, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Details</a>\r\n                <a class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2842, "\"", 2975, 8);
            WriteAttributeValue("", 2852, "DeleteConfirmation(\'/MaterMaintainance/UserId/Delete/?Id=", 2852, 57, true);
#nullable restore
#line 91 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\Index.cshtml"
WriteAttributeValue("", 2909, item.UserId, 2909, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2921, "\',", 2921, 2, true);
            WriteAttributeValue(" ", 2923, "null,", 2924, 6, true);
            WriteAttributeValue(" ", 2929, "null,", 2930, 6, true);
            WriteAttributeValue(" ", 2935, "true,", 2936, 6, true);
            WriteAttributeValue(" ", 2941, "\'Warning\',", 2942, 11, true);
            WriteAttributeValue(" ", 2952, "\'GlobalCommunication\')", 2953, 23, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n\r\n            </td>\r\n            </tr>\r\n");
#nullable restore
#line 95 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>




<div id=""AddorEditView"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Area section</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""formArea"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" onclick=""SaveChanges()"" class=""btn btn-primary"">Save changes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<script>
    function UserInformation(id) {

        $('#AddorEditView').modal(); //open the model
        $(""#formArea"").html(""""); // Clear existing ar");
            WriteLiteral(@"e
        //alert(""test message!"");
        $.ajax({
            method: ""GET"",
            url: ""/MasterMaintainance/UserId/AddorEditView/"" + id,
        })
            .done(function (msg) {
                $(""#formArea"").html(msg);

            });
    }


    function SaveChanges() {

        let postData = new FormData();
        postData.append('UserId', $(""#UserId"").val());
        postData.append('UserCode', $(""#UserCode"").val());
        postData.append('Password', $(""#Password"").val());
        postData.append('AccessFlag', $(""#AccessFlag"").val());
        postData.append('InsertDateTime', $(""#InsertDateTime"").val());
        postData.append('UpdateDateTime', $(""#UpdateDateTime"").val());
   

        $.ajax({
            method: ""POST"",
            url: ""/MasterMaintainance/UserId/SaveChanges/"",
            enctype: 'multipart/form-data',
            data: postData,
            contentType: false,
            processData: false,
        })
            .done(function (");
            WriteLiteral(@"msg) {
                $('#AddOrEditView').modal('hide')
                alert(""Data has saved"");
                location.reload();
            });
    }
    $(document).ready(function () {
        $('#dtDesign').DataTable();
        $('.dataTables_length').addClass('bs-select');
    });
    function GetConfirmation() {
        var reply = confirm(""Are you sure you want to delete this?"");
        if (reply) {
            return true;
        }
        else {
            return false;
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GloableCommunication.DbModels.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
