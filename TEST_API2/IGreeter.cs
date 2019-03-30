using Microsoft.Extensions.Configuration;

namespace TEST_API2
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        public string GetMessageOfTheDay()
        {
            return "Greetings";
        }
    }

    public class Greeter2 : IGreeter
    {
        private IConfiguration _config;

        public Greeter2(IConfiguration configuration)
        {
            _config = configuration;
        }

        public string GetMessageOfTheDay()
        {
            return _config["Greeting"];
        }
    }
}