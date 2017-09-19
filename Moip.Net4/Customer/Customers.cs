using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moip.Net4
{


    public enum BrandType
    {
        VISA,
        MASTERCARD,
        AMEX,
        DINERS,
        ELO,
        HIPER,
        HIPERCARD
    }
    public enum DocumentType
    {
        CPF,
        CNPJ
    }
    public enum MethodType
    {
        CREDIT_CARD,
        BOLETO,
        ONLINE_DEBIT,
        WALLET,
        MOIP_ACCOUNT
    }

    /// <summary>
    /// <see href="https://dev.moip.com.br/v2.0/reference#lista-de-status-possiveis-pedido">Documentação</see> 
    /// </summary>
    public enum OrderStatusType
    {
        /// <summary>
        /// Pedido criado. Mas ainda não possui nenhum pagamento. <see href="https://dev.moip.com.br/v2.0/reference#lista-de-status-possiveis-pedido">Mais Informações</see> 
        /// </summary>
        CREATED,

        /// <summary>
        ///Pedido aguardando confirmação de pagamento. Indica que há um pagamento de cartão em análise ou um boleto que ainda não foi confirmado pelo banco. <see href="https://dev.moip.com.br/v2.0/reference#lista-de-status-possiveis-pedido">Mais Informações</see> 
        /// </summary>
        WAITING,

        /// <summary>
        /// Pedido pago. O pagamento criado nesse pedido foi autorizado. <see href="https://dev.moip.com.br/v2.0/reference#lista-de-status-possiveis-pedido">Mais Informações</see> 
        /// </summary>
        PAID,

        /// <summary>
        /// Pedido não pago. O pagamento criado nesse pedido foi cancelado (Pagamentos com cartão podem ser cancelados pelo Moip ou pelo Emissor do cartão, boletos são cancelados 5 dias após vencimento, débito bancário é cancelado em caso de falha). <see href="https://dev.moip.com.br/v2.0/reference#lista-de-status-possiveis-pedido">Mais Informações</see> 
        /// </summary> PAID,
        NOT_PAID,

        /// <summary>
        /// Pedido revertido. Sofreu um chargeback ou foi completamente reembolsado. <see href="https://dev.moip.com.br/v2.0/reference#lista-de-status-possiveis-pedido">Mais Informações</see> 
        /// </summary>
        REVERTED
    }

    public enum CurrencyType
    {
        BRL
    }

    public enum PaymentStatusType
    {
        /// <summary>
        /// Pagamento criado.
        /// </summary>
        CREATED,
        /// <summary>
        /// Pagamento aguardando confirmação (Boleto não confirmado ou débito bancário pendente).
        /// </summary>
        WAITING,
        /// <summary>
        /// Pagamento de cartão aguardando análise.
        /// </summary>
        IN_ANALYSIS,
        /// <summary>
        /// O valor do pagamento está reservado no cartão de crédito do comprador.
        /// </summary>
        PRE_AUTHORIZED,
        /// <summary>
        /// Pagamento autorizado.
        /// </summary>
        AUTHORIZED,
        /// <summary>
        /// Pagamento cancelado (Pagamentos com cartão podem ser cancelados pelo Moip ou pelo emissor do cartão, boletos são cancelados 5 dias após vencimento, débito bancário é cancelado em caso de falha).
        /// </summary>
        CANCELLED,
        /// <summary>
        /// Pagamento reembolsado (quem processa reembolsos são Moip e/ou Merchant).
        /// </summary>
        REFUNDED,
        /// <summary>
        /// Pagamento revertido (Chargeback. O cliente contesta a transação diretamente no emissor).
        /// </summary>
        REVERSED,

        /// <summary>
        /// Pagamento liquidado. Significa que o valor da transação foi “liberado” na conta, para que o merchant possa sacar para sua conta bancária.
        /// </summary>
        SETTLED
    }

    public enum FeeType
    {
        TRANSACTION,
        PRE_PAYMENT
    }
    public enum CancelledByType
    {
        MOIP,
        ACQUIRER
    }
    public enum RefundStatusType
    {
        REQUESTED,
        COMPLETED,
        FAILED
    }
    public enum RefundType
    {
        FULL,
        PARTIAL
    }

    public enum BankAccountType
    {
        CHECKING,
        SAVING
    }

    public enum EntryStatusType
    {
        SCHEDULED,
        SETTLED
    }

    public enum OperationType
    {
        CREDIT,
        DEBIT
    }

    public enum ReceiverType
    {
        PRIMARY,
        SECONDARY
    }



}
