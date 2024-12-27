using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week_13_Dependency_Injection.Models;

namespace Week_13_Dependency_Injection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ClassRoom _clasroom;

        public TeacherController(ClassRoom classRoom)
        {
            _clasroom = classRoom;
        }

        [HttpGet]
        public IActionResult GetTeacher()
        {
            return Ok(_clasroom.GetTeacherInfo());
        }

    }
}