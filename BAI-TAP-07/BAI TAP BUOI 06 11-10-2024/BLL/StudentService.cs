using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BLL
{
    public class StudentService
    {
        public List<StudentViewModel> GetAll()
        {
            using (Model1 context = new Model1())
            {
                var students = from student in context.Student
                               join major in context.Major on new { student.FacultyID, student.MajorID }
                               equals new { FacultyID = major.FacultyID, MajorID = major.MajorID }
                               join faculty in context.Faculty on major.FacultyID equals faculty.FacultyID
                               select new StudentViewModel
                               {
                                   StudentID = student.StudentID,
                                   FullName = student.FullName,
                                   FacultyName = faculty.FacultyName,
                                   AverageScore = student.AverageScore,
                                   MajorName = major.Name
                               };

                return students.ToList();
            }
        }

        public List<StudentViewModel> LayDanhSachSinhVienChuaDKCN()
        {
            using (Model1 context = new Model1())
            {
                var students = from student in context.Student
                               join major in context.Major on new { student.FacultyID, student.MajorID }
                               equals new { FacultyID = major.FacultyID, MajorID = major.MajorID }
                               join faculty in context.Faculty on major.FacultyID equals faculty.FacultyID
                               where faculty.FacultyName == "None"
                               select new StudentViewModel
                               {
                                   StudentID = student.StudentID,
                                   FullName = student.FullName,
                                   FacultyName = faculty.FacultyName,
                                   AverageScore = student.AverageScore,
                                   MajorName = major.Name
                               };

                return students.ToList();
            }
        }







        public void AddOrUpdate(Student student)
        {
            using (Model1 context = new Model1())
            {
                var existingStudent = context.Student.FirstOrDefault(s => s.StudentID == student.StudentID);
                if (existingStudent != null)
                {
                    // Cập nhật thông tin sinh viên đã tồn tại
                    existingStudent.FullName = student.FullName;
                    existingStudent.AverageScore = student.AverageScore;
                    existingStudent.MajorID = student.MajorID;
                    existingStudent.FacultyID = student.FacultyID;
                }
                else
                {
                    // Thêm sinh viên mới vào bảng Student
                    context.Student.Add(student);
                }

                context.SaveChanges();
            }
        }




        public void Delete(string studentId)
        {
            using (Model1 context = new Model1())
            {
                // Tìm sinh viên theo MSSV
                var student = context.Student.FirstOrDefault(s => s.StudentID == studentId);
                if (student == null)
                {
                    throw new InvalidOperationException("Sinh viên không tồn tại.");
                }

                // Xóa sinh viên khỏi bảng Student
                context.Student.Remove(student);

                // Lưu thay đổi vào cơ sở dữ liệu
                context.SaveChanges();
            }
        }




        public List<Student> GetAllHasNoMajor()
        {
            Model1 context = new Model1();
            return context.Student.Where(p => p.MajorID == null).ToList();
        }
        public List<Student> GetAllHasNoMajor(int facultyID)
        {
            Model1 context = new Model1();
            return context.Student.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
        }
        public Student FindById(string studentId)
        {
            Model1 context = new Model1();
            return context.Student.FirstOrDefault(p => p.StudentID == studentId);
        }


    }

    public class StudentViewModel
    {
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public string FacultyName { get; set; }
        public double AverageScore { get; set; }
        public string MajorName { get; set; }
    }

}
