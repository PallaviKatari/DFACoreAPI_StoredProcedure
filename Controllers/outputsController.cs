using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreAPI_SP.Models.DB;
#nullable disable
namespace CoreAPI_SP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class outputsController : ControllerBase
    {
        private readonly DB_Demo_APIContext _context;

        public outputsController(DB_Demo_APIContext context)
        {
            _context = context;
        }

        // POST: api/outputs
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Output>>> Getoutput(Input input)
        {
            string StoredProc = "exec CreateAppointment " +
                    "@ClinicID = " + input.ClinicId + "," +
                    "@AppointmentDate = '" + input.AppointmentDate + "'," +
                    "@FirstName= '" + input.FirstName + "'," +
                    "@LastName= '" + input.LastName + "'," +
                    "@PatientID= " + input.PatientId + "," +
                    "@AppointmentStartTime= '" + input.AppointmentStartTime + "'," +
                    "@AppointmentEndTime= '" + input.AppointmentEndTime + "'";

            //return await _context.output.ToListAsync();
            return await _context.Output.FromSqlRaw(StoredProc).ToListAsync();
        }
    }
}
