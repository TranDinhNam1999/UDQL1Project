using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Security.Cryptography;
using System.Data;

namespace BLL
{
    public class BLL_Users
    {
        DAL_Users dal_user = new DAL_Users();
        public string Hash_Password(string s)
        {
            // sử dụng hỗ trợ hash SHA1 của .NET
            var sha = new SHA1CryptoServiceProvider();
            // vì các thuật toán hash có sẵn làm việc với byte
            // nên cần chuyển sang mảng byte để xử lý
            // sử dụng phương thức chuyển chuỗi sang mảng byte
            // có sẵn trong các lớp Encoding
            var arrBytePw = ASCIIEncoding.ASCII.GetBytes(s);
            // sử dụng thời gian hiện tại là đại lượng salt
            // để có được xác suất khác nhau cao)
            var strTimeNow = DateTime.Now.Millisecond.ToString();
            // ghép salt vào với password
            var arrTimeNow = ASCIIEncoding.ASCII.GetBytes(strTimeNow);
            var arrPwSalt = new byte[arrBytePw.Length + arrTimeNow.Length];
            Array.Copy(arrBytePw, arrPwSalt, arrBytePw.Length);
            Array.Copy(arrTimeNow, 0, arrPwSalt, arrBytePw.Length, arrTimeNow.Length);
            // thực hiện hash
            var arrPWHashed = sha.ComputeHash(arrPwSalt);
            // ghép salt vào kết quả để lưu trữ salt xuống database
            var arrPWSaltHashed = new byte[arrPWHashed.Length + arrTimeNow.Length];
            Array.Copy(arrPWHashed, arrPWSaltHashed, arrPWHashed.Length);
            Array.Copy(arrTimeNow, 0, arrPWSaltHashed, arrPWHashed.Length, arrTimeNow.Length);
            // chuyển đổi mảng byte sang dạng chuỗi HEX để ghi xuống database
            var strPwHashed = BitConverter.ToString(arrPWSaltHashed).Replace("-", "");
            return strPwHashed;
        }
        public string accuracy_password(string s, string pw)
        {
            var sha = new SHA1CryptoServiceProvider();
            var arrBytePw = ASCIIEncoding.ASCII.GetBytes(s);
            // gán giá trị hash length ứng với giải thuật hash đã chọn
            var hashLen = 20;
            // sử dụng để chuyển đổi giá trị HEX đã lưu
            List<char> lHex = new List<char> { '0','1','2','3','4','5',
            '6','7','8','9', 'A', 'B', 'C', 'D', 'E', 'F',};
            // lấy user từ database dựa vào username
            var arrChar = pw.ToCharArray();
            var arrByte = new byte[pw.Length / 2 - hashLen];
            for (int i = hashLen * 2, j = 0; i < arrChar.Length; i += 2)
            {
                arrByte[j++] = (byte)(lHex.IndexOf(arrChar[i]) * 16 + lHex.IndexOf(arrChar[i + 1]));
            }
            // ghép password với salt
            var arrPwSalt = new byte[arrBytePw.Length + arrByte.Length];
            Array.Copy(arrBytePw, arrPwSalt, arrBytePw.Length);
            Array.Copy(arrByte, 0, arrPwSalt, arrBytePw.Length, arrByte.Length);
            // thực hiện với hash
            var arrPwHashed = sha.ComputeHash(arrPwSalt);
            var arrPwSaltHashed = new byte[arrPwHashed.Length + arrByte.Length];
            Array.Copy(arrPwHashed, arrPwSaltHashed, arrPwHashed.Length);
            Array.Copy(arrByte, 0, arrPwSaltHashed, arrPwHashed.Length, arrByte.Length);
            var strPwHashed = BitConverter.ToString(arrPwSaltHashed).Replace("-", "");
            return strPwHashed;
        }
        public void Call_Insert_User(DTO_Users u)
        {
            string hashpassword = Hash_Password(u.F_Password);
            u.F_Password = hashpassword;
            dal_user.Insert_Users_db(u);
        }
        public int Call_Get_ID_User(string s)
        {
            int id = dal_user.Select_id_db(s);
            return id;
        }
        public string Call_Get_Username_User(string s)
        {
            string Urnam = dal_user.Slect_Username_db(s);
            return Urnam;
        }
        public bool Call_Get_accuracy(string s, string pww)
        {
            string temp1 = dal_user.select_Password_db(s);
            string temp2 = accuracy_password(pww, temp1);
            if (temp1 == temp2) return true;
            return false;
        }
        public DataTable Call_Select_user()
        {
            DataTable dt = dal_user.Select_User();
            return dt;
        }
        public void Call_Delete_Users(int id)
        {
            dal_user.Delete_user(id);
        }
        public void Call_Update_password(string password, string name)
        {
            string hashpassword = Hash_Password(password);
            dal_user.Update_Password(hashpassword, name);
        }
    }
}
