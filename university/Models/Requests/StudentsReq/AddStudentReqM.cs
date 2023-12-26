namespace university.Models.Requests.StudentsReq
{
    public class AddStudentReqM
    {
        public int? StudentID { get; set; }
        public string? StudentFirstName { get; set; }
        public string? StudentLastName { get; set; }
        public int? StudentUniversityID { get; set; }
    }
}
