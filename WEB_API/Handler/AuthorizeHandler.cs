using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Threading;
using System.Web;

namespace WEB_API.Handler
{
    public class OAuthIdentity : IIdentity
    {

        public string AuthenticationType
        {
            get { return "Tiene que implementar autenticacion Beader"; }
        }

        public bool IsAuthenticated
        {
            get { return true; }
        }

        public string Name
        {
            get { return "Andres"; }
        }
    }
    public class OAuthAuthorize : IPrincipal
    {

        public IIdentity Identity
        {
            get { return new OAuthIdentity(); }
        }

        public bool IsInRole(string role)
        {
            return true;
        }
    }
    public class AuthorizeHandler   : DelegatingHandler
    {
        protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            Thread.CurrentPrincipal = new OAuthAuthorize();
            return base.SendAsync(request, cancellationToken);
        }
    }
}