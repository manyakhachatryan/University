namespace university.Models.Requests.StudentsReq
{
    public class UpdateStudentReqM
    {
        public int? StudentId { get; set; }
        public string? StudentFirstName { get; set; } 
        public string? StudentLastName { get; set; }
        public int? StudentUniversityID { get; set; }
    }
}
