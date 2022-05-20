using EmailConfigurationWebApi.Model;
using EmailConfigurationWebApi.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailConfigurationWebApi.Test.Base
{
    public class TestBase
    {
        protected readonly EmailConfigureContext _context;
        protected readonly EmailConfigureService _service;

        public TestBase()
        {
            var ob = new DbContextOptionsBuilder<EmailConfigureContext>();
            ob.UseSqlite("Filename = EmailConfigureTestDatabase.db");

            _context = new EmailConfigureContext(ob.Options);

            _service = new EmailConfigureService(_context);
        }
    }
}
