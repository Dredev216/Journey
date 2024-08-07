﻿using Journey.Application.UseCases.Trips.Register;
using Journey.Communication.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Journey.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterTripJson request)
        {
            try
            {
                var useCase = new RegisterTripUseCase();

                useCase.Execute(request);

                return Created();
            }
            catch
            {
                
            }
            
        }
    }
}
