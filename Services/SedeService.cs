using ProjWork.sede.repository;

namespace ProjWork.sede.service;

public class SedeService
{

    private SedeRepository sedeRepository = new SedeRepository();

    public IEnumerable<Sede> GetSedi()
    {
        return sedeRepository.GetSedi();
    }

    public Sede GetSede(int id)
    {
        return sedeRepository.GetSede(id);
    }

    public bool Create(Sede sede)
    {
        if (sedeRepository.GetSede(sede.id) == null)
        {if ((sede.nome == null) || (sede.citta == null) || (sede.indirizzo == null)) 
            {
            return false;
            } 
            else if ((sede.nome.Length < 1) || (sede.citta.Length < 1) || (sede.indirizzo.Length < 1))
            {
                return false;
            }
            else
            {
                return sedeRepository.Create(sede);
            }
        }
        else
        {
            return false;
        }

    }

    public bool Update(Sede sede)
    {
        return sedeRepository.Update(sede);
    }

    public bool Delete(int id)
    {
        return sedeRepository.Delete(id);
    }

}