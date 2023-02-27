using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repositories.Interfaces;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly IMapper _mapper;

        public IRegionRepository _regionRepository { get; }
        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            _regionRepository = regionRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task <IActionResult> GetAllRegions()
        {
            var regions = await  _regionRepository.GetAllAsync();
            var regionsDto = _mapper.Map<List<Models.DTO.Region>>(regions);
      
            return Ok(regionsDto);
        }

        //[HttpGet]
        //public IActionResult GetRegions()
        //{
        //    var regions = _regionRepository.GetAll();
        //    var regionsDto = new List<NZWalks.API.Models.DTO.Region>();
        //    foreach (var region in regions)
        //    {
        //        var regionDTO = new Models.DTO.Region
        //        {
        //            Id = region.Id,
        //            Name = region.Name,
        //            Area = region.Area,
        //            Code = region.Code,
        //            Lat = region.Lat,
        //            Long = region.Long,
        //            Population = region.Population
        //        };
        //        regionsDto.Add(regionDTO);
        //    }
        //    return Ok(regionsDto);
        //}
        //[HttpGet]
        //public IActionResult GetRegions()
        //{
        //    var regions = _regionRepository.GetAll();
        //    var regionsDto = new List<NZWalks.API.Models.DTO.Region>();
        //    foreach (var region in regions)
        //    {
        //        var regionDTO = new Models.DTO.Region
        //        {
        //            Id = region.Id,
        //            Name = region.Name,
        //            Area = region.Area,
        //            Code = region.Code,
        //            Lat = region.Lat,
        //            Long = region.Long,
        //            Population = region.Population
        //        };
        //        regionsDto.Add(regionDTO);
        //    }
        //    return Ok(regions);
        //}
    }
}
