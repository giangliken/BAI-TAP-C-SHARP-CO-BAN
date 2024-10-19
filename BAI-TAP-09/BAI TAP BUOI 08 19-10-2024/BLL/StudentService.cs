using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Database;

namespace BLL
{
    public class StudentService
    {
        private Model1 dbContext;

        public StudentService()
        {
            dbContext = new Model1();
        }

        // Hàm thêm sinh viên
        public void AddStudent(int studentID, string fullName, int age, string major)
        {
            try
            {
                // Kiểm tra xem sinh viên đã tồn tại chưa
                if (dbContext.Student.Any(s => s.StudentID == studentID))
                {
                    throw new Exception("Sinh viên đã tồn tại.");
                }

                // Tạo sinh viên mới
                var newStudent = new Student
                {
                    StudentID = studentID,
                    FullName = fullName,
                    Age = age,
                    Major = major
                };

                // Thêm sinh viên vào DbSet và lưu thay đổi
                dbContext.Student.Add(newStudent);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm sinh viên: " + ex.Message);
            }
        }

        // Hàm cập nhật sinh viên trong BLL sử dụng Entity Framework
        public void UpdateStudent(int studentID, string fullName, int age, string major)
        {
            try
            {
                // Tìm sinh viên theo StudentID
                var student = dbContext.Student.Find(studentID);

                if (student != null)
                {
                    // Cập nhật thông tin sinh viên
                    student.FullName = fullName;
                    student.Age = age;
                    student.Major = major;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Sinh viên không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật sinh viên: " + ex.Message);
            }
        }


        // Hàm xóa sinh viên
        public void DeleteStudent(int studentID)
        {
            try
            {
                // Tìm sinh viên theo StudentID
                var student = dbContext.Student.Find(studentID);

                if (student != null)
                {
                    // Xóa sinh viên và lưu thay đổi
                    dbContext.Student.Remove(student);
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Sinh viên không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa sinh viên: " + ex.Message);
            }
        }

        // Hàm lấy danh sách sinh viên
        public List<Student> GetAllStudents()
        {
            try
            {
                // Trả về danh sách tất cả sinh viên
                return dbContext.Student.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu sinh viên: " + ex.Message);
            }
        }
    }
}
