using AdocaoAnimaisApi.Domain.DTO;
using AdocaoAnimaisApi.Domain.Entity;
using AdocaoAnimaisApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdocaoAnimaisApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : Controller
	{

		private readonly AnimalService animalService;

		public AnimalController(AnimalService animalService)
		{
			this.animalService = animalService;
		}

		[HttpGet]
		public IEnumerable<AdocaoResponse> Get()
		{
			return animalService.ListarTodos();
		}
		[HttpGet("{id}")]
		//public IActionResult GetById(int id)
		//{
		//	var retorno = animalService.PesquisarPorId(id);

		//	if (retorno.Sucesso)
		//	{
		//		return Ok(retorno.ObjetoRetorno);
		//	}
		//	else
		//	{
		//	return NotFound(retorno.Mensagem);
		//	}
		//}

		
		[HttpPost]
		// FromBody para indicar de o corpo da requisição deve ser mapeado para o modelo
		public IActionResult Post([FromBody] AdocaoCreateRequest postModel)
		{
			//Validação modelo de entrada
			if (ModelState.IsValid)
			{
				var retorno = animalService.CadastrarNovo(postModel);
				if (!retorno.Sucesso)
					return BadRequest(retorno.Mensagem);
				else
					return Ok(retorno);
			}
			else
			{
				return BadRequest(ModelState);
			}

		}

		[HttpPut("{IdAdocao}")]
		// FromBody para indicar de o corpo da requisição deve ser mapeado para o modelo
		public IActionResult Put(int id, [FromBody] AdocaoUpdateRequest putModel)
		{
			//Validação modelo de entrada
			if (ModelState.IsValid)
			{
				var retorno = animalService.Editar(id, putModel);
				if (!retorno.Sucesso)
					return BadRequest(retorno.Mensagem);
				return Ok(retorno.ObjetoRetorno);
			}
			else
			{
				return BadRequest(ModelState);
			}

		}

		[HttpDelete("{IdAdocao}")]
		// FromBody para indicar de o corpo da requisição deve ser mapeado para o modelo
		public IActionResult Delete(int id)
		{
			//Validação modelo de entrada
			var retorno = animalService.Deletar(id);
			if (!retorno.Sucesso)
				return BadRequest(retorno.Mensagem);
			return Ok();

		}

	}
}
