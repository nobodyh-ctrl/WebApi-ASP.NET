using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monitoreo.WebApi.Controllers.Contracts;
using Monitoreo.WebApi.Data;
using System.Transactions;

namespace Monitoreo.WebApi.Controllers
{
    [Route("api/monitoreo")] //atributos
    [ApiController] //atributos
    public class MonitoreoController : ControllerBase
    {
        [HttpPost]
        [Route("device")]
        public IActionResult SaveDevice(
            [FromServices] DataContext data,
            [FromBody] DeviceDto dto
            )
        {
            var entity = data.Devices.Where(x => x.Name == dto.Name).OrderBy(x=>x.Id).FirstOrDefault();
            if(entity == null)
            {
                entity = new Data.Entities.Devices();
            }

            entity.Name = dto.Name;
            entity.Alias = dto.Alias;
            entity.Community = dto.Community;
            entity.Disabled = 0;
            entity.Deleted = 0;


            data.Devices.Update(entity);
            data.SaveChanges();

            return Ok("Salio todo bien");
        }
    }
}
