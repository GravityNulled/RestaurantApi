using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantApi.DTOs;
using RestaurantApi.Interfaces;
using RestaurantApi.Models;

namespace RestaurantApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderMasterController : ControllerBase
    {
        private readonly IMasterDetailRepository _repository;
        private readonly IMapper _mapper;

        public OrderMasterController(IMasterDetailRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadOrderMasterDto>>> GetAll()
        {
            var orderMaster = await _repository.GetAll();
            var read = _mapper.Map<IEnumerable<ReadOrderMasterDto>>(orderMaster);
            return Ok(read);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ReadOrderMasterDto>> GetById(int id)
        {
            var orderMaster = await _repository.GetByIdAsync(id);
            var read = _mapper.Map<ReadOrderMasterDto>(orderMaster);
            return Ok(read);
        }

        [HttpPost]
        public async Task<ActionResult<ReadOrderMasterDto>> Post(CreateOrderMasterDto createOrderMasterDto)
        {
            var order = _mapper.Map<OrderMaster>(createOrderMasterDto);
            var orderMasterPosted = await _repository.SaveAsync(order);
            //To

            var toRead = _mapper.Map<ReadOrderMasterDto>(orderMasterPosted);
            return CreatedAtAction("GetById", new { id = toRead.OrderMasterId }, toRead);
        }
    }
}