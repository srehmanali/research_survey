#pragma checksum "C:\Users\Ali\source\repos\ResearchSurvey\ResearchSurvey\WebApp\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e20ff6a276762fc80304e5f5eb1601dfd60ca72a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\Ali\source\repos\ResearchSurvey\ResearchSurvey\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ali\source\repos\ResearchSurvey\ResearchSurvey\WebApp\Views\_ViewImports.cshtml"
using CoreDomain.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e20ff6a276762fc80304e5f5eb1601dfd60ca72a", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af654c6d120b3dcddaa71c082a92187db88a1097", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/moment.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ali\source\repos\ResearchSurvey\ResearchSurvey\WebApp\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link href=\"https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css\" rel=\"stylesheet\" />\r\n");
            WriteLiteral(@"
<script src=""https://cdn.datatables.net/1.11.3/js/jquery.dataTables.min.js ""></script>
<script src=""https://cdn.datatables.net/1.10.15/js/dataTables.bootstrap4.min.js ""></script>
<script src=""https://cdn.datatables.net/buttons/2.0.1/js/dataTables.buttons.min.js ""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js ""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/pdfmake.min.js ""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/vfs_fonts.js ""></script>
<script src=""https://cdn.datatables.net/buttons/2.0.1/js/buttons.html5.min.js ""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e20ff6a276762fc80304e5f5eb1601dfd60ca72a4603", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div>
    <table id=""tbldata"" class=""table"">
        <thead>
            <tr>
                <th>Username</th>
                <th>StartTime</th>
                <th>EndTime</th>
                <th>Captured Latitude</th>
                <th>Captured Longitude</th>
                <th>SurveyStatus</th>
                <th>O1</th>
                <th>Q1</th>
                <th>Q2</th>
                <th>Q3</th>
                <th>Q4</th>
                <th>Q5</th>
                <th>Q6</th>
                <th>Q7</th>
                <th>Q8</th>
                <th>Q9</th>
                <th>Q10</th>
                <th>Q11</th>
                <th>Q12</th>
                <th>Q13</th>
                <th>Q14</th>
                <th>Q15</th>
                <th>Q16</th>
                <th>Q17</th>
                <th>Q18</th>
                <th>Q19</th>
                <th>Q20</th>
                <th>Q21</th>
                <th>Q22</th>
                <th>Q23</");
            WriteLiteral("th>\r\n                <th>Q24</th>\r\n                <th>CreateDate</th>\r\n                <th>AssignedLocation</th>\r\n");
            WriteLiteral(@"
            </tr>
        </thead>
    </table>
</div>
<script type=""text/javascript"">
    $(function () {
        $.ajax({
            type: ""POST"",
            url: ""/Admin/AjaxMethod"",
            data: '{}',
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: OnSuccess,
            failure: function (response) {
                alert(response.d);
            },
            error: function (response) {
                alert(response.d);
            }
        });
    });
    function OnSuccess(response) {
        $(""#tbldata"").DataTable(
            {
                dom: 'Blfrtip',
                buttons: [
                    'excelHtml5'
                ],
                scrollX: true,
                bLengthChange: true,
                lengthMenu: [[5, 10, -1], [5, 10, ""All""]],
                bFilter: true,
                bSort: true,
                bPaginate: true,
                data: response,
     ");
            WriteLiteral(@"           columns:
                    [
                        { 'data': 'username', ""name"": ""username"", ""autoWidth"": true },
                        {
                            'data': 'startTime',
                            render: function (sqlDate) {
                                return moment(sqlDate).add(4, 'hours').format('HH:mm:ss')
                            },
                            ""name"": ""startTime"",
                            ""autoWidth"": true
                        },
                        {
                            'data': 'endTime',
                            render: function (sqlDate) {
                                return moment(sqlDate).add(4, 'hours').format('HH:mm:ss')
                            },
                            ""name"": ""endTime"",
                            ""autoWidth"": true
                        },
                        {
                            'data': 'latLong',
                            render: function (data) {
");
            WriteLiteral(@"                                if (data == null)
                                    return data
                                var result = data.split(',')[0]
                                return result
                            },
                            ""name"": ""Captured Latitude"", ""autoWidth"": true
                        },
                        {
                            'data': 'latLong',
                            render: function (data) {
                                if (data == null)
                                    return data
                                var result = data.split(',')[1]
                                return result
                            }, ""name"": ""Captured Longitude"", ""autoWidth"": true
                        },
                        { 'data': 'surveyStatus', ""name"": ""SurveyStatus"", ""autoWidth"": true },
                        { 'data': 'o1', ""name"": ""o1"", ""autoWidth"": true },
                        { 'data': 'q1', ""name"": ""q1"", ");
            WriteLiteral(@"""autoWidth"": true },
                        { 'data': 'q2', ""name"": ""q2"", ""autoWidth"": true },
                        { 'data': 'q3', ""name"": ""q3"", ""autoWidth"": true },
                        { 'data': 'q4', ""name"": ""q4"", ""autoWidth"": true },
                        { 'data': 'q5', ""name"": ""q5"", ""autoWidth"": true },
                        { 'data': 'q6', ""name"": ""q6"", ""autoWidth"": true },
                        { 'data': 'q7', ""name"": ""q7"", ""autoWidth"": true },
                        { 'data': 'q8', ""name"": ""q8"", ""autoWidth"": true },
                        { 'data': 'q9', ""name"": ""q9"", ""autoWidth"": true },
                        { 'data': 'q10', ""name"": ""q10"", ""autoWidth"": true },
                        { 'data': 'q11', ""name"": ""q11"", ""autoWidth"": true },
                        { 'data': 'q12', ""name"": ""q12"", ""autoWidth"": true },
                        { 'data': 'q13', ""name"": ""q13"", ""autoWidth"": true },
                        { 'data': 'q14', ""name"": ""q14"", ""autoWidth"": true },
    ");
            WriteLiteral(@"                    { 'data': 'q15', ""name"": ""q15"", ""autoWidth"": true },
                        { 'data': 'q16', ""name"": ""q16"", ""autoWidth"": true },
                        { 'data': 'q17', ""name"": ""q17"", ""autoWidth"": true },
                        { 'data': 'q18', ""name"": ""q18"", ""autoWidth"": true },
                        { 'data': 'q19', ""name"": ""q19"", ""autoWidth"": true },
                        { 'data': 'q20', ""name"": ""q20"", ""autoWidth"": true },
                        { 'data': 'q21', ""name"": ""q21"", ""autoWidth"": true },
                        { 'data': 'q22', ""name"": ""q22"", ""autoWidth"": true },
                        { 'data': 'q23', ""name"": ""q23"", ""autoWidth"": true },
                        { 'data': 'q24', ""name"": ""q24"", ""autoWidth"": true },
                        {
                            'data': 'createDate',
                            render: function (sqlDate) {
                                return moment(sqlDate).add(4, 'hours').format('DD MMM YYYY')
                  ");
            WriteLiteral(@"          },
                            ""name"": ""createDate"",
                            ""autoWidth"": true
                        },
                        { 'data': 'assignedLocation', ""name"": ""AssignedLocation"", ""autoWidth"": true }
                        //{
                        //    'data': 'assignedLocationLatLong',
                        //    render: function (data) {
                        //        if (data == null)
                        //            return data
                        //        var result = data.split(',')[0]
                        //        return result
                        //    }, ""name"": ""Assigned Location Latitude"", ""autoWidth"": true
                        //},
                        //{
                        //    'data': 'assignedLocationLatLong',
                        //    render: function (data) {
                        //        if (data == null)
                        //            return data
                        //       ");
            WriteLiteral(@" var result = data.split(',')[1]
                        //        return result
                        //    }, ""name"": ""Assigned Location Longitude"", ""autoWidth"": true
                        //}
                    ]
            });
    };
</script>





");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
