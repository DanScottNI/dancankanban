using System.Web;
using System.Web.Configuration;
using DanCanKanBan.Services.Interfaces;

namespace DanCanKanBan.Services.Configuration
{
    public class WebConfigurationSettings : IConfigurationSettings
    {
        private HttpContextWrapper Context
        {
            get
            {
                if (HttpContext.Current != null)
                {
                    return new HttpContextWrapper(HttpContext.Current);
                }

                return null;
            }
        }

        public ApplicationSettings Settings
        {
            get
            {
                if (!(this.HasSettings()) && (Context.Application["app_settings"] as ApplicationSettings != null))
                {
                    this.Load();
                }

                return this.Context.Application["app_settings"] as ApplicationSettings;
            }

            set
            {
                if (Context != null)
                {
                    this.Context.Application["app_settings"] = value;
                }
            }
        }

        public bool HasSettings()
        {
            return this.Context.Application["app_settings"] != null;
        }

        public void Load()
        {
            ApplicationSettings settings = new ApplicationSettings();

            settings.LdapRootPath = WebConfigurationManager.AppSettings["LDAPPath"];

            this.Settings = settings;
        }
    }
}
