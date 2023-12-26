using DataAccessLayer.DBTools;
using DataAccessLayer.Interfaces;


namespace BusinessLayer.Entities
{
    public class Student : IErrMsg
    {
        public int? StudentID { get; set; }
        public string? StudentFirstName { get; set; }
        public string? StudentLastName { get; set; }
        public int? StudentUniversityID { get; set; }
        string IErrMsg.ErrMsg { get; set; }
        public uint? RowCount { get; set; }

        public Student() { }
        public Student(int? studentID = null, string? firstName = null, string? lastName = null, int? uID = null)
        {
            StudentID = studentID;
            StudentFirstName = firstName;
            StudentLastName = lastName;
            StudentUniversityID = uID;
        }


        public async Task<Student> AddAsync()
        {
            try
            {

                List<SPParam> par = new List<SPParam>
                {
                    new SPParam("StudentID",this.StudentID),
                    new SPParam("StudentFirstName",this.StudentFirstName),
                    new SPParam("StudentLastName",this.StudentLastName),
                    new SPParam("StudentUniversityID",this.StudentUniversityID),
                };
                Student item = await MySQLDataAccess<Student>.ExecuteSPItemAsync("add_student", par);

                return item;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Func: Session.AddAsync, Ex:{ex.Message}");
                return null;
            }
            finally
            {
            }
        }


        public  async Task<List<Student>> GetListAsync(int? StudentID = null, string? StudentFirstName = null, string? StudentLastName = null, int? StudentUniversityID = null)
        {
            try
            {
                List<SPParam> par = new List<SPParam>
                {
                    new SPParam("StudentID",StudentID),
                    new SPParam("StudentFirstName",StudentFirstName),
                    new SPParam("StudentLastName",StudentLastName ),
                    new SPParam("StudentUniversityID",StudentUniversityID )
                };
                List<Student> list = new List<Student>();
                
                (list, RowCount) = await MySQLDataAccess<Student>.ExecuteSPListByPagingAsync("get_student", par);
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Func: Game.GetListAsync, Ex:{ex.Message}");
                return null;
            }
            finally
            {
            }
        }

    }
}
