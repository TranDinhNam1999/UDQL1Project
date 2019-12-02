using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Users
    {
        private int f_ID;
        private string f_Username;
        private string f_Password;
        private string f_Name;
        private string f_Email;
        private DateTime f_DOB;

        public int F_ID { get => f_ID; set => f_ID = value; }
        public string F_Username { get => f_Username; set => f_Username = value; }
        public string F_Password { get => f_Password; set => f_Password = value; }
        public string F_Name { get => f_Name; set => f_Name = value; }
        public string F_Email { get => f_Email; set => f_Email = value; }
        public DateTime F_DOB { get => f_DOB; set => f_DOB = value; }

        public DTO_Users()
        {
            f_Username = "Namhandsome";
            f_Password = "123456";
            f_Name = "TranDinhNam";
            f_Email = "namhandsomefap@gmail.com";
            f_DOB = DateTime.Parse("06/27/1999");
        }
    }
}
