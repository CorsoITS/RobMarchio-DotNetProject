using  ProjWork.context;
using MySql.Data.MySqlClient;

namespace ProjWork.somministrazione.repository;

public class SomministrazioneRepository
{

    private AppDb appDb = new AppDb();

    public IEnumerable<Somministrazione> GetSomministrazioni()
    {
        var result = new List<Somministrazione>();

        appDb.Connection.Open();
        var command = appDb.Connection.CreateCommand();
        command.CommandText = "select id,vaccino,dose,data_somministrazione,note,opertore_id,persona_id from somministrazione";
        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var somministrazione = new Somministrazione()
            {
                id = reader.GetInt16("id"),
                vaccino = reader.GetString("vaccino"),
                dose = reader.GetString("dose"),
                data_somministrazione = reader.GetDateTime("data_somministrazione"), 
                note = reader.GetString("note"),
                opertore_id = reader.GetInt16("opertore_id"),
                persona_id = reader.GetInt16("persona_id")
            };
            result.Add(somministrazione);
        }
        appDb.Connection.Close();

        return result;
    }

    public Somministrazione GetSomministrazione(int? id)
    {
        appDb.Connection.Open();
        var command = appDb.Connection.CreateCommand();
        command.CommandText = "select id,vaccino,dose,data_somministrazione,note,opertore_id,persona_id from somministrazione where id=@id";
        var parameter = new MySqlParameter()
        {
            ParameterName = "id",
            DbType = System.Data.DbType.Int16,
            Value = id
        };
        command.Parameters.Add(parameter);
        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var somministrazione = new Somministrazione()
            {
                id = reader.GetInt16("id"),
                vaccino = reader.GetString("vaccino"),
                dose = reader.GetString("dose"),
                data_somministrazione = reader.GetDateTime("data_somministrazione"),
                note = reader.GetString("note"),
                opertore_id = reader.GetInt16("opertore_id"),
                persona_id = reader.GetInt16("persona_id")
            };
            appDb.Connection.Close();
            return somministrazione;
        }

        appDb.Connection.Close();
        return null;
    }


    public IEnumerable<Somministrazione> GetSomministrazioneByTipo(string vaccino)
    {   
        var result = new List<Somministrazione>();

        appDb.Connection.Open();
        var command = appDb.Connection.CreateCommand();
        command.CommandText = "select id,vaccino,dose,data_somministrazione,note,opertore_id,persona_id from somministrazione where vaccino=@vaccino";
        var parameter = new MySqlParameter()
        {
            ParameterName = "vaccino",
            DbType = System.Data.DbType.String,
            Value = vaccino
        };
        command.Parameters.Add(parameter);
        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var somministrazione = new Somministrazione()
            {
                id = reader.GetInt16("id"),
                vaccino = reader.GetString("vaccino"),
                dose = reader.GetString("dose"),
                data_somministrazione = reader.GetDateTime("data_somministrazione"), 
                note = reader.GetString("note"),
                opertore_id = reader.GetInt16("opertore_id"),
                persona_id = reader.GetInt16("persona_id")
            };
            result.Add(somministrazione);
        }
        appDb.Connection.Close();

        return result;
    }


    public IEnumerable<Somministrazione> GetSomministrazioneByDose(string dose)
    {   
        var result = new List<Somministrazione>();

        appDb.Connection.Open();
        var command = appDb.Connection.CreateCommand();
        command.CommandText = "select id,vaccino,dose,data_somministrazione,note,opertore_id,persona_id from somministrazione where dose=@dose";
        var parameter = new MySqlParameter()
        {
            ParameterName = "dose",
            DbType = System.Data.DbType.String,
            Value = dose
        };
        command.Parameters.Add(parameter);
        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var somministrazione = new Somministrazione()
            {
                id = reader.GetInt16("id"),
                vaccino = reader.GetString("vaccino"),
                dose = reader.GetString("dose"),
                data_somministrazione = reader.GetDateTime("data_somministrazione"), 
                note = reader.GetString("note"),
                opertore_id = reader.GetInt16("opertore_id"),
                persona_id = reader.GetInt16("persona_id")
            };
            result.Add(somministrazione);
        }
        appDb.Connection.Close();

        return result;
    }

    public IEnumerable<Somministrazione> GetSomministrazioneByUsername(string username)
    {   
        var result = new List<Somministrazione>();

        appDb.Connection.Open();
        var command = appDb.Connection.CreateCommand();
        command.CommandText = "select som.id,vaccino,dose,data_somministrazione,note,opertore_id,persona_id from somministrazione as som left join opertore as op on som.opertore_id = op.id where op.username=@username";
        var parameter = new MySqlParameter()
        {
            ParameterName = "username",
            DbType = System.Data.DbType.String,
            Value = username
        };
        command.Parameters.Add(parameter);
        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var somministrazione = new Somministrazione()
            {
                id = reader.GetInt16("id"),
                vaccino = reader.GetString("vaccino"),
                dose = reader.GetString("dose"),
                data_somministrazione = reader.GetDateTime("data_somministrazione"), 
                note = reader.GetString("note"),
                opertore_id = reader.GetInt16("opertore_id"),
                persona_id = reader.GetInt16("persona_id")
            };
            result.Add(somministrazione);
        }
        appDb.Connection.Close();

        return result;
    }


    public IEnumerable<Somministrazione> GetSomministrazioneByCodFisc(string codice_fiscale)
    {   
        var result = new List<Somministrazione>();

        appDb.Connection.Open();
        var command = appDb.Connection.CreateCommand();
        command.CommandText = "select som.id,vaccino,dose,data_somministrazione,note,opertore_id,persona_id from somministrazione as som left join persona as per on som.persona_id = per.id where per.codice_fiscale =@codice_fiscale";
        var parameter = new MySqlParameter()
        {
            ParameterName = "codice_fiscale",
            DbType = System.Data.DbType.String,
            Value = codice_fiscale
        };
        command.Parameters.Add(parameter);
        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var somministrazione = new Somministrazione()
            {
                id = reader.GetInt16("id"),
                vaccino = reader.GetString("vaccino"),
                dose = reader.GetString("dose"),
                data_somministrazione = reader.GetDateTime("data_somministrazione"), 
                note = reader.GetString("note"),
                opertore_id = reader.GetInt16("opertore_id"),
                persona_id = reader.GetInt16("persona_id")
            };
            result.Add(somministrazione);
        }
        appDb.Connection.Close();

        return result;
    }

    public bool Create(Somministrazione somministrazione)
    {
        appDb.Connection.Open();
        var command = appDb.Connection.CreateCommand();
        command.CommandText = "insert into somministrazione (vaccino, dose, data_somministrazione, note, opertore_id, persona_id) values (@vaccino,@dose,@data_somministrazione,@note,@opertore_id,@persona_id)";
        var parameterRuolo = new MySqlParameter()
        {
            ParameterName = "vaccino",
            DbType = System.Data.DbType.String,
            Value = somministrazione.vaccino
        };
        command.Parameters.Add(parameterRuolo);
        var parameterNome = new MySqlParameter()
        {
            ParameterName = "dose",
            DbType = System.Data.DbType.String,
            Value = somministrazione.dose
        };
        command.Parameters.Add(parameterNome);
        var parameterCognome = new MySqlParameter()
        {
            ParameterName = "data_somministrazione",
            DbType = System.Data.DbType.Date,
            Value = somministrazione.data_somministrazione
        };
        command.Parameters.Add(parameterCognome);
        var parameterUsername = new MySqlParameter()
        {
            ParameterName = "note",
            DbType = System.Data.DbType.String,
            Value = somministrazione.note
        };
        command.Parameters.Add(parameterUsername);
        var parameterPassword = new MySqlParameter()
        {
            ParameterName = "opertore_id",
            DbType = System.Data.DbType.Int16,
            Value = somministrazione.opertore_id
        };
        command.Parameters.Add(parameterPassword);
        var parameterSede_id = new MySqlParameter()
        {
            ParameterName = "persona_id",
            DbType = System.Data.DbType.Int16,
            Value = somministrazione.persona_id
        };
        command.Parameters.Add(parameterSede_id);
        var result = Convert.ToBoolean(command.ExecuteNonQuery());
        appDb.Connection.Close();
        return result;
    }

    public bool Update(Somministrazione somministrazione)
    {
        appDb.Connection.Open();
        var command = appDb.Connection.CreateCommand();
        command.CommandText = "update somministrazione set vaccino=@vaccino, dose=@dose,data_somministrazione=@data_somministrazione,note=@note, opertore_id=@opertore_id, persona_id=@persona_id where id=@id";
       var parameterid = new MySqlParameter()
        {
            ParameterName = "id",
            DbType = System.Data.DbType.Int16,
            Value = somministrazione.id
        };
        command.Parameters.Add(parameterid);
       var parameterVaccino = new MySqlParameter()
        {
            ParameterName = "vaccino",
            DbType = System.Data.DbType.String,
            Value = somministrazione.vaccino
        };
        command.Parameters.Add(parameterVaccino);
        var parameterDose = new MySqlParameter()
        {
            ParameterName = "dose",
            DbType = System.Data.DbType.String,
            Value = somministrazione.dose
        };
        command.Parameters.Add(parameterDose);
        var parameterData_somministrazione = new MySqlParameter()
        {
            ParameterName = "data_somministrazione",
            DbType = System.Data.DbType.Date,
            Value = somministrazione.data_somministrazione
        };
        command.Parameters.Add(parameterData_somministrazione);
        var parameterNote = new MySqlParameter()
        {
            ParameterName = "note",
            DbType = System.Data.DbType.String,
            Value = somministrazione.note
        };
        command.Parameters.Add(parameterNote);
        var parameterOperatore_id = new MySqlParameter()
        {
            ParameterName = "opertore_id",
            DbType = System.Data.DbType.String,
            Value = somministrazione.opertore_id
        };
        command.Parameters.Add(parameterOperatore_id);
        var parameterPersona_id = new MySqlParameter()
        {
            ParameterName = "persona_id",
            DbType = System.Data.DbType.Int16,
            Value = somministrazione.persona_id
        };
        command.Parameters.Add(parameterPersona_id);
        var result = Convert.ToBoolean(command.ExecuteNonQuery());
        appDb.Connection.Close();
        return result;
    }

    public bool Delete(int id)
    {
        appDb.Connection.Open();
        var command = appDb.Connection.CreateCommand();
        command.CommandText = "delete from somministrazione where id=@id";
        var parameterId = new MySqlParameter()
        {
            ParameterName = "id",
            DbType = System.Data.DbType.Int16,
            Value = id
        };
        command.Parameters.Add(parameterId);
        var result = Convert.ToBoolean(command.ExecuteNonQuery());
        appDb.Connection.Close();
        return result;
    }

}