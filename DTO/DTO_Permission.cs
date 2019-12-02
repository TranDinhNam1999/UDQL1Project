using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Permission
    {
        private string username;
        private string add;
        private string del;
        private string insert;
        private string DanhMuc;
        private string HeThong;
        private string ChungNang;
        private string TroGiup;

        public string Add { get => add; set => add = value; }
        public string Del { get => del; set => del = value; }
        public string Insert { get => insert; set => insert = value; }
        public string RW_DanhMuc { get => DanhMuc; set => DanhMuc = value; }
        public string RW_HeThong { get => HeThong; set => HeThong = value; }
        public string RW_ChungNang { get => ChungNang; set => ChungNang = value; }
        public string RW_TroGiup { get => TroGiup; set => TroGiup = value; }
        public string Username { get => username; set => username = value; }

        public DTO_Permission()
        {
            username = "";
            add = "Flase";
            del = "Flase";
            insert = "Flase";
            RW_ChungNang = "Flase";
            RW_DanhMuc = "Flase";
            RW_HeThong = "Flase";
            RW_TroGiup = "Flase";
        }
    }
}
