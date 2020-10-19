﻿using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Text;

namespace OBS.HRMS.Common
{
    public class CustomException : Exception
    {
        string _errorCode;
        IConfiguration _configuration;

        public CustomException(string errorCode, IConfiguration configuration)
        {
            _errorCode = errorCode;
            _configuration = configuration;
        }

        public JsonError GetErrorObject()
        {
            return new JsonError()
            {
                Status = _configuration.GetSection(_errorCode + ":" + "status").Value,
                Success = Convert.ToBoolean(_configuration.GetSection(_errorCode + ":" + "success").Value),
                Error = new CustomError
                {
                    Code = _configuration.GetSection(_errorCode + ":" + "code").Value,
                    Title = _configuration.GetSection(_errorCode + ":" + "title").Value,
                    Detail = _configuration.GetSection(_errorCode + ":" + "detail").Value,
                    DocUrl = _configuration.GetSection(_errorCode + ":" + "docURL").Value,
                    TraceId = _configuration.GetSection(_errorCode + ":" + "traceID").Value
                }
            };
        }

        public enum ErrorCodes
        {
            Token_Header_Missing,
            Payload_Missing,
            Signature_Missing,
            Token_Expired,
            Not_ProperToken,
            Valid_block,
            Not_Found,
            Invalid,
            Blocked,
            Unauthorized,
            Success,
            Default
        }

    }
}
