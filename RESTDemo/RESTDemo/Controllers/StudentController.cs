using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTDemo.Models;
using RESTDemo.Services;
using System;
using System.Collections.Generic;

namespace RESTDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService service;

        public StudentController(IStudentService service)
        {
            this.service = service;
        }

        // GET
        //http://localhost:61778/api/Student/GetStudents
        [HttpGet]
        [Route("GetStudents")]
        public IActionResult Get()
        {
            try
            {
                var model = service.GetStudents();
                return new ObjectResult(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET http://localhost:61778/api/Student/GetStudentById/{rollNo}
        [HttpGet]
        [Route("GetStudentById/{rollNo}")]
        public IActionResult Get(int rollNo)
        {
            try
            {
                var model = service.GetStudentById(rollNo);
                if (model != null)
                {
                    return new ObjectResult(model);
                }
                else
                {
                    return StatusCode(StatusCodes.Status204NoContent);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET api/Student/GetStudentByBranch/{branch}
        [HttpGet]
        [Route("GetStudentByBranch/{branch}")]
        public IActionResult GetByBranch(string branch)
        {
            try
            {
                var model = service.GetStudentByBranch(branch);
                if (model != null)
                {
                    return new ObjectResult(model);
                }
                else
                {
                    return StatusCode(StatusCodes.Status204NoContent);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // POST =API => http://localhost:61778/api/Student/AddStudent
        [HttpPost]
        [Route("AddStudent")]
        public IActionResult Post([FromBody] Student student)
        {
            try
            {
                var res = service.AddStudent(student);
                if (res >= 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT api/Student/UpdateStudent
        [HttpPut]
        [Route("UpdateStudent")]
        public IActionResult Put([FromBody] Student student)
        {
            try
            {
                var res = service.UpdateStudent(student);
                if (res >= 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // DELETE api/Student/DeleteStudent/5
        [HttpDelete]
        [Route("DeleteStudent/{rollNo}")]
        public IActionResult Delete(int rollNo)
        {
            try
            {
                var res = service.DeleteStudent(rollNo);
                if (res >= 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
