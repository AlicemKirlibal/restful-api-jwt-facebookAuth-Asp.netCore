#pragma checksum "C:\Users\ASUS\Desktop\TweetBook\TweetBook.Web\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1121a66d544aef4341bb45750450782b2766c53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TweetBook.Web.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(TweetBook.Web.Pages.Pages_Index), null)]
namespace TweetBook.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ASUS\Desktop\TweetBook\TweetBook.Web\Pages\_ViewImports.cshtml"
using TweetBook.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1121a66d544aef4341bb45750450782b2766c53", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2133cde10455a4137190c3bf031e20fa06b0bc57", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\ASUS\Desktop\TweetBook\TweetBook.Web\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 275, true);
            WriteLiteral(@"
    <div class=""text-center"">
        <h1 class=""display-4"">Welcome</h1>

        <fb:login-button scope=""public_profile,email""
                         onlogin=""checkLoginState();"">
        </fb:login-button>


        <div id=""authstatus""></div>

    </div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(365, 905, true);
                WriteLiteral(@"


    <script>
        window.fbAsyncInit = function () {
            FB.init({
                appId: '309425530062699',
                cookie: true,
                xfbml: true,
                version: 'v7.0'
            });

            FB.AppEvents.logPageView();

        };

        (function (d, s, id) {
            var js, fjs = d.getElementsByTagName(s)[0];
            if (d.getElementById(id)) { return; }
            js = d.createElement(s); js.id = id;
            js.src = ""https://connect.facebook.net/en_US/sdk.js"";
            fjs.parentNode.insertBefore(js, fjs);
        }(document, 'script', 'facebook-jssdk'));

        function checkLoginState() {

            FB.getLoginStatus(function (response) {
                $(""#authstatus"").html(""<code>"" + JSON.stringify(response, null, 2) + ""</code>"");
            });
        }



    </script>


");
                EndContext();
            }
            );
            BeginContext(1273, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591