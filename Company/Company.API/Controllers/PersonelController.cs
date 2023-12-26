using Company.API.CompanyHub;
using Company.Business.Abstract;
using Company.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Swashbuckle.AspNetCore.Annotations;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {
        private readonly IPersonelService _personelService;
        private readonly IHubContext<PersonelHub> _hubContext;

        public PersonelController(IPersonelService personelService, IHubContext<PersonelHub> hubContext)
        {
            _personelService = personelService;
            _hubContext = hubContext;
        }

        /// <summary>
        /// Returns a personel information.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The requested personel.</returns>

        [HttpGet("GetPersonel")]
        public async Task<IActionResult> GetPersonel(int id)
        {
            var personel = _personelService.GetById(id);
            return Ok(personel);
        }

        /// <summary>
        /// Returns a list of personels.
        /// </summary>
        /// <returns>The requested personel list.</returns>

        [HttpGet("GetPersonelList")]
        [SwaggerResponse(200, "Success")]
        [SwaggerResponse(404, "Not Found")]
        public async Task<IActionResult> GetPersonelList()
        {
            var personelList = _personelService.GetList();
            return Ok(personelList);
        }

        /// <summary>
        /// Creates a new personel registration.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>

        [HttpPost("AddPersonel")]
        [SwaggerResponse(200, "Success")]
        [SwaggerResponse(404, "Not Found")]
        public async Task<IActionResult> AddPersonelAsync([FromBody] Personel entity)
        {
            _personelService.Add(entity);

            await _hubContext.Clients.All.SendAsync("PersonelList");

            return Ok();
        }

        /// <summary>
        /// Updates a personel information.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>

        [HttpPost("UpdatePersonel")]
        [SwaggerResponse(200, "Success")]
        [SwaggerResponse(404, "Not Found")]
        public async Task<IActionResult> UpdatePersonelAsync([FromBody] Personel entity)
        {
            _personelService.Update(entity);

            await _hubContext.Clients.All.SendAsync("PersonelList");

            return Ok();
        }

        /// <summary>
        /// Deletes a personel information.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns> 

        [HttpDelete("DeletePersonel")]
        [SwaggerResponse(200, "Success")]
        [SwaggerResponse(404, "Not Found")]
        public async Task<IActionResult> DeletePersonelAsync(int id)
        {
            _personelService.Delete(id);

            await _hubContext.Clients.All.SendAsync("PersonelList");

            return Ok();
        }

    }
}
