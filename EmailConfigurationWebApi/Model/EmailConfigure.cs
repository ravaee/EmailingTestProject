using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmailConfigurationWebApi.Model
{
    public class EmailConfigure
    {
        [Key]
        public int EmailId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string EmailName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string WatchedFolder { get; set; }

        public bool StoreAttachment { get; set; }

        public ProviderType ProviderType { get; set; }
    }

    public enum ProviderType
    {
        [Column(TypeName = "nvarchar(10)")]
        Exchange,

        [Column(TypeName = "nvarchar(10)")]
        IMAP
    }

}
