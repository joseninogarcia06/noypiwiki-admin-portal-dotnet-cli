using System;

namespace NoypiWikiAdminMicroservices.Model.Common;

public class PrepareErrorResponse
{
    private Exception Exception { get; set; }

    private string Message { get; set; }

    private string ServiceName { get; set; }

    public PrepareErrorResponse(Exception exception, string message, string serviceName)
    {
        this.Exception = exception;
        this.Message = message;
        this.ServiceName = serviceName;
    }

    public DefaultResponse GetErrorResponse()
    {
        var returnCode = string.Empty;
        var returnMessage = string.Empty;

        if(this.Exception is ArgumentException)
        {
            returnCode = "02";
        }

        if(this.Exception is Exception)
        {
            returnCode = "99";   
        }

        returnMessage = this.Exception.Message;
        return new DefaultResponse(false, returnCode, returnMessage, this.ServiceName, null, null);
    }
}
