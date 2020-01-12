using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Translator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TranslatorController : ControllerBase
    {
        private readonly WordRepository wordRepository = new WordRepository();

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Word> GetById(int id)
        {
            if (!wordRepository.TryGetProduct(id, out var product))
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public IEnumerable<Word> Post(Word entity)
        {

        }
    }
}
