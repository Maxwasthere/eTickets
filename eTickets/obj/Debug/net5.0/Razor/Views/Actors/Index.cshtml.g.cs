#pragma checksum "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "49f6255bc46e27446857255218fbe7c946e7fe19a4877927f123133c3a467e2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actors_Index), @"mvc.1.0.view", @"/Views/Actors/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\_ViewImports.cshtml"
using eTickets

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\_ViewImports.cshtml"
using eTickets.Models

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"49f6255bc46e27446857255218fbe7c946e7fe19a4877927f123133c3a467e2e", @"/Views/Actors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"48ab8149bad7b492e03955c9acc9bec78dc1ad29f50faaea1eedae17cc91aa5f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Actors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Actor>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
  
    ViewData["Title"] = "List of Actors";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-8 offset-md-2\">\n        <table class=\"table\">\n            <thead>\n                <tr class=\"text-center\">\n                    <th>");
            Write(
#nullable restore
#line 12 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                         Html.DisplayNameFor(model => model.ProfilePictureURL)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\n                    <th>");
            Write(
#nullable restore
#line 13 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                         Html.DisplayNameFor(model => model.FullName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\n                    <th>");
            Write(
#nullable restore
#line 14 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                         Html.DisplayNameFor(model => model.Bio)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\n");
#nullable restore
#line 15 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <th>Actions</th>\n");
#nullable restore
#line 18 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable

            WriteLiteral("                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 22 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <tr>\n                    <td class=\"align-middle\">\n                        <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 863, "\"", 892, 1);
            WriteAttributeValue("", 869, 
#nullable restore
#line 26 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                                                          item.ProfilePictureURL

#line default
#line hidden
#nullable disable
            , 869, 23, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 893, "\"", 913, 1);
            WriteAttributeValue("", 899, 
#nullable restore
#line 26 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                                                                                        item.FullName

#line default
#line hidden
#nullable disable
            , 899, 14, false);
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\" />\n                    </td>\n                    <td class=\"align-middle\">\n                        ");
            Write(
#nullable restore
#line 29 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                         Html.DisplayFor(modelItem => item.FullName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                    </td>\n                    <td class=\"align-middle\">\n                        ");
            Write(
#nullable restore
#line 32 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                         Html.DisplayFor(modelItem => item.Bio)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                    </td>\n");
#nullable restore
#line 34 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <td class=\"align-middle\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49f6255bc46e27446857255218fbe7c946e7fe19a4877927f123133c3a467e2e10326", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\"></i>Edit ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 37 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                                                                                                item.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49f6255bc46e27446857255218fbe7c946e7fe19a4877927f123133c3a467e2e12757", async() => {
                WriteLiteral("<i class=\"bi bi-eye\"></i>Details ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 38 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                                                                                                item.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49f6255bc46e27446857255218fbe7c946e7fe19a4877927f123133c3a467e2e15181", async() => {
                WriteLiteral("<i class=\"bi bi-trash\"></i>Delete ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 39 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                                                                                                    item.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </td>\n");
#nullable restore
#line 41 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable

            WriteLiteral("                </tr>\n");
#nullable restore
#line 43 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </tbody>\n        </table>\n\n    </div>\n</div>\n\n");
            Write(
#nullable restore
#line 50 "C:\Users\Max\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Actors\Index.cshtml"
 await Html.PartialAsync("_CreateItem", "Actors")

#line default
#line hidden
#nullable disable
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Actor>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
