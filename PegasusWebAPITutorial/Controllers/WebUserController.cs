using Microsoft.AspNetCore.Mvc;
using PegasusWebAPITutorial.Models;

namespace PegasusWebAPITutorial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebUserController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAllWebUsers()
        {
            List<WebUser> webUsers = new List<WebUser>();
            webUsers.Add(new WebUser()
            {
                Id = 1,
                Name = "Çağatay",
                Surname = "Yıldız",
                Email = "cagatay@mail.com",
            });

            webUsers.Add(new WebUser()
            {
                Id = 2,
                Name = "Müge",
                Surname = "Çalışkan",
                Email = "muge@pegasus.com",
            });

            return Ok(webUsers);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetWebUserById(int id)
        {
            List<WebUser> webUsers = new List<WebUser>();
            webUsers.Add(new WebUser()
            {
                Id = 1,
                Name = "Çağatay",
                Surname = "Yıldız",
                Email = "cagatay@mail.com",
            });

            webUsers.Add(new WebUser()
            {
                Id = 2,
                Name = "Müge",
                Surname = "Çalışkan",
                Email = "muge@pegasus.com",
            });


            var webuser = webUsers.FirstOrDefault(q => q.Id == id);

            if(webuser != null)
            {
                return Ok(webuser);
            }
            else
            {
                return NotFound("Webuser not found!");
            }
          

        }


        [HttpPost]
        public IActionResult AddNewWebUser(WebUser webUser)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteWebUserById(int id) 
        {
            //delete operations...

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateWebUser(WebUser webUser)
        {
            //update operations...
            return Ok();
        }

    }
}
