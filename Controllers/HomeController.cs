using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Microsoft.AspNetCore.Mvc;
using ModelValidationExample.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModelValidationExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("signup")]
        public IActionResult Index(Person person)
        {
            if (!ModelState.IsValid)
            {
                ////creating list of array to display at the end.
                //List<string> errorList = new List<string>();
                ////running loop on all the values in the models
                //foreach (var value in ModelState.Values)
                //{
                //    //checking if the any values having errors 
                //    foreach (var error in value.Errors)
                //    {
                //        errorList.Add(error.ErrorMessage);
                //    }
                //}
                //string errors = string.Join("\n", errorList);



                //////////////////////
                // LINQ Query Way

               string errors = string.Join("/n", ModelState.Values.SelectMany(value =>
                value.Errors).Select(err => err.ErrorMessage));

                return BadRequest(errors);
            }
            return Content($"{person}");
        }
    }
}

