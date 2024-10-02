using BL;
using DataBaseAccses.Invoice;
using Microsoft.AspNetCore.Mvc;
using Objects.Dtos.InvoiceDto;
using Objects.Models;
using Objects.Models.InvoiceModels;

namespace Store.Controllers
{
    [ApiController]
    [Route("api/[Controller]/[Action]")]
    public class InvoicesController : ControllerBase
    {
        private readonly InvoiceBL _invoiceBL;

        public InvoicesController()
        {
            _invoiceBL = new();
        }

        [HttpPost]
        public ActionResult Create(InvoiceDto inputFromUser)
        {
            var mappingFromDtoToInvocieModel = new InvoiceModel()
            {
                DueDate = inputFromUser.DueDate,
                Number = inputFromUser.Number,
                PersonName = inputFromUser.PersonName,
            };

            var resultFromBL = _invoiceBL.Create(mappingFromDtoToInvocieModel);

            var mappingFromModelToDto = new InvoiceDto()
            {
                DueDate = resultFromBL.DueDate,
                Number = resultFromBL.Number,
                PersonName = resultFromBL.PersonName,
            };

            return Ok(mappingFromModelToDto);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var resultFromBl = _invoiceBL.GetAll();

            var result = resultFromBl.Select(c => new InvoiceDto()
            {
                Id = c.Id,
                Number = c.Number,
                DueDate = c.DueDate,
                PersonName = c.PersonName,
                Total = c.Total,
            }).ToList();

            return Ok(result);
        }
    }
}
