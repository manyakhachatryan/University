using DataAccessLayer.DBTools;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;


namespace university.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {

        
        [HttpGet]
        public IEnumerable<string> Get()
        {

  
            return new string[] { "Grade1", "Grade2" };
        }

        /* // GET: api/<ValuesController>
         [HttpGet]
         public IEnumerable<string> Get()
         {
             return new string[] { "value1", "value2" };
         }

         // GET api/<ValuesController>/5
         [HttpGet("{id}")]
         public string Get(int id)
         {
             return "value";
         }

         // POST api/<ValuesController>
         [HttpPost]
         public void Post([FromBody] string value)
         {
         }

         // PUT api/<ValuesController>/5
         [HttpPut("{id}")]
         public void Put(int id, [FromBody] string value)
         {
         }

         // DELETE api/<ValuesController>/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {
         }*/
    }
}




/*public static async Task<T> ExecuteSPItemAsync(string procedureName, List<SPParam> parameters = null, string db = null)
{
    T t = new T();
    try
    {
        using (MySqlConnection connection = new MySqlConnection(db ?? DBConfig.ConnectionString))
        {
            await connection.OpenAsync();
            using (DbCommand cmd = connection.CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = procedureName;

                for (int i = 0; i < parameters?.Count; i++)
                {
                    MySqlParameter par = new MySqlParameter
                    {
                        ParameterName = parameters[i].Name,
                        Value = parameters[i].Value
                    };
                    cmd.Parameters.Add(par);
                }
                using (DbDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        return Read(reader);
                    }
                }
            }
        }
        return t;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception ex sp:{procedureName}, ErrMsg:{ex.Message}");
        // T t = new T(); 
        t.ErrMsg = ex.Message;
        return t;
    }
}*/





/*public static async Task<List<T>> ExecuteSPListAsync(string procedureName, List<SPParam> parameters = null, string db = null)
{
    try
    {
        List<T> list = new List<T>();
        using (MySqlConnection connection = new MySqlConnection(db ?? DBConfig.ConnectionString))
        {
            await connection.OpenAsync();
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            using (DbCommand cmd = connection.CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = procedureName;
                for (int i = 0; i < parameters?.Count; i++)
                {
                    MySqlParameter par = new MySqlParameter
                    {
                        ParameterName = parameters[i].Name,
                        Value = parameters[i].Value
                    };
                    cmd.Parameters.Add(par);
                }

                using (DbDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        T item = Read(reader);
                        list.Add(item);
                    }
                }
            }
            return list;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception ex sp:{procedureName}, ErrMsg:{ex.Message}");
        return null;
    }
}*/