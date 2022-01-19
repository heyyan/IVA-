namespace SearchApp.Handler
{
    public class AuthenticatedHttpClientHandler: DelegatingHandler
    {
        public AuthenticatedHttpClientHandler()
        {

        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            try
            {
                request.Headers.Add("Accept", "application/json");

                request.Headers.Add("Ocp-Apim-Subscription-Key", "67aa73003f874dce93f31e223020f8d1");

                var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception ex)
            {

                throw;
            }
          
        }
    }
}
