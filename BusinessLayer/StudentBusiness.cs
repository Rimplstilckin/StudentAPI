using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentBusiness : IStudentBusiness
    {
        private readonly IStudentRepository studentRepository;

        public StudentBusiness(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public List<Student> GetAllStudents()
        {
            return this.studentRepository.GetAllStudents();
        }
    }
}
