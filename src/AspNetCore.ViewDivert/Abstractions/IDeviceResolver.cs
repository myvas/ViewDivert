﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AspNetCore.ViewDivertMiddleware
{

    public interface IDeviceResolver
    {
        /// <summary>
        /// Resolve the code of device from <see cref="HttpContext"/> 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        string Resolve(HttpContext context);
    }
}
