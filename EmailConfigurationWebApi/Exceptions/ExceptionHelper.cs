namespace EmailConfigurationWebApi.Exceptions
{
    public static class ExceptionHelper
    {
        private static List<Type> HandledExceptionTypes = new List<Type>()
        {
            typeof(EmailDataNotFoundException), typeof(EmailNotFoundException)
        };

        public static bool IsExcpected(this Exception ex)
        {
            if (HandledExceptionTypes.Any(a => a == ex.GetType())){

                return true;
            }

            return false;
        }
    }
}
