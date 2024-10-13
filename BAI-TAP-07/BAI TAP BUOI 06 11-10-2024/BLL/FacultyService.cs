using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FacultyService
    {
        public List<Faculty> GetFaculty()
        {
            Model1 context = new Model1();
            return context.Faculty.ToList();
        }

        // Chỉ truyền tên khoa
        public void AddOrUpdate(string facultyName)
        {
            using (Model1 context = new Model1())
            {
                // Kiểm tra xem tên Khoa đã tồn tại chưa
                var existingFaculty = context.Faculty.FirstOrDefault(f => f.FacultyName == facultyName);
                if (existingFaculty != null)
                {
                    // Khoa đã tồn tại, có thể thực hiện cập nhật thêm ở đây nếu cần
                     existingFaculty.FacultyName = facultyName; // Tùy trường hợp có thể không cần cập nhật tên
                }
                else
                {
                    // Lấy ID lớn nhất hiện tại và tăng thêm 1
                    int newId = context.Faculty.Any() ? context.Faculty.Max(f => f.FacultyID) + 1 : 1;

                    // Thêm Khoa mới
                    var newFaculty = new Faculty
                    {
                        FacultyID = newId,
                        FacultyName = facultyName
                    };

                    context.Faculty.Add(newFaculty);
                }

                // Lưu thay đổi
                context.SaveChanges();
            }


        }

        public void Delete(string khoa)
        {
            using (Model1 context = new Model1())
            {
                var khoax = context.Faculty.FirstOrDefault(s => s.FacultyName == khoa);
                if (khoax == null)
                {
                    throw new InvalidOperationException("Sinh viên không tồn tại.");
                }

                // Xóa sinh viên khỏi bảng Student
                context.Faculty.Remove(khoax);

                // Lưu thay đổi vào cơ sở dữ liệu
                context.SaveChanges();
            }
        }
    }
}
