﻿
namespace GameContester.Service.Models
{
    public class LoginResponseModel
    {
        public string access_token { get; set; }
        public string TokenType { get; set; }
        public string ExpiresIn { get; set; }
    }
}