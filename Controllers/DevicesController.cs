using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DevicesApi.Models;
using DevicesApi.ViewModels;

namespace DevicesApi.Controllers
{
    [Route("api/Devices")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private readonly DeviceContext _context;

        public DevicesController(DeviceContext context)
        {
            _context = context;
        }

        // GET: api/Devices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeviceViewModel>>> GetDevices()
        {
            List<DeviceViewModel> retVal = new List<DeviceViewModel>();

            var devices = await _context.Devices.Include(d => d.RelatedDevices).ToListAsync();
            foreach (var device in devices)
            {
                retVal.Add(new DeviceViewModel(device));
            }

            return retVal;
        }

        // GET: api/Devices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeviceViewModel>> GetDevice(int id)
        {
            var device = await _context.Devices.FindAsync(id);

            if (device == null)
            {
                return NotFound();
            }

            var retVal = new DeviceViewModel(device);

            return retVal;
        }

        //// PUT: api/Devices/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutDevice(int id, Device device)
        //{
        //    if (id != device.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(device).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!DeviceExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Devices
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Device>> PostDevice(Device device)
        //{
        //    _context.Devices.Add(device);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(GetDevice), new { id = device.Id }, device);
        //}

        //// DELETE: api/Devices/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteDevice(int id)
        //{
        //    var device = await _context.Devices.FindAsync(id);
        //    if (device == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Devices.Remove(device);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool DeviceExists(int id)
        {
            return _context.Devices.Any(e => e.Id == id);
        }
    }
}
