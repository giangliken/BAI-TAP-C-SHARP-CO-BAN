using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MajorService
    {
        public class MajorDTO
        {
            public string FacultyName { get; set; }
            public string MajorID { get; set; }
            public string MajorName { get; set; }
        }

        public List<MajorDTO> GetAllMajorsWithFaculty()
        {
            using (Model1 context = new Model1())
            {
                var majors = from major in context.Major
                             join faculty in context.Faculty on major.FacultyID equals faculty.FacultyID
                             select new MajorDTO
                             {
                                 FacultyName = faculty.FacultyName,
                                 MajorID = major.MajorID,
                                 MajorName = major.Name
                             };

                return majors.ToList();
            }
        }

        public List<Major> GetAll()
        {
            using (Model1 context = new Model1())
            {
                return context.Major.ToList();
            }
        }


        // Lấy Mã khoa dựa vào tên chuyên ngành
        public int? GetFacultyIDByMajorName(string majorName)
        {
            using (Model1 context = new Model1())
            {
                // Tìm chuyên ngành dựa vào tên chuyên ngành
                var major = context.Major.FirstOrDefault(m => m.Name.Equals(majorName, StringComparison.OrdinalIgnoreCase));
                if (major != null)
                {
                    // Nếu tìm thấy, trả về FacultyID
                    return major.FacultyID; // Trả về FacultyID nếu tìm thấy
                }
                return null; // Trả về null nếu không tìm thấy chuyên ngành
            }
        }

        public bool AddMajor(int facultyID, string majorName)
        {
            using (Model1 context = new Model1())
            {
                // Tạo đối tượng Major mới
                var newMajor = new Major
                {
                    FacultyID = facultyID,
                    MajorID = GenerateNewMajorID(), // Có thể cần logic để sinh ID tự động
                    Name = majorName
                };

                context.Major.Add(newMajor);
                return context.SaveChanges() > 0; // Lưu và trả về kết quả thành công
            }
        }

        // Logic để sinh MajorID (tùy vào yêu cầu của bạn, có thể điều chỉnh)
        private string GenerateNewMajorID()
        {
            Random random = new Random();
            // Sinh một số ngẫu nhiên từ 0 đến 9 và chuyển nó thành chuỗi
            return random.Next(0, 10).ToString();
        }


        public bool DeleteMajorByName(string majorName)
        {
            using (Model1 context = new Model1())
            {
                // Tìm chuyên ngành dựa trên tên
                var majorToDelete = context.Major.FirstOrDefault(m => m.Name.Equals(majorName, StringComparison.OrdinalIgnoreCase));
                if (majorToDelete != null)
                {
                    context.Major.Remove(majorToDelete); // Xóa chuyên ngành
                    return context.SaveChanges() > 0; // Lưu thay đổi và trả về kết quả thành công
                }
                return false; // Trả về false nếu không tìm thấy chuyên ngành để xóa
            }
        }

    }


}


