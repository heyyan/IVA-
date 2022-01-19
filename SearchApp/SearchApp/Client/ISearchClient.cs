using Refit;
using SearchApp.Models;

namespace SearchApp.Client
{
    public interface ISearchClient
    {
        [Get("/api/entertainment/Search/?Skip=0&Take=10&ModifiedRecordsSince=2018-06-11%2004:05%20PM&Includes=Releases,Videos&ProgramTypes=Movie,Show&subscription-key=67aa73003f874dce93f31e223020f8d1")]
        Task<SearchResults> GetSearchResults();
    }
}


////[Headers("X-API-Key: fe0c51a5eb23865dde664c716484fbb5")]
//public interface IGlobitexApi
//{
//    [Post("/api/1/eurowallet/payments")]
//    Task<NewPaymentResponse> NewPayment([Query] NewPaymentRequest request);

//    [Get("/api/1/eurowallet/status")]
//    Task<AccountResponse> GetAccountStatus(AccountStatusRequest accountStatus);

//    [Get("/api/1/eurowallet/deposit-details")]
//    Task<DepositDetailsResponse> GetDepositDetails();

//    [Get("/api/1/eurowallet/payments/history")]
//    Task<Payment> GetNexpayPaymentHistory(HistoryRequest input);

//    [Get("/api/1/eurowallet/payments/status")]
//    Task<NewPaymentResponse> GetPaymentStatus(PaymentStatusRequest statusRequest);

//}