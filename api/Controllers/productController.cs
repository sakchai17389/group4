using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myApi.Models;

namespace myApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        private static List<Student> students = new List<Student>
        {
            new Student{
                Id = Guid.NewGuid().ToString(),
                Name = "นายแดง",
                price = 5,
                ProfileImage="https://photofleem.com/wp-content/uploads/2018/02/lightroom-reduce-sunlight.jpg"
            },
             new Student{
                Id = Guid.NewGuid().ToString(),
                Name = "นายดำ",
                price = 5,
                ProfileImage="https://photofleem.com/wp-content/uploads/2018/01/lightroom-drop-sun-light.jpg"
            },
             new Student{
                Id = Guid.NewGuid().ToString(),
                Name = "นายส้ม",
                price = 5,
                ProfileImage="https://photofleem.com/wp-content/uploads/2017/12/Feelm-Marry-App.jpg"
            },
        };
        [HttpGet]
        public List<Student> GetAllStudents()
        {
            return students;
        }
        [HttpGet("{id}")]
        public Student GetStudent(string id)
        {
            return students.Find(it => it.Id == id);
        }
        [HttpPost]
        public void CreateStudent([FromBody]Student newStudent)
        {
            newStudent.Id = Guid.NewGuid().ToString();
            students.Add(newStudent);
        }
        [HttpPut]
        public void UpdateStudent([FromBody]Student xxstudent)
        {
            var oldStudent = students.Find(it => it.Id == xxstudent.Id);
            students.Remove(oldStudent);
            students.Add(xxstudent);
        }
        [HttpDelete ("{id}")]
        public void DeleteStudent(string id){
           var student = students.Find(it => it.Id == id);
           students.Remove(student);
           
        }
    }
}
