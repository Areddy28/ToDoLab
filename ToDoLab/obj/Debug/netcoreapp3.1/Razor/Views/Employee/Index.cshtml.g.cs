#pragma checksum "C:\Users\areddy1\source\repos\ToDoLab\ToDoLab\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fc94957caf952096cd4ef15b5cec0100c508fee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\areddy1\source\repos\ToDoLab\ToDoLab\Views\_ViewImports.cshtml"
using ToDoLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\areddy1\source\repos\ToDoLab\ToDoLab\Views\_ViewImports.cshtml"
using ToDoLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc94957caf952096cd4ef15b5cec0100c508fee", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38895ae104045b5562e885e7b9da8d45977f7d79", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeTaskViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\areddy1\source\repos\ToDoLab\ToDoLab\Views\Employee\Index.cshtml"
 foreach (Employee e in Model.Employees)

{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 6 "C:\Users\areddy1\source\repos\ToDoLab\ToDoLab\Views\Employee\Index.cshtml"
  Write(e.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 7 "C:\Users\areddy1\source\repos\ToDoLab\ToDoLab\Views\Employee\Index.cshtml"
  Write(e.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 8 "C:\Users\areddy1\source\repos\ToDoLab\ToDoLab\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>-------------------------------------</p>\r\n<h2>Tasks</h2>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\areddy1\source\repos\ToDoLab\ToDoLab\Views\Employee\Index.cshtml"
 foreach (ToDo t in Model.ToDos)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 14 "C:\Users\areddy1\source\repos\ToDoLab\ToDoLab\Views\Employee\Index.cshtml"
  Write(t.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 15 "C:\Users\areddy1\source\repos\ToDoLab\ToDoLab\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeTaskViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
