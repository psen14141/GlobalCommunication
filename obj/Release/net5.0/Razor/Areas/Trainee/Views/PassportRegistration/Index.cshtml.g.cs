#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\PassportRegistration\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55b9cbd93ec7c783fc4d686b22b9f6a4690ec36c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Trainee_Views_PassportRegistration_Index), @"mvc.1.0.view", @"/Areas/Trainee/Views/PassportRegistration/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55b9cbd93ec7c783fc4d686b22b9f6a4690ec36c", @"/Areas/Trainee/Views/PassportRegistration/Index.cshtml")]
    public class Areas_Trainee_Views_PassportRegistration_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GloableCommunication.DbModels.TraineeHistory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\PassportRegistration\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha/js/bootstrap.min.js""></script>
    <link href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha/css/bootstrap.min.css"" rel=""stylesheet"" />
");
            WriteLiteral(@"
<h1>Index</h1>

<script>
    $('#bologna-list a').on('click', function (e) {
        e.preventDefault()
        $(this).tab('show')
    })

</script>
<p>
    <a asp-action=""Create"">Create New</a>
</p>

<style>
    /*    body {
            padding: 2rem 0rem;
        }*/
    #parent {
        display: flex;
    }

    #narrow {
        width: 400px;
        /*        background: lightblue;
    */
    }

    #wide {
        flex: 1;
        /* Grow to rest of container */
        /*        background: lightgreen;
    */
    }

    canvas {
        width: 800px !important;
        height: 400px !important;
    }

    #outer {
        width: 100%;
        text-align: center;
    }

    .inner {
        display: inline-block;
    }

    body {
        padding: 2rem 0rem;
    }
</style>

<div id=""parent"">
    <div id=""wide"">
        <div class=""card card-custom mx-2 mb-3"">
            <div class=""card-body"">
                <h2 class=""card-title"">???????????????</h2>");
            WriteLiteral(@"
            </div>
        </div>
        <div class=""card card-custom mx-2 mb-3"">
            <div class=""card text-center"">
                <div class=""card-header"">
                    <ul class=""nav nav-tabs card-header-tabs"" id=""bologna-list"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""#description1"" aria-selected=""true"" role=""tab"" aria-controls=""description1"">???????????????</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#description2"" aria-selected=""false"" role=""tab"" aria-controls=""description2"">???????????????</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#description3"" aria-selected=""false"" role=""tab"" aria-controls=""description3"">?????????????????????????????????</a>
                        </li>
                    </ul>
                    <div class=""tab-content mt-3"">
 ");
            WriteLiteral(@"                       <div class=""tab-pane active"" id=""description1"" role=""tabpanel"">
                            <p class=""card-text"">It is the seventh most populous city in Italy, at the heart of a metropolitan area of about one million people. </p>
                            <a href=""#"" class=""card-link text-danger"">Read more</a>
                        </div>

                        <div class=""tab-pane"" id=""description2"" role=""tabpanel"" aria-labelledby=""description2"">
                            <p class=""card-text"">First settled around 1000 BCE and then founded as the Etruscan Felsina about 500 BCE, it was occupied by the Boii in the 4th century BCE and became a Roman colony and municipium with the name of Bononia in 196 BCE. </p>
                            <a href=""#"" class=""card-link text-danger"">Read more</a>
                        </div>

                        <div class=""tab-pane"" id=""description3"" role=""tabpanel"" aria-labelledby=""description3"">
                              <div ");
            WriteLiteral(@"class=""card-body"">
                                  <h5 class=""card-title"">?????????????????????????????????</h5>
                                <p class=""card-text""></p>
                              </div>
                              <p class=""card-text"">
                                  ???????????????                 :<a href=""#"" class=""btn btn-primary btn-sm"">??????</a><br /><br />
                                  ???????????? 1                 :<a href=""#"" class=""btn btn-primary btn-sm"">??????</a><br /><br />
                                  ???????????? 2                 :<a href=""#"" class=""btn btn-primary btn-sm"">??????</a><br /><br />
                              </p>
                        </div>
                    </div>
                </div>
            </div>
      
        </div>
    </div>
    <div id=""narrow"">
        <div class=""card card-custom mx-2 mb-3"">
            <div class=""card-body"">
                <p class=""card-text"">");
#nullable restore
#line 117 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\PassportRegistration\Index.cshtml"
                                Write(DateTime.Now.DayOfWeek);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <a href=""#"" class=""card-link"">Card link</a>
                <a href=""#"" class=""card-link"">Another link</a>
            </div>
        </div>
        <div class=""card card-custom mx-2 mb-3"">
            <div class=""card-body"">
                <h5 class=""card-title""></h5>
                <h6 class=""card-subtitle mb-2 text-muted"">Card subtitle</h6>
                <a href=""#"" class=""card-link"">Card link</a>
                <a href=""#"" class=""card-link"">Another link</a>
            </div>
        </div>
        <div class=""card card-custom mx-2 mb-3"">
            <div class=""card-body"">
            </div>
        </div>
    </div>
</div>



");
            WriteLiteral("\r\n<script>\r\n    $(\'#bologna-list a\').on(\'click\', function (e) {\r\n        e.preventDefault()\r\n        $(this).tab(\'show\')\r\n    })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GloableCommunication.DbModels.TraineeHistory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
