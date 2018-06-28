using System.Collections.Generic;

namespace MessagingService.Models.GovNotify
{
    public class GovNotifySettings
    {
        public string Apikey { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public List<ServiceApp> ServiceApps { get; set; }
    }
}
