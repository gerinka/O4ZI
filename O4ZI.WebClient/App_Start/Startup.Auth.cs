using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace O4ZI.WebClient
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Enable the application to use a cookie to store information for the signed in user
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
            // Use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Uncomment the following lines to enable logging in with third party login providers
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            app.UseTwitterAuthentication(
               consumerKey: "oXLbPrlOhG4Z37AnuO03w",
               consumerSecret: "vu2EZ8zNUxeEpUUdoiTRG55e8Gfb4MIW1JDGEoklpQ");

            app.UseFacebookAuthentication(
               appId: "361910163871940",
               appSecret: "bba585f61f4897aee00b8e11e0bc887f");

            app.UseGoogleAuthentication();
        }
    }
}