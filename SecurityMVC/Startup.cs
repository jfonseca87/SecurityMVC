using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace SecurityMVC
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "SecurityAppCookie",
                LoginPath = new PathString("/home/index"),
                ExpireTimeSpan = System.TimeSpan.FromMinutes(1)
            });
        }
    }
}