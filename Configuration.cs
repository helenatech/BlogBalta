namespace Blog
{
    public static class Configuration
    {
        //TOKEN - JWT - Json Web Token
        public static string JwtKey = "58dd45a51ae148f39c07e7265f1b43c7";
        public static string ApiKeyName = "api_key";
        public static string ApiKey = "curso_api_AlWMvmAP/z07q9N2s5/opLm==";
        public static SmtpConfiguration Smtp = new();

        public class SmtpConfiguration
        {
            public string Host { get; set; }
            public int Port { get; set; } = 25;
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}

