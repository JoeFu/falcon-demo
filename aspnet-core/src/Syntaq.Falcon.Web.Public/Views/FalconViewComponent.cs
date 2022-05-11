using Abp.AspNetCore.Mvc.ViewComponents;

namespace Syntaq.Falcon.Web.Public.Views
{
    public abstract class FalconViewComponent : AbpViewComponent
    {
        protected FalconViewComponent()
        {
            LocalizationSourceName = FalconConsts.LocalizationSourceName;
        }
    }
}