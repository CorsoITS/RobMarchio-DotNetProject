using ProjWork.somministrazione.repository;
using ProjWork.operatore.repository;
using ProjWork.persona.repository;

namespace ProjWork.somministrazione.service;





public class SomministrazioneService
{

    private SomministrazioneRepository somministrazioneRepository = new SomministrazioneRepository();

// per usare PersonaRepo e OperatoreRepo non basta using namespace... 
// ma devo istanziare anche l'oggetto prima, altrimenti non posso usarlo. 
    private PersonaRepository personaRepo = new PersonaRepository();
    private OperatoreRepository operatoreRepo = new OperatoreRepository();

    public IEnumerable<Somministrazione> GetSomministrazioni()
    {
        return somministrazioneRepository.GetSomministrazioni();
    }

    public Somministrazione GetSomministrazione(int id)
    {
        return somministrazioneRepository.GetSomministrazione(id);
    }

    public IEnumerable<Somministrazione> GetSomministrazioneByTipo(string vaccino)
    {
        return somministrazioneRepository.GetSomministrazioneByTipo(vaccino);
    }


    public IEnumerable<Somministrazione> GetSomministrazioneByDose(string dose)
    {
        return somministrazioneRepository.GetSomministrazioneByDose(dose);
    }


    public IEnumerable<Somministrazione> GetSomministrazioneByUsername(string username)
    {
        return somministrazioneRepository.GetSomministrazioneByUsername(username);
    }


    public IEnumerable<Somministrazione> GetSomministrazioneByCodFisc(string codice_fiscale)
    {
        return somministrazioneRepository.GetSomministrazioneByCodFisc(codice_fiscale);
    }

    public bool Create(Somministrazione somministrazione)
    {
        if (somministrazioneRepository.GetSomministrazione(somministrazione.id) == null)
        {if ((personaRepo.GetPersona(somministrazione.persona_id) == null) || 
        (operatoreRepo.GetOperatore(somministrazione.opertore_id) == null)) {
            return false;
        } else if ((somministrazione.dose == null) || 
        (somministrazione.vaccino == null) || 
        (somministrazione.data_somministrazione >= DateTime.Now)) {
            return false;
            } 
            else if ((somministrazione.dose.Length < 1) || (somministrazione.vaccino.Length < 1))
            {
                return false;
            }
            else
            {
                return somministrazioneRepository.Create(somministrazione);
            }
        }
        else
        {
            return false;
        }

    }

    public bool Update(Somministrazione somministrazione)
    {
        return somministrazioneRepository.Update(somministrazione);
    }

    public bool Delete(int id)
    {
        return somministrazioneRepository.Delete(id);
    }

}