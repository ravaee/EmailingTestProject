using EmailConfigurationWebApi.Exceptions;
using EmailConfigurationWebApi.Model;
using System.Web.Http.ModelBinding;

namespace EmailConfigurationWebApi.Service
{
    public class EmailConfigureService
    {
        private readonly EmailConfigureContext _context;

        public EmailConfigureService(EmailConfigureContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EmailConfigure>> GetEmailConfigures()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Message;
            //}
            var emailConfigures =  _context.EmailConfigures.ToList();
            if (_context.EmailConfigures == null)
            {
                return null; // Error Handel
            }
            return emailConfigures;
        }

        //Refactored
        public async Task<EmailConfigure> GetEmailConfigure(int id)
        {
            var emailConfigure = await _context.EmailConfigures.FindAsync(id);
            var emailConfigures = _context.EmailConfigures.ToList();

            if (emailConfigure == null)
            {
                throw new EmailNotFoundException();
            }

            if (emailConfigures == null)
            {
                throw new EmailDataNotFoundException();
            }

            return emailConfigure;
        }

        //Refactored
        public async Task<EmailConfigureViewModel> PostEmailConfigure(EmailConfigure emailConfigure)
        {
            
            _context.EmailConfigures.Add(emailConfigure);

            await _context.SaveChangesAsync();

            return EmailConfigureViewModel.ToDTO(emailConfigure); 

        }
        private bool EmailConfigureExists(int id)
        {
            return (_context.EmailConfigures?.Any(e => e.EmailId == id)).GetValueOrDefault();
        }

    }
}
