namespace EmailConfigurationWebApi.Exceptions
{
    public class EmailNotFoundException : Exception
    {
        public EmailNotFoundException(): base("The Email with this Id not exist in  database")
        {

        }
    }
}
