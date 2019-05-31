using System;
using System.Xml.Serialization;
using Newtonsoft.Json;
using RestSharp;

public static class Ticket
{
    public static T TicketJsonToObject<T>(string jsonContent, string parentNode, string rootElementName)
        where T : class
    {
        var xd = JsonConvert.DeserializeXNode(
            "{\"" + parentNode + "\":" + jsonContent + "}", rootElementName, false);

        var xRoot = new XmlRootAttribute {ElementName = rootElementName, IsNullable = true};

        var serializerObject = new XmlSerializer(typeof(T), xRoot);

        var objTicket = serializerObject.Deserialize(xd.CreateReader());

        return (T) objTicket;
    }

    public static TicketJson TicketJson(string url, string token, string paramBody, Method method)
    {
        var urlTicket = new Uri(url);

        var client = new RestClient(urlTicket.AbsoluteUri);

        var request = new RestRequest(method);
        request.AddHeader("cache-control", "no-cache");
        request.AddHeader("Connection", "keep-alive");
        request.AddHeader("accept-encoding", "gzip, deflate");
        request.AddHeader("Host", urlTicket.Host +":"+ urlTicket.Port);
        request.AddHeader("Cache-Control", "no-cache");
        request.AddHeader("Accept", "*/*");
        request.AddHeader("Authorization", "Bearer " + token);

        if (!string.IsNullOrEmpty(paramBody.Trim()))
        {
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", paramBody, ParameterType.RequestBody);
        }

        var req = client.Execute(request);

        var objTicketJson = new TicketJson
        {
            Content = req.Content,
            StatusCode = req.StatusCode
        };

        return objTicketJson;
    }
}