using Microsoft.AspNetCore.Mvc;
using OrganizationsService.Models;

namespace OrganizationsService.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class OrganizationsController : ControllerBase {
        private IOrganizationsRepository repository;

        public OrganizationsController(IOrganizationsRepository repo) {
            this.repository = repo;
        }

        [HttpGet]
        public void Get() {
            // Some code will be there
        }

        [HttpPost]
        public void Post() {
            // Some code will be there
        }

        [HttpPut]
        public void Put() {
            // Some code will be there
        }

        [HttpDelete]
        public void Delete() {
            // Some code will be there
        }
    }
}
