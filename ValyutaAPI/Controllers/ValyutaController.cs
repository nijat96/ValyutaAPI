using Business;
using DTO.DTOEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ValyutaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValyutaController : ControllerBase
    {
        private readonly IValyutaService _valyutaService;

        public ValyutaController(IValyutaService valyutaService)
        {
            _valyutaService = valyutaService;
        }

        //Data Getirmek

        [HttpGet]
        public IActionResult Get()
        {
            var values=_valyutaService.GetAll();
            return Ok(values);
        }

        //Id Getmek
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            var values = _valyutaService.GetById(id);
            return Ok(values);
        }

        //Elave etmek
        [HttpPost]
        public IActionResult Add(ValyutaDTO p)
        {
            string answer = "Data add successfully";

            p.YenilemeTarixi = DateTime.Now;
            _valyutaService.Insert(p);
            return Ok(answer);
        }

        //Redakte etmek
        [HttpPut]
        public IActionResult Update(ValyutaDTO p)
        {
            string answer = "Data update successfully";

            p.YenilemeTarixi = DateTime.Now;
            _valyutaService.Update(p);
            return Ok(answer);
        }

        //Silmek
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            string answer = "Data delete successfully";

            _valyutaService.Delete(id);
            return Ok(answer);
        }
    }
}
