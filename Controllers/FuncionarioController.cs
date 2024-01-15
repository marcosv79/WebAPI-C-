using ISI_WebAPI.Models;
using ISI_WebAPI.Service.FuncionarioService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISI_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionario _funcionarioInterface;
        // injeção de dependência (a referência à variável só pode ser atribuída durante a inicialização)
        // ao criar FuncionarioController é fornecida a implementação de IFuncionario
        public FuncionarioController(IFuncionario funcionarioInterface)
        {
            _funcionarioInterface = funcionarioInterface;
        }

        /// <summary>
        /// Devolve todos os funcionários existentes
        /// </summary>
        /// <returns>Dados dos funcionários</returns>
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetFuncionarios()
        {
            return Ok(await _funcionarioInterface.GetFuncionarios());
        }

        /// <summary>
        /// Devolve um funcionário com base no id fornecido
        /// </summary>
        /// <param name="id">ID de um funcionário</param>
        /// <returns>Dados de um funcionário</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<FuncionarioModel>>> GetFuncionarioById(int id)
        {
            ServiceResponse<FuncionarioModel> serviceResponse = await _funcionarioInterface.GetFuncionarioById(id);
            return Ok(serviceResponse);
        }

        /// <summary>
        /// Cria um novo funcionário
        /// </summary>
        /// <remarks>
        /// { "id": 0, "nome": "string", "apelido": "string", "departamento": "RH", "ativo": true, "turno": "Manhã", "dataCriacao": "2023-12-21T18:50:09.900Z", "dataAlteracao": "2023-12-21T18:50:09.900Z" }
        /// </remarks>
        /// <param name="newFuncionario">Dados do novo funcionário</param>
        /// <returns>Funcionário criado</returns>
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> CreateFuncionario(FuncionarioModel newFuncionario)
        {
            return Ok(await _funcionarioInterface.CreateFuncionario(newFuncionario));
        }

        /// <summary>
        /// Atualiza dados de um funcionário
        /// </summary>
        /// <remarks>
        /// { "id": 0, "nome": "string", "apelido": "string", "departamento": "RH", "ativo": true, "turno": "Manhã", "dataCriacao": "2023-12-21T18:50:09.900Z", "dataAlteracao": "2023-12-21T18:50:09.900Z" }
        /// </remarks>
        /// <param name="editFuncionario">Dados do funcionário atualizado</param>
        /// <returns>Funcionário atualizado</returns>
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> UpdateFuncionario(FuncionarioModel editFuncionario)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.UpdateFuncionario(editFuncionario);
            return Ok(serviceResponse);
        }

        /// <summary>
        /// Inativa um funcionário
        /// </summary>
        /// <param name="id">ID de um funcionário</param>
        /// <returns>Funcionário inativo</returns>
        [HttpPut("inativaFuncionario/{id}")]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> InativaFuncionario(int id)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.InativaFuncionario(id);
            return Ok(serviceResponse);
        }

        /// <summary>
        /// Remove um funcionário
        /// </summary>
        /// <param name="id">ID de um funcionário</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> DeleteFuncionario(int id)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.DeleteFuncionario(id);
            return Ok(serviceResponse);
        }
    }
}
