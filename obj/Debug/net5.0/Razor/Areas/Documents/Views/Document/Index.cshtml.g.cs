#pragma checksum "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "804a8d269bd376a6b07989ddf528469910c21741"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Documents_Views_Document_Index), @"mvc.1.0.view", @"/Areas/Documents/Views/Document/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"804a8d269bd376a6b07989ddf528469910c21741", @"/Areas/Documents/Views/Document/Index.cshtml")]
    public class Areas_Documents_Views_Document_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GloableCommunication.Areas.Documents.Models.ViewModels.DocumentViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\Index.cshtml"
  
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
<h5>Document</h5>

<p>
    <a href=""#"" class=""btn btn-primary"" onclick=""showAddOrEditUi(0)"">Create New</a>
</p>
<table id=""dtDesign"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
    <thead>
        <tr>
            <th>
");
            WriteLiteral("#\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("Document Name\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral(" Document Type\r\n            </th>\r\n");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 45 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DocumentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DocumentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DocumentTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    <a href=\"#\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2263, "\"", 2306, 3);
            WriteAttributeValue("", 2273, "showAddOrEditUi(", 2273, 16, true);
#nullable restore
#line 67 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\Index.cshtml"
WriteAttributeValue("", 2289, item.DocumentId, 2289, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2305, ")", 2305, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2363, "\"", 2513, 11);
            WriteAttributeValue("", 2373, "DeleteConfirmation(\'/Documents/Document/Delete/?Id=", 2373, 51, true);
#nullable restore
#line 68 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\Index.cshtml"
WriteAttributeValue("", 2424, item.DocumentId, 2424, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2440, "\',null,null,true,", 2440, 17, true);
            WriteAttributeValue(" ", 2457, "\'Do", 2458, 4, true);
            WriteAttributeValue(" ", 2461, "you", 2462, 4, true);
            WriteAttributeValue(" ", 2465, "want", 2466, 5, true);
            WriteAttributeValue(" ", 2470, "to", 2471, 3, true);
            WriteAttributeValue(" ", 2473, "delete?\',\'Permanently", 2474, 22, true);
            WriteAttributeValue(" ", 2495, "erase", 2496, 6, true);
            WriteAttributeValue(" ", 2501, "this", 2502, 5, true);
            WriteAttributeValue(" ", 2506, "data\')", 2507, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2549, "\"", 2609, 2);
            WriteAttributeValue("", 2556, "/Documents/Document/DownloadFile/?id=", 2556, 37, true);
#nullable restore
#line 69 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\Index.cshtml"
WriteAttributeValue("", 2593, item.DocumentId, 2593, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Download</a>\r\n");
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 74 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            WriteLiteral(@"
<div id=""AddOrEditDocument"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Document Information</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""formArea"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" onclick=""uploadingZipFile()"" class=""btn btn-primary"">Save changes</button>
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

");
            WriteLiteral(@"<script>
    function showAddOrEditUi(id) {
        $('#AddOrEditDocument').modal(); //open the model
        $(""#formArea"").html(""""); // Clear existing are

        $.ajax({
            method: ""GET"",
            url: ""/Documents/Document/AddorEditView?Flag=0&Id="" + id,
        })
            .done(function (msg) {
                $(""#formArea"").html(msg);

            });
    }



    function SaveData() {
        let postData = new FormData();
        postData.append('DocumentId', $(""#DocumentId"").val());
        postData.append('DocumentTypeId', $(""#DocumentCategoryId"").val());
        postData.append('DocumentName', $(""#DocumentName"").val());
        postData.append('DocumentDescription', $(""#DocumentDescription"").val());
        postData.append('DocumentIsDelete', $(""#DocumentIsDelete"").val());
        postData.append('DocumentFilePath', $(""#UploadedFile"").val());

        var files = $(""#UploadedFile"").get(0).files;
        if (files.length > 0) {
            postData.append");
            WriteLiteral(@"(""UploadedDoc"", files[0]);
        }

        $.ajax({
            method: ""POST"",
            enctype: 'multipart/form-data',
            url: ""/Documents/Document/SaveData/"",
            data: postData,
            contentType: false,
            processData: false,
        })
            .done(function (msg) {
                $('#AddOrEditDocument').modal('hide')
                alert(""Data has saved"");
                location.reload();
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GloableCommunication.Areas.Documents.Models.ViewModels.DocumentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
