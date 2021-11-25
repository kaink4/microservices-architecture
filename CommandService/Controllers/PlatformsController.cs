using System;
using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers
{


    public class Sudoku
    {

    }



    public class AddressUnitedKingdom
    {

    }




    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {



        public PlatformsController(object service)
        {

        }


        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Inbound POST  # Command Service");

            return Ok("Inbound test of Platforms Controller");
        }
    }
}