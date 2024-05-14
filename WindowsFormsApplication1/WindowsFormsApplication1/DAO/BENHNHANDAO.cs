using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.DAO
{
    class BENHNHANDAO
    {
        public static DataTable TTBenhnhan()
        {
            string sql = "Select*from Benhnhan";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }
        public static DataTable TTXetnghiem()
        {
            string sql = "select * from xetnghiem";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }
        public static DataTable TTKQ()
        {
            string sql = "select * from ketqua";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }
        public static DataTable TTBNLN()
        {
            string sql = "select MAX(MaBN) from BenhNhan";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }

        public static DataTable TTBNLN2(int mabn)
        {
            string sql = "select * from BenhNhan where MaBN='"+mabn+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }

        public static DataTable TTBNNN()
        {
            string sql = "select MIN(MaBN) from BenhNhan";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }

        public static DataTable TTBNNN2(int mabn)
        {
            string sql = "select * from BenhNhan where MaBN='" + mabn + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }
        public static DataTable TTGiatien(int mabn)
        {
            string sql = "SELECT SUM(GiaTien) FROM  Ketqua k,Xetnghiem x where MaBN='"+mabn+"' and k.MaXN=x.MaXN";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }
        public static DataTable MaBn_LN()
        {
            string sql = "select top 1 mabn from BenhNhan order by mabn desc ";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }
        public static void ThemNV(BENHNHANDTO bn)
        {
            string sql = "insert into BenhNhan(MaBN,Hoten,Namsinh,Diachi,Dienthoai,Chuandoan,BSCD,NgayXN) values ('"+bn.mabn+"',N'"+bn.hoten+"', "+bn.namsinh+",N'"+bn.diachi+"','"+bn.sdt+"',N'"+bn.chuandoan+"',N'"+bn.bscd+"','"+bn.ngayxn+"')";
            //return sql;
            
           KNCSDL.thucthitruyvan(sql);
        }
        public static DataTable TTBSCD()
        {
            string sql = "select DISTINCT BSCD from BenhNhan";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }
    }
}
