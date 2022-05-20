namespace EmailConfigurationWebApi.Exceptions
{
    public class EmailDataNotFoundException: Exception
    {
        public EmailDataNotFoundException(): base("No data for requested email id found")
        {

        }
    }
}
