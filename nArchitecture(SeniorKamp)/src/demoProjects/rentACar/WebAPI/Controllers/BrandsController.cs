using Application.Features.Brands.Commands.CreateBrand;
using Application.Features.Brands.DTOs;
using Application.Features.Brands.Models;
using Application.Features.Brands.Queries.GetByIdBrand;
using Application.Features.Brands.Queries.GetListBrand;
using Core.Application.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        [HttpPost]
        //commandin maediator aracılığıyla handlesini bulması için görevlendiriyoruz
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand)
        {
            CreatedBrandDto result = await Mediator.Send(createBrandCommand);
            return Created("", result);
        }

        [HttpGet]
       
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListBrandQoery getListBrandQoery = new() { PageRequest = pageRequest };
            BrandListModel result = await Mediator.Send(getListBrandQoery);
            return Ok(result);  

        }
        [HttpGet("{Id}")]

        public async Task<IActionResult> GetById([FromRoute] GetByIdBrandQuery getByIdBrandQuery)
        {
          BrandGetByIdDto brandGetById=  await Mediator.Send(getByIdBrandQuery);
            return Ok(brandGetById);

        }
    }
}
