using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Destiny.WebApi.Services;
using AutoMapper;
using Destiny.WebApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Destiny.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class WeaponsController : Controller
    {
        private IDestinyRepository _destinyRepository;

        public WeaponsController(IDestinyRepository destinyRepository)
        {
            _destinyRepository = destinyRepository;
        }

        [HttpGet]
        [Produces(typeof(List<WeaponDto>))]
        [SwaggerResponse((int)System.Net.HttpStatusCode.OK, Type = typeof(List<WeaponDto>))]
        public IActionResult Get()
        {
            var weaponEntities = _destinyRepository.GetWeapons();
            var results = Mapper.Map<IEnumerable<WeaponDto>>(weaponEntities);
            return Ok(results);
        }

        [HttpGet("{id}")]
        [Produces(typeof(WeaponDto))]
        [SwaggerResponse((int)System.Net.HttpStatusCode.OK, Type = typeof(WeaponDto))]
        public IActionResult Get(int id, bool includePerks)
        {
            var weapon = _destinyRepository.GetWeapon(id, includePerks);
            var result = Mapper.Map<WeaponDto>(weapon);
            return Ok(result);
        }
    }
}
