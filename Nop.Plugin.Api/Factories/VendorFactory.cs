using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Domain.Vendors;

namespace Nop.Plugin.Api.Factories
{
    public class VendorFactory:IFactory<Vendor>
    {
        public Task<Vendor> InitializeAsync()
        {
            var defaultVendor = new Vendor()
            {
                Active = true,
                Deleted = false
            };
            return Task.FromResult(defaultVendor);
        }
    }
}
