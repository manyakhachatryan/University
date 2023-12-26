using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data.Common;
using BusinessLayer.Entities;
using university.Models.Requests.StudentsReq;

namespace university.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddStudentReqM model)
        {
            Student student = await new Student()
            {
                StudentID = model.StudentID,
                StudentFirstName = model.StudentFirstName,
                StudentLastName = model.StudentLastName,
                StudentUniversityID = model.StudentUniversityID,
            }.AddAsync();

            if (student.StudentID == null)
            {
                return BadRequest("Duplicate ID");
            }

            return Ok(student);
        }

        // GET: api/<StudentController>
        [HttpGet]
        public async Task<IActionResult> Get(int? StudentID = null, string? StudentFirstName = null, string? StudentLastName = null, int? StudentUniversityID = null)
        {
            List<Student> students = await new Student().GetListAsync(StudentID, StudentFirstName, StudentLastName, StudentUniversityID);

            if(students.Count==0)
            {
                return NotFound();
            }

            return Ok(students);
        }

    }
}






//----------------------------------------------------------------------------

/*   // GET: api/<StudentController>
   [HttpGet]*/
/*  public List<Student> Get(int? id = null, string? StudentFirstName = null, string? StudentLastName = null, int? StudentUniversityID = null)
  {
      Console.WriteLine("[{0}]", StudentFirstName);
      string connStr = Config.ConnectionString;
      List<Student> students = new List<Student>();
      MySqlConnection conn = new MySqlConnection(connStr);
      try
      {
          Console.WriteLine("Connecting to MySQL...");
          conn.Open();
          DbCommand cmd = conn.CreateCommand();
          cmd.CommandType = System.Data.CommandType.StoredProcedure;
          cmd.CommandText = "get_student";
          MySqlParameter par = new MySqlParameter
          {
              ParameterName = "id",
              Value = id,
          };
          cmd.Parameters.Add(par);

         MySqlParameter par1 = new MySqlParameter
         {
              ParameterName = "StudentFirstName",
              Value = StudentFirstName,
         };
          cmd.Parameters.Add(par1);

          MySqlParameter par2 = new MySqlParameter
          {
              ParameterName = "StudentLastName",
              Value = StudentLastName,
          };
          cmd.Parameters.Add(par2);

          MySqlParameter par3 = new MySqlParameter
          {
              ParameterName = "StudentUniversityID",
              Value = StudentUniversityID,
          };
          cmd.Parameters.Add(par3);


          *//*  MySqlParameter par2 = new MySqlParameter
           {

               ParameterName = "lastname",
               Value = lastName,
           };
           cmd.Parameters.Add(par2);
           MySqlParameter par3 = new MySqlParameter
           {

               ParameterName = "uid",
               Value = universityId,
           };
           cmd.Parameters.Add(par3);*//*

          using (DbDataReader reader = cmd.ExecuteReader())
          {
              while (reader.Read())
              {
                  Student student = new Student();
                  student.StudentID = Convert.ToInt32(reader[0]);
                  student.StudentFirstName = Convert.ToString(reader[1]);
                  student.StudentLastName = Convert.ToString(reader[2]);
                  student.StudentUniversityID = Convert.ToInt32(reader[3]);
                  students.Add(student);


              }

          }
      }
      catch (Exception ex)
      {
          Console.WriteLine(ex.ToString());
      }
      conn.Close();
      return students;
  }*/


// GET: api/<StudentController>


// DELETE api/<ValuesController>/5
/*        [HttpDelete()]
        public void Delete(int id)
        {
            string connStr = Config.ConnectionString;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                DbCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"DELETE FROM Student WHERE StudentID={id};";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

        }*/



/*
        [HttpPost]
        public void Add([FromBody] AddStudentReqM model)
        {
            string connStr = Config.ConnectionString;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                DbCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                MySqlParameter par = new MySqlParameter
                {
                    ParameterName = "StudentID",
                    Value = model.StudentID,
                };
                cmd.Parameters.Add(par);

                MySqlParameter par1 = new MySqlParameter
                {
                    ParameterName = "StudentFirstName",
                    Value = model.StudentFirstName,
                };
                cmd.Parameters.Add(par1);

                MySqlParameter par2 = new MySqlParameter
                {
                    ParameterName = "StudentLastName",
                    Value = model.StudentLastName,
                };
                cmd.Parameters.Add(par2);

                MySqlParameter par3 = new MySqlParameter
                {
                    ParameterName = "StudentuniversityID",
                    Value = model.StudentUniversityID,
                };
                cmd.Parameters.Add(par3);

                cmd.CommandText = "add_student";

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }
*/

/*
        [HttpPatch]
        public void Update([FromBody] UpdateStudentReqM model)
        {

            string connStr = Config.ConnectionString;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                DbCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                MySqlParameter par = new MySqlParameter
                {
                    ParameterName = "StudentID",
                    Value = model.StudentId,
                };
                cmd.Parameters.Add(par);

                MySqlParameter par1 = new MySqlParameter
                {
                    ParameterName = "StudentFirstName",
                    Value = model.StudentFirstName,
                };
                cmd.Parameters.Add(par1);

                MySqlParameter par2 = new MySqlParameter
                {
                    ParameterName = "StudentLastName",
                    Value = model.StudentLastName,
                };
                cmd.Parameters.Add(par2);

                MySqlParameter par3 = new MySqlParameter
                {
                    ParameterName = "StudentuniversityID",
                    Value = model.StudentUniversityID,
                };
                cmd.Parameters.Add(par3);

                cmd.CommandText = "update_studentById";

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }*/


