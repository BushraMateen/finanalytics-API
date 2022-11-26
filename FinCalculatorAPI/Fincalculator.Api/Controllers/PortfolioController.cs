using FinCalculator.Application.Features.Porfolioes.Commands.CreatePortfolio;
using FinCalculator.Application.Features.Porfolioes.Commands.UpdatePortfolio;
using FinCalculator.Application.Features.Porfolioes.Commands.DeletePortfolio;
using FinCalculator.Application.Features.Porfolioes.Queries.GetPortfolioDetails;
using FinCalculator.Application.Features.Porfolioes.Queries.GetPortfolioList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using FinCalculator.Application.Features.Porfolioes.Queries.GetPortfolioInfo;
using FinCalculator.Application.Features.Porfolioes.Queries.GetSearchPortfolio;

namespace Fincalculator.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PortfolioController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PortfolioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllPortfolioes")]
        public async Task<ActionResult<List<PortfolioListVm>>> GetAllPortfolioes()
        {
            var dtos = await _mediator.Send(new GetPortfolioListQuery());
            return Ok(dtos);
        }

        [HttpGet("info", Name = "GetAllPortfolioInfo")]
        public async Task<ActionResult<List<PortfolioInfoVm>>> GetAllPortfolioInfo()
        {
            var dtos = await _mediator.Send(new GetPortfolioInfoQuery());
            return Ok(dtos);
        }


        [HttpGet("{id}", Name = "GetPortfolioDetails")]
        public async Task<ActionResult<List<PortfolioDetailVm>>> GetPortfolioDetails(int id)
        {
            var getPortfolioDetailQuery = new GetPortfolioDetailQuery() { Id = id };

            var dtos = await _mediator.Send(getPortfolioDetailQuery);

            return Ok(dtos);
        }

        [HttpPost(Name = "AddPortfolio")]
        public async Task<ActionResult<int>> Create([FromBody] CreatePortfolioCommand createPortfolioCommand)
        {
            var id = await _mediator.Send(createPortfolioCommand);
            return Ok(id);
        }

      [HttpPut(Name = "UpdatePortfolio")]
        public async Task<ActionResult> Update([FromBody] UpdatePortfolioCommand updatePortfolioCommand)
        {
            await _mediator.Send(updatePortfolioCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeletePortfolio")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletePortfolioCommand = new DeletePortfolioCommand() { PortfolioId = id };

            await _mediator.Send(deletePortfolioCommand);

            return NoContent();
        }

        [HttpGet]
        public async Task<ActionResult<List<string>>> GetSearchResult(string query)
        {
            var getSearchQuery = new GetSearchQuery() { Query = query };

            var dtos = await _mediator.Send(getSearchQuery);

            return (dtos);

        }
    }
 
}
