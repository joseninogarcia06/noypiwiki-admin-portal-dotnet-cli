using System;

namespace NoypiWikiAdminMicroservices.Model.Common;

public class ExceptionsDto
{
    public string ErrorCode { get; set; }

    public string ErrorMessage { get; set; }

    public string ServiceName { get; set; }

    public ExceptionsDto(string errorCode, string errorMessage, string serviceName)
    {
        this.ErrorCode = errorCode;
        this.ErrorMessage = errorMessage;
        this.ServiceName = serviceName;
    }
}
