using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertisingService.Models
{
    public class ApplicationSettings
    {
        public string JWT_secret { get; set; }

        public string ClientURL { get; set; }
    }
}
