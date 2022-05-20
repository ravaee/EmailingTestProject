using EmailConfigurationWebApi.Model;
using EmailConfigurationWebApi.Test.Base;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace EmailConfigurationWebApi.Test
{
    public class EmailConfigureServiceTest: TestBase
    {

        public EmailConfigureServiceTest()
        {
            var data = new List<EmailConfigure>()
            {
                new EmailConfigure(){ EmailName = "A@gmail.com", ProviderType = 0, StoreAttachment = true, WatchedFolder = "somewhere" },
                new EmailConfigure(){ EmailName = "B@gmail.com", ProviderType = 0, StoreAttachment = true, WatchedFolder = "somewhere" },
                new EmailConfigure(){ EmailName = "C@gmail.com", ProviderType = 0, StoreAttachment = true, WatchedFolder = "somewhere" }
            };

            _context.AddRange(data);
            _context.SaveChanges();
        }

        [Theory]
        [InlineData(1, "A@gmail.com")]
        [InlineData(2, "B@gmail.com")]
        [InlineData(3, "C@gmail.com")]
        public async void SetValidId_ReturnValidEmailobjects(int id, string expectedEmail)
        {
            var result = await _service.GetEmailConfigure(id);

            result.EmailName.Should().Be(expectedEmail);

        }
    }
}