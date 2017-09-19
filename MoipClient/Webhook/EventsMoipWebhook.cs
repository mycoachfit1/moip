using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoipClient.Webhook
{
    /// <summary>
    /// https://dev.moip.com.br/v2.0/reference#lista-de-webhooks-disponíveis
    /// </summary>
    public static class EventsMoipWebhook
    {
        /// <summary>
        /// Criação de um novo pedido
        /// </summary>
        const string ORDER_CREATED = "ORDER.CREATED";
        /// <summary>
        /// Atualização de status de pedido para Aguardando pagamento
        /// </summary>
        const string ORDER_WAITING = "ORDER.WAITING";
        /// <summary>
        /// Atualização de status de pedido para Pago
        /// </summary>
        const string ORDER_PAID = "ORDER.PAID";
        /// <summary>
        /// Atualização de status de pedido para Não Pago
        /// </summary>
        const string ORDER_NOT_PAID = "ORDER.NOT_PAID";
        /// <summary>
        /// Atualização de status de pedido para Revertido
        /// </summary>
        const string ORDER_REVERTED = "ORDER.REVERTED";


        ///<summary>
        /// Primeiro evento de um pagamento, indica que o pagamento foi criado.
        ///</summary>
        const string PAYMENT_CREATED = "PAYMENT.CREATED";
        ///<summary>
        /// Atualização de status para Aguardando, indica que o Moip está aguardando confirmação de pagamento.
        ///</summary>
        const string PAYMENT_WAITING = "PAYMENT.WAITING";
        ///<summary>
        /// Atualização de status para Em Análise, indica que o pagamento está passando por uma análise de risco dentro do Moip, pode ser automática ou manual.
        ///</summary>
        const string PAYMENT_IN_ANALYSIS = "PAYMENT.IN_ANALYSIS";
        ///<summary>
        /// Atualização de status para Pré-autorizado, esse status indica a reserva do valor do pagamento no cartão do cliente. Após a pré-autorização é possível fazer a captura em até 5 dias. Passado esse período o Moip cancelará a transação automaticamente.
        ///</summary>
        const string PAYMENT_PRE_AUTHORIZED = "PAYMENT.PRE_AUTHORIZED";
        ///<summary>
        /// Atualização de status para Autorizado, significa que o pagamento foi capturado e debitado no cartão do cliente ou reconhecido junto a instituição bancária, esse status é o indicador de que o pagamento foi efetivado e você deve proceder com a entrega da compra.
        ///</summary>
        const string PAYMENT_AUTHORIZED = "PAYMENT.AUTHORIZED";
        ///<summary>
        /// Atualização de status para Cancelado, o pagamento não foi efetivado.
        ///</summary>
        const string PAYMENT_CANCELLED = "PAYMENT.CANCELLED";
        ///<summary>
        /// Atualização de status de pagamento para Reembolsado.
        ///</summary>
        const string PAYMENT_REFUNDED = "PAYMENT.REFUNDED";
        ///<summary>
        /// Atualização de status de pagamento para Estornado (O Estorno é a contestação do pagamento feita pelo comprador direto na operadora de cartão, como por exemplo pelo motivo de não reconhecimento do pagamento em sua fatura)
        ///</summary>
        const string PAYMENT_REVERSED = "PAYMENT.REVERSED";
        ///<summary>
        ///- Atualização de status de pagamento para Concluído, valor disponível para transferência em conta bancária(saque).
        ///</summary>
        const string PAYMENT_SETTLED = "PAYMENT.SETTLE";
        ///<summary>
        /// Criação de um novo reembolso
        ///</summary>
        const string REFUND_REQUESTED = "REFUND.REQUESTED";
        ///<summary>
        /// Atualização de status de reembolso para Completo
        ///</summary>
        const string REFUND_COMPLETED = "REFUND.COMPLETED";
        ///<summary>
        /// Atualização de status de reembolso para Falha
        ///</summary>
        const string REFUND_FAILED = "REFUND.FAILED";
        ///<summary>
        /// Criação de um novo pedido
        ///</summary>
        const string MULTIORDER_CREATED = "MULTIORDER.CREATED";
        ///<summary>
        /// Atualização de status de pedido para Pago
        ///</summary>
        const string MULTIORDER_PAID = "MULTIORDER.PAID";
        ///<summary>
        /// Atualização de status de pedido para Não Pago
        ///</summary>
        const string MULTIORDER_NOT_PAID = "MULTIORDER.NOT_PAID";
        ///<summary>
        /// Atualização de status de pedido para Revertido
        ///</summary>
        const string MULTIORDER_REVERTED = "MULTIORDER.REVERTED";
        ///<summary>
        /// Atualização de status para Aguardando, indica que o Moip está aguardando confirmação de pagamento.
        ///</summary>
        const string MULTIPAYMENT_WAITING = "MULTIPAYMENT.WAITING";
        ///<summary>
        /// Atualização de status de pagamento para Em Análise
        ///</summary>
        const string MULTIPAYMENT_IN_ANALYSIS = "MULTIPAYMENT.IN_ANALYSIS";
        ///<summary>
        /// Atualização de status de pagamento para Autorizado
        ///</summary>
        const string MULTIPAYMENT_AUTHORIZED = "MULTIPAYMENT.AUTHORIZED";
        ///<summary>
        /// Atualização de status de pagamento para Cancelado
        ///</summary>
        const string MULTIPAYMENT_CANCELLED = "MULTIPAYMENT.CANCELLED";
        ///<summary>
        /// Atualização de status de pagamento para Reembolsado.
        ///</summary>
        const string MULTIPAYMENT_REFUNDED = "MULTIPAYMENT.REFUNDED";
        ///<summary>
        /// Indica que um novo lançamento foi agendado, status de lançamento Agendado.
        ///</summary>
        const string ENTRY_SCHEDULED = "ENTRY.SCHEDULED";
        ///<summary>
        /// Atualização de status de lançamento para Concluído
        ///</summary>
        const string ENTRY_SETTLED = "ENTRY.SETTLED";
        ///<summary>
        /// Criação de uma nova transferência
        ///</summary>
        const string TRANSFER_REQUESTED = "TRANSFER.REQUESTED";
        ///<summary>
        /// Atualização de status da transferência para Concluído
        ///</summary>
        const string TRANSFER_COMPLETED = "TRANSFER.COMPLETED";
        ///<summary>
        /// Atualização de status da transferência para Falha
        ///</summary>
        const string TRANSFER_FAILED = "TRANSFER.FAILED";
        ///<summary>
        /// Custódia pendente. O valor entrará em custódia quando o pagamento for liquidado.
        ///</summary>
        const string ESCROW_HOLD_PENDING = "ESCROW.HOLD_PENDING";
        ///<summary>
        /// Custódia ativa. O valor do pagamento foi bloqueado nas contas de todos os recebedores.
        ///</summary>
        const string ESCROW_HELD = "ESCROW.HELD";
        ///<summary>
        /// Custódia liberada. O valor da transação foi liberado para liquidação na conta dos recebedores.
        ///</summary>
        const string ESCROW_RELEASED = "ESCROW.RELEASED";







    }
}
