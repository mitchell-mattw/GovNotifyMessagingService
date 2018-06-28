using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessagingService.Models
{
    public class TemplateOptions
    {
        public string EmailAddress { get; set; }
        //public string ProviderName { get; set; }
        public string ServiceType { get; set; }

        public string NotifyScheme { get; set; }

        public Dictionary<string, dynamic> Personalisation { get; set; }

    }
}
