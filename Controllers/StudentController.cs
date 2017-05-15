using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using AspNetCoreHelloWorld.Models;

namespace AspNetCoreHelloWorld.Controllers
{
    public class StudentController : Controller
    {
        private readonly SchoolContext contexto;

        public StudentController(SchoolContext context)
        {
            contexto = context;
        }

        public IList<Student> Index()
        {
            return contexto.Students.ToList();
        }
    }
}