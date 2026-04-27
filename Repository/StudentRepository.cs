using Models_In_ASP_Core.Models;

namespace Models_In_ASP_Core.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();
        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel { rollNo = 1, Name = "Alice", Gender = "Female", Standard = 10 },
                new StudentModel { rollNo = 2, Name = "Bob", Gender = "Male", Standard = 9 },
                new StudentModel { rollNo = 3, Name = "Charlie", Gender = "Male", Standard = 8 },
                new StudentModel { rollNo = 4, Name = "Diana", Gender = "Female", Standard = 10 },
                new StudentModel { rollNo = 5, Name = "Ethan", Gender = "Male", Standard = 9 },
                new StudentModel { rollNo = 6, Name = "Fiona", Gender = "Female", Standard = 8 },
                new StudentModel { rollNo = 7, Name = "George", Gender = "Male", Standard = 10 },
                new StudentModel { rollNo = 8, Name = "Hannah", Gender = "Female", Standard = 9 },
                new StudentModel { rollNo = 9, Name = "Ivan", Gender = "Male", Standard = 8 },
                new StudentModel { rollNo = 10, Name = "Julia", Gender = "Female", Standard = 10 }
            };
        }
    }
}
