using Microsoft.AspNetCore.Mvc;
using ProjWork.somministrazione.service;

namespace ProjWork.somministrazione.controller;

[ApiController]
[Route("somministrazione")]
public class SomministrazioneController : ControllerBase
{

    private SomministrazioneService somministrazioneService = new SomministrazioneService();

    [HttpGet]
    public IEnumerable<Somministrazione> GetSomministrazioni()
    {
        return somministrazioneService.GetSomministrazioni();
    }

    [HttpGet("{id}")]
    public Somministrazione GetSomministrazione(int id)
    {
        return somministrazioneService.GetSomministrazione(id);
    }


    [HttpGet("/tipo/{vaccino}")]
    public IEnumerable<Somministrazione> GetSomministrazioneByTipo(string vaccino)
    {
        return somministrazioneService.GetSomministrazioneByTipo(vaccino);
    }

    [HttpGet("/dose/{dose}")]
    public IEnumerable<Somministrazione> GetSomministrazioneByDose(string dose)
    {
        return somministrazioneService.GetSomministrazioneByDose(dose);
    }

    [HttpGet("/usernameoperatore/{username}")]
    public IEnumerable<Somministrazione> GetSomministrazioneByUsername(string username)
    {
        return somministrazioneService.GetSomministrazioneByUsername(username);
    }

    [HttpGet("/codicefiscalepersona/{codice_fiscale}")]
    public IEnumerable<Somministrazione> GetSomministrazioneByCodFisc(string codice_fiscale)
    {//chiedere prof: come "castare" il badRequest qui dentro in caso di return vuoto dalla Repository? Booleano pefforza?
        return somministrazioneService.GetSomministrazioneByCodFisc(codice_fiscale);
    }


    [HttpPost]
    public IActionResult Create(Somministrazione somministrazione)
    {
        var created = somministrazioneService.Create(somministrazione);
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
    public IActionResult Update(Somministrazione somministrazione)
    {
        var updated = somministrazioneService.Update(somministrazione);
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
        var deleted = somministrazioneService.Delete(id);
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