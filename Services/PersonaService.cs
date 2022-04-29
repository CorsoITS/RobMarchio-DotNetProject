using ProjWork.persona.repository;

namespace ProjWork.persona.service;

public class PersonaService
{

    private PersonaRepository personaRepository = new PersonaRepository();

    public IEnumerable<Persona> GetPeople()
    {
        return personaRepository.GetPeople();
    }

    public Persona GetPersona(int id)
    {
        return personaRepository.GetPersona(id);
    }

    public bool Create(Persona persona)
    {
        if (personaRepository.GetPersona(persona.id) == null)
        {if ((persona.nome == null) || (persona.cognome == null) || (persona.codice_fiscale == null)) 
            {
            return false;
            } 
            else if ((persona.nome.Length < 1) || (persona.cognome.Length < 1) || (persona.codice_fiscale.Length < 15))
            {
                return false;
            }
            else
            {
                return personaRepository.Create(persona);
            }
        }
        else
        {
            return false;
        }

    }

    public bool Update(Persona persona)
    {
        return personaRepository.Update(persona);
    }

    public bool Delete(int id)
    {
        return personaRepository.Delete(id);
    }

}