using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Web;
using WEB_API.App_Start;

namespace WEB_API.Handler
{
    public class HandlerConfig
    {
        public static void RegisterHandlers(Collection<DelegatingHandler> handlers)
        {
            handlers.Add(new CorsMessageHandler());
            handlers.Add(new AuthorizeHandler());    
            handlers.Add(new JuguetitoHandler());
        }
    }
}