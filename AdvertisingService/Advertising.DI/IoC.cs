using Advertising.Dal.DataAccess;
using Advertising.Dal.DataAccess.Interfaces;
using Advertising.Dal.Repositories;
using Advertising.Dal.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Advertising.DI
{
    static public class IoC
    {
        static public void IoCCommonRegister(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDataAccess, DataAccess>();
            services.AddTransient<IAdvertisingRepository, AdvertisingRepository>();
            services.AddTransient<IAdvertisingCategoryRepository, AdvertisingCategoryRepository>();

            //services.AddTransient<IBusinessLogic, BusinessLogic>();
            //services.AddTransient<INoteEntityService, NoteEntityService>();
            //services.AddTransient<INoteCategoryService, NoteCategoryService>();
            //services.AddTransient<INoteSortService, SortService>();
        }
    }
}
