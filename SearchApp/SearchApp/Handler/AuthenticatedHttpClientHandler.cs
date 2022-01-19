namespace SearchApp.Handler
{
    public class AuthenticatedHttpClientHandler: DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Ocp-Apim-Subscription-Key", "67aa73003f874dce93f31e223020f8d1");
            request.Headers.Add("Content-Type", "application/json");

            var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            return response;
        }
    }
}
