using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmailConfigurationWebApi.Model;
using EmailConfigurationWebApi.Service;
using EmailConfigurationWebApi.Validations;
using EmailConfigurationWebApi.Exceptions;

namespace EmailConfigurationWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailConfigureController : ControllerBase
    {
        //remove DbContext from your controllers 
        private readonly EmailConfigureContext _context;
        private readonly EmailConfigureService _service;

        public EmailConfigureController(
            EmailConfigureContext context,
            EmailConfigureService service
            )
        {
            _context = context;
            _service = service;
        }

        // GET: api/EmailConfigure
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmailConfigure>>> GetEmailConfigures()
        {

            //try
            //{
            //    List<EmailConfigure> result = await TestEmployeesGetAsync(); _service.GetEmailConfigures();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            if (_context.EmailConfigures == null)
            {
                return NotFound();
            }
            return await _context.EmailConfigures.ToListAsync();
        }

        // GET: api/EmailConfigure/5
        [HttpGet("{id}")]
        //Refactored
        public async Task<IActionResult> GetEmailConfigure(int id)
        {
            try
            {
                var result = await _service.GetEmailConfigure(id);

                return Ok(result);
            }
            catch (Exception e)
            {
                if (e.IsExcpected())
                {
                    return NotFound(e.Message);
                }

                return StatusCode(500, e);
            }
        }


        [HttpPost]
        //Refactored
        public async Task<IActionResult> PostEmailConfigure(EmailConfigureViewModel emailConfigureViewModel)
        {

            try
            {
                var validationResult = EmailConfigureValidation.Validate(emailConfigureViewModel);

                if (!validationResult.IsSuccess)
                {
                    return BadRequest(validationResult.ErrorMessages);
                }

                var result = await _service.PostEmailConfigure(EmailConfigureViewModel.ToPoco(emailConfigureViewModel));
                return Ok(result);
            }
            catch (Exception e)
            {
                if (e.IsExcpected())
                {
                    return NotFound(e.Message);
                }

                return StatusCode(500, e);
            }
        }

    }
}
