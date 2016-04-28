using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WEB_API.Handler
{
    public class JuguetitoHandler : DelegatingHandler
    {
        private const string Xvueling = "X-vueling";
        protected override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
        {
            var Value = 2 * int.Parse(request.Headers.GetValues(Xvueling).First());
            return base.SendAsync(request, cancellationToken).ContinueWith<HttpResponseMessage>(t => { HttpResponseMessage resp = t.Result; resp.Headers.Add(Xvueling, Value.ToString()); return resp; });
        }
    }
}