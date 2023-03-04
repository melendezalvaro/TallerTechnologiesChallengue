using Microsoft.AspNetCore.Mvc;
using ServiceHost.Application;
using ServiceHost.Repository;

namespace ServiceHost.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        [Route("GetCars")]
        public ActionResult Get()
        {
            var response = _carRepository.Get();
            return Ok(response);
        }

        [HttpGet]
        [Route("GetCar/{id}")]
        public ActionResult GetById(int id)
        {
            var response = _carRepository.GetById(id);
            return Ok(response);
        }

        [HttpPost]
        [Route("CreateCar")]
        public ActionResult Create([FromBody] Car car)
        {
            _carRepository.Add(car);
            return Ok();
        }

        [HttpPut]
        [Route("UpdateCar")]
        public ActionResult Update([FromBody] Car car)
        {
            _carRepository.Update(car);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteCar/{id}")]
        public ActionResult Delete(int id)
        {
            _carRepository.Delete(id);
            return Ok();
        }
    }
}