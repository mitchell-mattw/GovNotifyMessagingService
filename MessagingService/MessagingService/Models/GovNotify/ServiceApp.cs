using System.Collections.Generic;

namespace MessagingService.Models.GovNotify
{
    public class ServiceApp
    {
        public string Service { get; set; }

        public string Description { get; set; }
        public List<NotifyScheme> NotifySchemes { get; set; }

    }



   
}
