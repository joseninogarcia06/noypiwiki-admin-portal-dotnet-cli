using System;
namespace NoypiWikiAdminMicroservices.Model.Common;

public class DefaultResponse
{
    public bool IsSuccess { get; set; }

    public string ReturnCode { get; set; }

    public string ReturnMessage { get; set; }

    public string ServiceName { get; set; }

    public Object? Payload { get; set; }

    public List<ExceptionsDto>? Errors { get; set; }

    public DefaultResponse(bool isSuccess, string returnCode, string returnMessage, string serviceName, 
        List<ExceptionsDto>? errors, Object? payload)
    {
        this.IsSuccess = isSuccess;
        this.ReturnCode = returnCode;
        this.ReturnMessage = returnMessage;
        this.ServiceName = serviceName;
        this.Errors = errors;
        this.Payload = payload;
    }
}
