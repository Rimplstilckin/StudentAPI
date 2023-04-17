using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        int InsertStudent(Student s);
        int UpdateStudent(Student s);
        int DeleteStudent(int id); 
    }
}
