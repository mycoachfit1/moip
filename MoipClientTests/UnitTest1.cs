using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoipClient;
using MoipClient.OAuth;

namespace MoipClientTests
{


    public class BaseApiIntegratedTests
    {
        public Uri BaseUrl { get { return new Uri("https://sandbox.moip.com.br"); } }
        public string apiToken { get { return "Z18HAHMDA3HYLZ95GALXN9KNHUSE7VEX"; } }
        public string apiKey { get { return "GUNIQEBNA7HUEN9HICLONMQN2DXY0HBZB0XVC1SY"; } }


    }

    [TestClass]
    public class OrderApiTests : BaseApiIntegratedTests
    {
        [TestMethod]
        public void OrderApi_CreateOrder()
        {
            OrdersApi api = new OrdersApi(BaseUrl, apiToken, apiKey);

            CreateOrdersRequest req = new CreateOrdersRequest();
            req.Amount = new AmountsCreateOrdersRequest()
            {
                Currency = CurrencyType.BRL,
                Subtotals = new TotaisAmountsCreateOrdersRequest()
                {
                    Shipping = 0
                }
            };
            string idCliente = "CUS-1IO9IR204YI4";
            req.Customer = new ClienteCreateOrdersRequest(idCliente);
            req.Items = new System.Collections.Generic.List<OrderItemCreateOrdersRequest>();
            req.Items.Add(new OrderItemCreateOrdersRequest()
            {
                Detail = "Detalhe Produto de teste ",
                Price = 100,
                Product = "Produto de teste ",
                Quantity = 1
            });
            req.OwnId = "231";
            req.Receivers = new System.Collections.Generic.List<ReceiverCreateOrdersRequest>();
            req.Receivers.Add(new ReceiverCreateOrdersRequest()
            {
                Type = ReceiverType.PRIMARY,
                Amount = new AmountReceiverCreateOrdersRequest()
                {
                    Percentual = 100,
                    ValueFixed = 100
                },
                FeePayor = false,
                moipAccount = new MoipAccountReceiverCreateOrdersRequest()
                {
                    Id = "0212"
                }
            });

            var retorno = api.CreateOrder(req);
        }
    }

    [TestClass]
    public class CustomersApiTests : BaseApiIntegratedTests
    {
        [TestMethod]
        public void CustomersApi_CreateCustomer()
        {
            CustomersApi api = new CustomersApi(BaseUrl, apiToken, apiKey);

            CreateCustomersRequest req = new CreateCustomersRequest();
            req.BirthDate = DateTime.Today.AddYears(-30);
            req.Email = "teste_cliente@moipNet4.com";
            req.Fullname = "Teste moip client 4";
            req.OwnId = "3";
            req.Phone = new PhoneDto()
            {
                AreaCode = 11,
                CountryCode = 55,
                Number = 98985959
            };
            req.ShippingAddress = new AddressDto()
            {
                City = "Sao Paulo",
                Complement = "A",
                Country = "BR",
                District = "SP",
                State = "SP",
                Street = "Sao paullo",
                StreetNumber = "12",
                ZipCode = "09090170"
            };
            req.TaxDocument = new DocumentDto()
            {
                Number = "95672830013",
                Type = DocumentType.CPF
            };



            var retorno = api.CreateCustomer(req);
            Assert.IsNotNull(retorno);
            Assert.IsNotNull(retorno.Id);
        }

        [TestMethod]
        public void CustomersApi_AddCreditCard()
        {
            CustomersApi api = new CustomersApi(BaseUrl, apiToken, apiKey);

            string idcliente = "CUS-1IO9IR204YI4";
            AddCreditCardRequest request = new AddCreditCardRequest();
            request.Method = MethodType.CREDIT_CARD;
            request.CreditCard = new CreditCardAddCreditCardRequest()
            {
                Cvc = 546,
                ExpirationMonth = 9,
                ExpirationYear = 2018,
                Holder = new HolderDto()
                {
                    Birthdate = DateTime.Now.AddYears(-25),
                    Fullname = "TESTE MOIP NET",
                    Phone = new PhoneDto()
                    {
                        AreaCode = 11,
                        CountryCode = 55,
                        Number = 98985959
                    },
                    TaxDocument = new DocumentDto()
                    {
                        Number = "95672830013",
                        Type = DocumentType.CPF
                    }
                },
                Number = "4556832098622729"
            };

            var retorno = api.AddCreditCard(idcliente, request);
            Assert.IsNotNull(retorno);
            Assert.IsNotNull(retorno.Id);
        }
    }

    [TestClass]
    public class OAuthAPITestes : BaseApiIntegratedTests
    {
        [TestMethod]
        public void OAuthAPITestes_CreateCustomer()
        {
            OAuthAPI api = new OAuthAPI(BaseUrl, apiToken, apiKey);

        }

    }

}
