using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.HRMS.Common
{
    public class JsonError
    {
        public string Status { get; set; }
        public bool Success { get; set; }
        public CustomError Error { get; set; }
    }

    public class CustomError
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string DocUrl { get; set; }
        public string TraceId { get; set; }
    }

    public class ApiUrl
    {
        public static string Login = "api/Employee/Login";
        public static string ForgotPassword = "api/Employee/ForgotPassword";
        public static string ResetPassword = "api/Employee/ResetPassword";
        public static string AccountVerify = "api/Employee/AccountVerify";
        public static string AccountActivation = "api/Employee/AccountActivation";
        public static string Registration = "api/Employee/Registration";
        public static string Create = "api/Employee/create";
    }
}
