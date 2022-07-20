using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task4.Models;
using Task4.Repo; 

namespace Task4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<User>> GetAll()
        {
            return UserRepo.GetAll();

        }
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var user = UserRepo.Get(id); 
            if (user == null)
                return NotFound();
            return user;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var user = UserRepo.Get(id);
            if (user == null)
                return NotFound();
            UserRepo.Delete(id);
            return Ok();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            UserRepo.Add(user);
            return Ok();
        }

        [HttpPut]
        public ActionResult Update(User user)
        {
            var _user = UserRepo.Get(user.id);
            if (_user == null)
                return NotFound();
            UserRepo.Update(user);
            return Ok();

        }

    }
}
