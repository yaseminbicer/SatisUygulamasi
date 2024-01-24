using HizliSatis.Application.Abstractions;
using HizliSatis.Persistence.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Application.MiddleWares
{
    
    
    public class ServiceMiddleWare
    {
        RequestDelegate _next;

        //bir sonraki next edeceğimiz middleware’i ilk önce requestdelegate ile karşılarız.
        public ServiceMiddleWare(RequestDelegate next)
        { 
            _next = next;
        }

        //bu method middlewareden bir önceki middleware’in şuanki operasyonumu tetikleyebilmesi için o delegate'e uygun bir imza oluşturur.
        public async Task Invoke(HttpContext httpContext) 
        { 
           
            Console.WriteLine("");

            await _next.Invoke(httpContext); 

            Console.WriteLine("");
        }
       
    }
}
