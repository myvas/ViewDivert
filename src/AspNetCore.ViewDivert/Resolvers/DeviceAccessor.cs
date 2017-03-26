﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.ViewDivertMiddleware
{
    public class DeviceAccessor : IDeviceAccessor
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IDeviceResolver _deviceResolver;
        private readonly ISitePreferenceStore _repository;

        public DeviceAccessor(
            ISitePreferenceStore repository,
            IHttpContextAccessor contextAccessor,
            IDeviceResolver deviceResolver)
        {
            _repository = repository;
            _contextAccessor = contextAccessor;
            _deviceResolver = deviceResolver;
        }

        public string Device => _deviceResolver.Resolve(_contextAccessor.HttpContext);
        public string Preference => _repository.LoadPreference(_contextAccessor.HttpContext);
    }
}
