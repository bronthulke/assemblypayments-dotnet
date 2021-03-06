using Newtonsoft.Json;
using AssemblyPaymentsDotNet.DTO;
using AssemblyPaymentsDotNet.Interfaces;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System;
using AssemblyPaymentsDotNet.Exceptions;

namespace AssemblyPaymentsDotNet.Implementations
{
    public class CardAccountRepository : AbstractRepository, ICardAccountRepository
    {
        public CardAccountRepository(IRestClient client) : base(client)
        {
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #region public methods

        public CardAccount GetCardAccountById(string cardAccountId)
        {
            AssertIdNotNull(cardAccountId);
            var request = new RestRequest("/card_accounts/{id}", Method.GET);
            request.AddUrlSegment("id", cardAccountId);
            var response = SendRequest(Client, request);
            return JsonConvert.DeserializeObject<IDictionary<string, CardAccount>>(response.Content).Values.First();
        }

        public CardAccount CreateCardAccount(CardAccount cardAccount)
        {
            ValidateCreateCardAccount(cardAccount);

            var request = new RestRequest("/card_accounts", Method.POST);
            request.AddParameter("user_id", cardAccount.UserId);
            request.AddParameter("currency", cardAccount.Currency);
            request.AddParameter("full_name", cardAccount.Card.FullName);
            request.AddParameter("number", cardAccount.Card.Number);
            request.AddParameter("expiry_month", cardAccount.Card.ExpiryMonth);
            request.AddParameter("expiry_year", cardAccount.Card.ExpiryYear);
            request.AddParameter("cvv", cardAccount.Card.CVV);

            var response = SendRequest(Client, request);
            return JsonConvert.DeserializeObject<IDictionary<string, CardAccount>>(response.Content).Values.First();
        }

        public bool DeleteCardAccount(string cardAccountId)
        {
            AssertIdNotNull(cardAccountId);
            var request = new RestRequest("/card_accounts/{id}", Method.DELETE);
            request.AddUrlSegment("id", cardAccountId);
            var response = SendRequest(Client, request);
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return false;
            }
            return true;
        }

        public User GetUserForCardAccount(string cardAccountId)
        {
            AssertIdNotNull(cardAccountId);
            var request = new RestRequest("/card_accounts/{id}/users", Method.GET);
            request.AddUrlSegment("id", cardAccountId);
            IRestResponse response = SendRequest(Client, request);

            var dict = JsonConvert.DeserializeObject<IDictionary<string, object>>(response.Content);
            if (dict.ContainsKey("users"))
            {
                var item = dict["users"];
                return JsonConvert.DeserializeObject<User>(JsonConvert.SerializeObject(item));
            }
            return null;
        }

        public CardAccount VerifyCard(string cardId)
        {
            AssertIdNotNull(cardId);

            var request = new RestRequest("/card_accounts/{id}/verify", Method.PATCH);
            request.AddUrlSegment("id", cardId);

            var response = SendRequest(Client, request);
            return JsonConvert.DeserializeObject<IDictionary<string, CardAccount>>(response.Content).Values.First();
        }


        #endregion

        #region private methods

        private void ValidateCreateCardAccount(CardAccount cardAccount)
        {
            if (String.IsNullOrEmpty(cardAccount.UserId))
            {
                throw new ValidationException("Field UserId should not be empty");
            }
        }

        #endregion
    }
}
