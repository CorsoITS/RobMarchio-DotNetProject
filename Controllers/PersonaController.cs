using Microsoft.AspNetCore.Mvc;
using ProjWork.persona.service;

namespace ProjWork.persona.controller;

[ApiController]
[Route("persona")]
public class PersonaController : ControllerBase
{

    private PersonaService personaService = new PersonaService();

    [HttpGet]
    public IEnumerable<Persona> GetPeople()
    {
        return personaService.GetPeople();
    }

    [HttpGet("{id}")]
    public Persona GetPersona(int id)
    {
        return personaService.GetPersona(id);
    }

    [HttpPost]
    public IActionResult Create(Persona persona)
    {
        var created = personaService.Create(persona);
        if (created)
        {
            return Ok();

        }
        else
        {
            return BadRequest("Hai sbagliato qualcosa, bestia, ricontrolla!");
        }
    }

    [HttpPut]
    public IActionResult Update(Persona persona)
    {
        var updated = personaService.Update(persona);
        if (updated)
        {
            return Ok();

        }
        else
        {
            return BadRequest();
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var deleted = personaService.Delete(id);
        if (deleted)
        {
            return Ok();

        }
        else
        {
            return BadRequest();
        }
    }
}