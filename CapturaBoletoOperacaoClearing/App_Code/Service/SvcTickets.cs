using System;
using System.Configuration;
using System.Reflection;
using Dto;
using Interface;
using log4net;
using RestSharp;

namespace Service
{
    public class SvcTickets : ISvcTickets
    {
        private readonly ILog _log =
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public TicketFundQuotas GetTicketFundQuotas(string statusId, string token)
        {
            try
            {
                ValidarParametros(statusId, token);

                var url = ConfigurationManager.AppSettings["UrlTicket"] +
                          "/tickets/quota?statusId=" + statusId;

                var ticketJson = Ticket.TicketJson(url, token, "", Method.GET);

                var objTicketFundQuotas = Ticket.TicketJsonToObject<TicketFundQuotas>(
                    ticketJson.Content,
                    "Quota",
                    "TicketFundQuotas");

                objTicketFundQuotas.StatusCode = ticketJson.StatusCode.ToString();

                return objTicketFundQuotas;
            }
            catch (Exception ex)
            {
                _log.Error("GetTicketFundQuotas: ", ex);
                return null;
            }
        }

        public TicketPrivateFixedIncome GetTicketPrivateFixedIncome(string statusId, string token)
        {
            try
            {
                ValidarParametros(statusId, token);

                var url = ConfigurationManager.AppSettings["UrlTicket"] +
                          "/tickets/private-fixed-income?statusId=" + statusId;

                var ticketJson = Ticket.TicketJson(url, token, "", Method.GET);

                var objTicketPrivateFixedIncome = Ticket.TicketJsonToObject<TicketPrivateFixedIncome>(
                    ticketJson.Content,
                    "private-fixed-income",
                    "TicketPrivateFixedIncome");

                objTicketPrivateFixedIncome.StatusCode = ticketJson.StatusCode.ToString();

                return objTicketPrivateFixedIncome;
            }
            catch (Exception ex)
            {
                _log.Error("GetPrivateFixedIncome: ", ex);
                return null;
            }
        }

        public TicketPublicFixedIncome GetTicketPublicFixedIncome(string statusId, string token)
        {
            try
            {
                ValidarParametros(statusId, token);

                var url = ConfigurationManager.AppSettings["UrlTicket"] +
                          "/tickets/public-fixed-income?statusId=" + statusId;

                var ticketJson = Ticket.TicketJson(url, token, "", Method.GET);

                var objTicketPublicFixedIncome = Ticket.TicketJsonToObject<TicketPublicFixedIncome>(
                    ticketJson.Content,
                    "public-fixed-income",
                    "TicketPublicFixedIncome");

                objTicketPublicFixedIncome.StatusCode = ticketJson.StatusCode.ToString();

                return objTicketPublicFixedIncome;
            }
            catch (Exception ex)
            {
                _log.Error("GetTicketPublicFixedIncome: ", ex);
                return null;
            }
        }

        public TicketCurrencyTerm GetTicketCurrencyTerm(string statusId, string token)
        {
            try
            {
                ValidarParametros(statusId, token);

                var url = ConfigurationManager.AppSettings["UrlTicket"] +
                          "/tickets/currency-term?statusId=" + statusId;

                var ticketJson = Ticket.TicketJson(url, token, "", Method.GET);

                var objTicketCurrencyTerm = Ticket.TicketJsonToObject<TicketCurrencyTerm>(
                    ticketJson.Content,
                    "currency-term",
                    "TicketCurrencyTerm");

                objTicketCurrencyTerm.StatusCode = ticketJson.StatusCode.ToString();

                return objTicketCurrencyTerm;
            }
            catch (Exception ex)
            {
                _log.Error("GetTicketCurrencyTerm: ", ex);
                return null;
            }
        }

        public TicketSwapCetip GetTicketSwapCetip(string statusId, string token)
        {
            try
            {
                ValidarParametros(statusId, token);

                var url = ConfigurationManager.AppSettings["UrlTicket"] +
                          "/tickets/swap-cetip?statusId=" + statusId;

                var ticketJson = Ticket.TicketJson(url, token, "", Method.GET);

                var objTicketSwapCetip = Ticket.TicketJsonToObject<TicketSwapCetip>(
                    ticketJson.Content,
                    "swap-cetip",
                    "TicketSwapCetip");

                return objTicketSwapCetip;
            }
            catch (Exception ex)
            {
                _log.Error("GetTicketSwapCetip: ", ex);
                return null;
            }
        }

        public TicketFutures GetTicketFutures(string statusId, string token)
        {
            try
            {
                ValidarParametros(statusId, token);

                var url = ConfigurationManager.AppSettings["UrlTicket"] +
                          "/tickets/futures?statusId=" + statusId;

                var ticketJson = Ticket.TicketJson(url, token, "", Method.GET);

                var objTicketFutures = Ticket.TicketJsonToObject<TicketFutures>(
                    ticketJson.Content,
                    "futures",
                    "TicketFutures");

                return objTicketFutures;
            }
            catch (Exception ex)
            {
                _log.Error("GetTicketFutures: ", ex);
                return null;
            }
        }

