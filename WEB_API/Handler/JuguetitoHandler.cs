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
        private const string Origin = "Origin";
        private const string Xvueling = "X-vueling";
        private static void AddCorsResponseHeaders(HttpRequestMessage request, HttpResponseMessage response)
        {
            var Value = 2 * int.Parse(request.Headers.GetValues(Xvueling).First());
            response.Headers.Add(Xvueling, Value.ToString());
        }

        protected override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
        {
            return request.Headers.Contains(Xvueling) ?
                ProcessCorsRequest(request, ref cancellationToken) :
                base.SendAsync(request, cancellationToken);
        }

        private Task<HttpResponseMessage> ProcessCorsRequest(HttpRequestMessage request, ref CancellationToken cancellationToken)
        {
            if (request.Method == HttpMethod.Options)
            {
                return Task.Factory.StartNew(
                    () =>
                    {
                        var response = new HttpResponseMessage(HttpStatusCode.OK);
                        AddCorsResponseHeaders(request, response);
                        return response;
                    },
                    cancellationToken);
            }

            return base.SendAsync(request, cancellationToken).ContinueWith(
                task =>
                {
                    var resp = task.Result;
                    var Value = request.Headers.GetValues(Origin).First();
                    resp.Headers.Add(Xvueling, Value);
                    return resp;
                },
                cancellationToken);
        }
    }
}