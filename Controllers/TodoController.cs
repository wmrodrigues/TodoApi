using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Models;

namespace TodoApi.Controllers 
{
    public class TodoController : ControllerBase
    {
        

        public TodoController(TodoContext context)
        {
        
        }
    }
}