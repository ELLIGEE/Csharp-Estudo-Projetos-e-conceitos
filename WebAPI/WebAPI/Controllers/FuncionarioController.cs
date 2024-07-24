using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Service.FuncionarioService;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioInterface _IFuncionarioInterface;

        public FuncionarioController(IFuncionarioInterface funcionarioInterface) {
            _IFuncionarioInterface = funcionarioInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetFuncionario()
        {
            return Ok(await _IFuncionarioInterface.GetFuncionarios());
        }

       [HttpGet("{id}")]
       public async Task<ActionResult<ServiceResponse<FuncionarioModel>>> getFuncionarioById(int id)
        {
            ServiceResponse<FuncionarioModel> serviceResponse = await _IFuncionarioInterface.GetFuncionarioById(id);

            return Ok(serviceResponse);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> CreateFuncionario(FuncionarioModel novoFuncionario)
        {
            return Created(String.Empty, await _IFuncionarioInterface.CreateFuncionario(novoFuncionario));
        }


        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> UpdateFuncionario(FuncionarioModel editadoFuncionario)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _IFuncionarioInterface.UpdateFuncionario(editadoFuncionario);

            return Ok(serviceResponse);
        }


        
        [HttpPut("inativarFuncionario")]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> InativarFuncionario(int id)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _IFuncionarioInterface.InativaFuncionario(id);

            return Ok(serviceResponse);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> DeleteFuncionario(int id){
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _IFuncionarioInterface.DeleteFuncionario(id);

            return Ok(serviceResponse);
        }


    }
}
