﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rentACar.Application.Features.Brands.Commands.CreateBrand;
using rentACar.Application.Features.Brands.Dtos;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        [HttpPost]
        public async Task<ActionResult> Add([FromBody] CreateBrandCommand createBrandCommand)
        {
            CreatedBrandDto result = await Mediator.Send(createBrandCommand);
            return Created("",result);
        }
    }
}
