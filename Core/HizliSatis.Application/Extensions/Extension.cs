using HizliSatis.Application.MiddleWares;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Application.Extensions
{
     public static class Extension
    {
        //Servicemiddleware'i sisteme extension olarak dahil ettik.
        public static IApplicationBuilder UseServiceMiddleware(this IApplicationBuilder applicationBuilder) 
        {
            return applicationBuilder.UseMiddleware<ServiceMiddleWare>();
        }
    }
}
