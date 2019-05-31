using System.ServiceModel;
using Dto;

namespace Interface
{
    [ServiceContract]
    public interface ISvcTickets
    {
        [OperationContract]
        TicketFundQuotas GetTicketFundQuotas(string statusId, string token);

        [OperationContract]
        TicketPrivateFixedIncome GetTicketPrivateFixedIncome(string statusId, string token);

        [OperationContract]
        TicketPublicFixedIncome GetTicketPublicFixedIncome(string statusId, string token);

        [OperationContract]
        TicketCurrencyTerm GetTicketCurrencyTerm(string statusId, string token);

        [OperationContract]
        TicketContracted GetTicketContracted(string statusId, string token);

        [OperationContract]
        TicketSwapCetip GetTicketSwapCetip(string statusId, string token);

        [OperationContract]
        TicketFutures GetTicketFutures(string statusId, string token);

        [OperationContract]
        TicketMargin GetTicketMargin(string statusId, string token);

        [OperationContract]
        TicketReject PostTicketReject(string ticketId, string comments, string token);

        [OperationContract]
        TicketAdvanceStep PostTicketAdvanceStep(string ticketId, string comments, string token);

        [OperationContract]
        TicketApprove PostTicketApprove(string ticketId, string comments, string token);
    }
}