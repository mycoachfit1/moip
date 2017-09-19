using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoipClient.OAuth;

namespace MoipClient.MoipAccounts
{
    public class MoipAccountsApi : OauthAutenticationApiCaller
    {
        public MoipAccountsApi(Uri apiUri, GenerateTokenResponse token) : base(apiUri, token)
        {
        }

        /// <summary>
        /// Chamada Sincrona da API <see href="https://dev.moip.com.br/v2.0/reference#criar-conta-moip">Por meio desta API é possível criar uma Conta no Moip.</see> 
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public MoipAccountsApiCreateAccountResponse CreateAccount(MoipAccountsApiCreateAccountRequest request)
        {
            return DoPost<MoipAccountsApiCreateAccountRequest, MoipAccountsApiCreateAccountResponse>(new Uri(ApiUri, "v2/accounts"), request);
        }



        /// <summary>
        /// Chamada Sincrona da API <see href="https://dev.moip.com.br/v2.0/reference#criar-conta-moip">Por meio desta API é possível criar uma Conta no Moip.</see> 
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public MoipAccountsApiGetAccountResponse GetAccount(string idAccount)
        {
            return DoGet<MoipAccountsApiGetAccountResponse>(new Uri(ApiUri, "v2/accounts/" + idAccount));
        }


    }
    public class MoipAccountsApiGetAccountResponse
    {
        public string Id { get; set; }
        public string ChanelId { get; set; }
        public string externalId { get; set; }

        public string login { get; set; }
        public TypeMoipAccount Type { get; set; }
        public bool transparentAccount { get; set; }
        public DateTime createdAt { get; set; }
        public MoipAccountsApiCreateAccountRequestPerson Person { get; set; }
        public MoipAccountsApiCreateAccountResponseEmail Email { get; set; }

    }


    public class MoipAccountsApiCreateAccountResponse
    {
        public string Id { get; set; }
        public string ChanelId { get; set; }
        public string login { get; set; }
        public TypeMoipAccount Type { get; set; }
        public bool transparentAccount { get; set; }
        public DateTime createdAt { get; set; }
        public MoipAccountsApiCreateAccountRequestPerson Person { get; set; }
        public MoipAccountsApiCreateAccountResponseEmail Email { get; set; }

    }

    public class MoipAccountsApiCreateAccountResponseEmail
    {
        /// <summary>
        /// OBRIGATÓRIO Endereço de email da conta. Será usado como login.
        /// </summary>
        public string Address { get; set; }
        public bool confirmed { get; set; }
    }

    public class MoipAccountsApiCreateAccountRequest
    {
        /// <summary>
        /// E-mail da conta.
        /// </summary>
        public MoipAccountsApiCreateAccountRequestEmail Email { get; set; }
        public MoipAccountsApiCreateAccountRequestPerson Person { get; set; }
    }

    public class MoipAccountsApiCreateAccountRequestPerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string nationality { get; set; }
        public string birthPlace { get; set; }
        public TypeMoipAccount Type { get; set; }
        public MoipAccountsApiCreateAccountRequestPersonIdentityDocument identityDocument { get; set; }
        public DocumentDto TaxDocument { get; set; }
        public PhoneDto Phone { get; set; }
        public AddressDto Address { get; set; }
    }

    public enum TypeMoipAccount
    {
        CONSUMER,
        MERCHANT
    }

    public class MoipAccountsApiCreateAccountRequestPersonIdentityDocument
    {
        public string type { get; set; }
        public string number { get; set; }
        public string issuer { get; set; }
        public string issueDate { get; set; }

    }

    public class MoipAccountsApiCreateAccountRequestEmail
    {
        /// <summary>
        /// OBRIGATÓRIO Endereço de email da conta. Será usado como login.
        /// </summary>
        public string Address { get; set; }
    }
}
