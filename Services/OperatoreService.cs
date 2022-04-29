using ProjWork.operatore.repository;

namespace ProjWork.operatore.service;

public class OperatoreService
{

    private OperatoreRepository operatoreRepository = new OperatoreRepository();

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
        if (operatoreRepository.GetOperatore(operatore.id) == null)
        {if ((operatore.nome == null) || (operatore.cognome == null) || (operatore.username == null) || (operatore.password == null)) 
            {
            return false;
            } 
            else if ((operatore.nome.Length < 1) || (operatore.cognome.Length < 1) || (operatore.username.Length < 1) || (operatore.password.Length < 1))
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