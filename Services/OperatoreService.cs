using ProjWork.operatore.repository;
using ProjWork.sede.repository;

namespace ProjWork.operatore.service;

public class OperatoreService
{

    private OperatoreRepository operatoreRepository = new OperatoreRepository();

// per usare sedeRepo e fare il check della sede, non basta lo using namespace, 
// ma devo istanziare anche l'oggetto prima, altrimenti non posso usarlo. 
    private SedeRepository sedeRepo = new SedeRepository();
    public IEnumerable<Operatore> GetOperatori()
    {
        return operatoreRepository.GetOperatori();
    }

    public Operatore GetOperatore(int id)
    {
        return operatoreRepository.GetOperatore(id);
    }

    public bool Create(Operatore operatore)
    {
    if (operatoreRepository.GetOperatore(operatore.id) == null) {
            if (sedeRepo.GetSede(operatore.sede_id) == null) {
                return false;    
        } else if ((operatore.nome == null) || 
        (operatore.cognome == null) || 
        (operatore.username == null) || 
        (operatore.password == null)) 
            {
            return false;
            } 
            else if ((operatore.nome.Length < 1) || 
            (operatore.cognome.Length < 1) || 
            (operatore.username.Length < 1) || 
            (operatore.password.Length < 1))
            {
                return false;
            }
            else
            {
                return operatoreRepository.Create(operatore);
            } 
    }    
    else
    {
        return false;
    }

    }

    public bool Update(Operatore operatore)
    {
        return operatoreRepository.Update(operatore);
    }

    public bool Delete(int id)
    {
        return operatoreRepository.Delete(id);
    }

}