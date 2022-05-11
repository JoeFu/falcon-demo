using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Syntaq.Falcon.Web.Public.Views
{
    public abstract class FalconRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected FalconRazorPage()
        {
            LocalizationSourceName = FalconConsts.LocalizationSourceName;
        }
    }
}
