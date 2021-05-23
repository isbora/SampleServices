using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/service")]
    [ApiController]
    public class Client : ControllerBase
    {
        [HttpGet]
        public IActionResult GetClientList()
        {
            Student s1 = new Student() { Id = Guid.NewGuid(), FullName = "Jack Black", Grade = 3.12M };
            Student s2 = new Student() { Id = Guid.NewGuid(), FullName = "Jane White", Grade = 2.47M };

            List<Student> products = new List<Student>();
            products.Add(s1);
            products.Add(s2);

            return Ok(products);
        }
    }
}
