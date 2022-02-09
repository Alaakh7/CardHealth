using System;
using Microsoft.AspNetCore.Http;
using Utils.Models;
using Utils.Models.Enums;

namespace Utils.Services
{
    public static class SessionManager
    {
        public static bool CheckUser(this HttpContext httpContext) =>  httpContext.Session.GetInt32("Id").HasValue;
        public static bool CheckEmptyUser(this HttpContext httpContext) => !httpContext.Session.GetInt32("Id").HasValue;
        public static AccountType? CheckAccountType(this HttpContext httpContext) => (AccountType?)httpContext.Session.GetInt32("AccountType");
        public static void CreateSession(this HttpContext httpContext , Account account)
        {
            httpContext.Session.SetInt32("Id", account.Id);
            httpContext.Session.SetString("UserName", account.UserName);
            httpContext.Session.SetInt32("AccountType", (int)account.AccountType);
        }
        public static void ClearSession(this HttpContext httpContext) => httpContext.Session.Clear();
    }
}