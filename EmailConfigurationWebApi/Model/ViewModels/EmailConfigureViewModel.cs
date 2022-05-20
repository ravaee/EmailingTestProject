using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmailConfigurationWebApi.Model
{
    public class EmailConfigureViewModel
    {
        public int EmailId { get; set; }

        public string? EmailName { get; set; }

        public string? WatchedFolder { get; set; }

        public bool StoreAttachment { get; set; }

        public ProviderType ProviderType { get; set; }

        public static EmailConfigure ToPoco(EmailConfigureViewModel viewModel)
        {
            return new EmailConfigure()
            {
                EmailId = viewModel.EmailId,
                EmailName = viewModel.EmailName ?? "",
                WatchedFolder = viewModel.WatchedFolder ?? "",
                StoreAttachment = viewModel.StoreAttachment,
                ProviderType = viewModel.ProviderType,
            };
        }

        public static EmailConfigureViewModel ToDTO(EmailConfigure pocoModel)
        {
            return new EmailConfigureViewModel()
            {
                EmailId = pocoModel.EmailId,
                EmailName = pocoModel.EmailName ?? "",
                WatchedFolder = pocoModel.WatchedFolder ?? "",
                StoreAttachment = pocoModel.StoreAttachment,
                ProviderType = pocoModel.ProviderType,
            };
        }
    }


}