        public TicketMargin GetTicketMargin(string statusId, string token)
        {
            try
            {
                ValidarParametros(statusId, token);

                var url = ConfigurationManager.AppSettings["UrlTicket"] +
                          "/tickets/margin?statusId=" + statusId;

                var ticketJson = Ticket.TicketJson(url, token, "", Method.GET);

                var objTicketMargin = Ticket.TicketJsonToObject<TicketMargin>(
                    ticketJson.Content,
                    "margin",
                    "TicketMargin");

                objTicketMargin.StatusCode = ticketJson.StatusCode.ToString();

                return objTicketMargin;
            }
            catch (Exception ex)
            {
                _log.Error("GetTicketMargin: ", ex);
                return null;
            }
        }

        public TicketContracted GetTicketContracted(string statusId, string token)
        {
            try
            {
                ValidarParametros(statusId, token);

                var url = ConfigurationManager.AppSettings["UrlTicket"] +
                          "/tickets/contracted?statusId=" + statusId;

                var ticketJson = Ticket.TicketJson(url, token,"", Method.GET);

                var objTicketContracted = Ticket.TicketJsonToObject<TicketContracted>(
                    ticketJson.Content,
                    "contracted",
                    "TicketContracted");

                objTicketContracted.StatusCode = ticketJson.StatusCode.ToString();

                return objTicketContracted;
            }
            catch (Exception ex)
            {
                _log.Error("GetTicketContracted: ", ex);
                return null;
            }
        }

        public TicketAdvanceStep PostTicketAdvanceStep(string ticketId, string comments, string token)
        {
            try
            {
                ValidarParametros(ticketId, token, comments);

                var url = ConfigurationManager.AppSettings["UrlTicket"] +
                          "/tickets/Ticket/" + ticketId + "/advance-step?comments=" + comments;                

                var ticketJson = Ticket.TicketJson(url, token, "", Method.POST);

                var objTicketAdvanceStep = new TicketAdvanceStep
                {
                    StatusCode = ticketJson.StatusCode.ToString(),
                    Content = ticketJson.Content,
                    ReturnOk = ticketJson.StatusCode.ToString() == "OK"
                };

                return objTicketAdvanceStep;
            }
            catch (Exception ex)
            {
                _log.Error("PostTicketContracted: ", ex);
                return null;
            }
        }

        public TicketApprove PostTicketApprove(string ticketId, string comments, string token)
        {
            try
            {
                ValidarParametros(ticketId, token, comments);

                var url = ConfigurationManager.AppSettings["UrlTicket"] +
                          "/tickets/Ticket/" + ticketId + "/approve?comments=" + comments;

                var ticketJson = Ticket.TicketJson(url, token, "", Method.POST);

                var objTicketApprove = new TicketApprove
                {
                    StatusCode = ticketJson.StatusCode.ToString(),
                    Content = ticketJson.Content,
                    ReturnOk = ticketJson.StatusCode.ToString() == "OK"
                };

                return objTicketApprove;
            }
            catch (Exception ex)
            {
                _log.Error("PostTicketContracted: ", ex);
                return null;
            }
        }

        public TicketReject PostTicketReject(string ticketId, string comments, string token)
        {
            try
            {
                ValidarParametros(ticketId, token, comments);

                var url = ConfigurationManager.AppSettings["UrlTicket"] +
                          "/tickets/Ticket/" + ticketId + "/reject";

                var ticketJson = Ticket.TicketJson(
                    url, 
                    token, 
                    "{\r\n  \"comments\": \"" +
                    comments + "\"\r\n}", 
                    Method.POST);

                var objTicketReject = new TicketReject
                {
                    StatusCode = ticketJson.StatusCode.ToString(),
                    Content = ticketJson.Content,
                    ReturnOk = ticketJson.StatusCode.ToString() == "OK"
                };

                return objTicketReject;
            }
            catch (Exception ex)
            {
                _log.Error("PostTicketReject: ", ex);
                return null;
            }
        }

        private static void ValidarParametros(string statusId, string token)
        {
            int aux;

            if (string.IsNullOrEmpty(statusId.Trim()) || !int.TryParse(statusId.Trim(), out aux))
                throw new Exception("StatusId invalido");

            if (string.IsNullOrEmpty(token.Trim()))
                throw new Exception("Token invalido");
        }

        private static void ValidarParametros(string statusId, string token, string comments)
        {
            ValidarParametros(statusId, token);

            if (string.IsNullOrEmpty(comments.Trim()))
                throw new Exception("Comentários invalido");
        }
    }
}