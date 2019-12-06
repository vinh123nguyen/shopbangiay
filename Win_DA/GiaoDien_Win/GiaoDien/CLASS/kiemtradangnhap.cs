using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien.CLASS
{
    public class kiemtradangnhap
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        public bool kiemtrataikhoan(String tendn, String mk)
        {
            int kttk = (from nd in db.QUANLYNDs
                        where nd.TENDN == tendn && nd.MK == mk && nd.HOATDONG == true
                        select new { nd }).Count();
            if (kttk == 1)
                return true;
            else
                return false;
        }
        public bool kiemtraquyentruycap(String tendn, String mamh)
        {
            int ktquyen = (from s in db.QLNDNHOMNDs
                         join c in db.QLPHANQUYENs on s.MANHOM equals c.MANHOM
                         where c.MAMANHINH==mamh && s.TENDN==tendn
                         select new
                         {
                             c
                         }).Count();
            if (ktquyen != 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
