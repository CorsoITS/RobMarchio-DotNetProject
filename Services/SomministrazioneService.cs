using ProjWork.somministrazione.repository;

namespace ProjWork.somministrazione.service;

public class SomministrazioneService
{

    private SomministrazioneRepository somministrazioneRepository = new SomministrazioneRepository();

    public IEnumerable<Somministrazione> GetSomministrazioni()
    {
        return somministrazioneRepository.GetSomministrazioni();
    }

    public Somministrazione GetSomministrazione(int id)
    {
        return somministrazioneRepository.GetSomministrazione(id);
    }

    public bool Create(Somministrazione somministrazione)
    {
        if (somministrazioneRepository.GetSomministrazione(somministrazione.id) == null)
        {if ((somministrazione.dose == null) || (somministrazione.vaccino == null)) 
            {
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