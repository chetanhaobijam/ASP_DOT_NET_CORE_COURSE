using Models_In_ASP_Core.Models;

namespace Models_In_ASP_Core.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();
        StudentModel getStudentById(int id);
    }
}
