using EmailConfigurationWebApi.Model;

namespace EmailConfigurationWebApi.Validations
{
    public static class EmailConfigureValidation
    {
        public static (bool IsSuccess, string ?ErrorMessages) Validate(EmailConfigureViewModel model)
        {
            var errors = new List<string>();
            var success = true;

            if(string.IsNullOrEmpty(model.EmailName))
            {
                errors.Add("Email name is Required");
                success = false;
                
            }

            // other validation for EmailConf obj ...

            if (!success)
            {
                return (false, GetRawErrorMessage(errors));
            }

            return (true, null);
        }

        private static string GetRawErrorMessage(List<string>? errors)
        {
            if(errors is null)
            {
                return "The Error message is not recognized";
            }

            var rawErrors = errors.Aggregate((a, b) => a + "\n" + b);

            return rawErrors;
        }
    }
}
