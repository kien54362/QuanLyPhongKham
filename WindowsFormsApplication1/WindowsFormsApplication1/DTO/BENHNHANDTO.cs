using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DTO;
using WindowsFormsApplication1.DAO;

namespace WindowsFormsApplication1.DTO
{
    class BENHNHANDTO
    {
        private string _mabn;
        private string _hoten;
        private string _namsinh;
        private string _diachi;
        private string _chuandoan;
        private string _sdt;
        private string _bscd;
        private string _ngayxn; 
        
        public string mabn
        {
            get { return _mabn; }
            set { _mabn = value; }
        }

        public string hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }

        public string namsinh
        {
            get { return _namsinh; }
            set { _namsinh = value; }
        }

        public string diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        public string chuandoan
        {
            get { return _chuandoan; }
            set { _chuandoan = value; }
        }
        public string bscd
        {
            get { return _bscd; }
            set { _bscd= value; }
        }
        public string ngayxn
        {
            get { return _ngayxn; }
            set { _ngayxn = value; }
        }
        public string sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        public BENHNHANDTO()
        {
            _mabn = "";
            _hoten = "";
            _diachi = "";
            _namsinh = "";
            _chuandoan = "";
            _sdt = "";
            _bscd = "";
            _ngayxn = "";
             
        }
        public BENHNHANDTO(string MaBN,string Hoten,string Diachi,string Namsinh,string Chuandoan, string BSCD,string NgayXN,string Dienthoai)
        {
            _mabn = MaBN;
            _hoten = Hoten;
            _diachi = Diachi;
            _namsinh = Namsinh;
            _chuandoan = Chuandoan;
            _sdt = Dienthoai;
            _bscd = BSCD;
            _ngayxn = NgayXN;
        }
    }

}
