using System.Linq;

namespace ChuongTrinhQLKS.Models
{
    public class Check
    {
        public static bool CheckAccess(string nameForm, string username)
        {
            using (HotelManagement db = linqConnect.GetDatabase())
            {
                var check = (from u in db.STAFFs
                             join i in db.Accesses on u.IDStaffType equals i.IDStaffType
                             join j in db.Jobs on i.IDJob equals j.ID
                             where u.UserName == username && j.NameForm == nameForm
                             select j).FirstOrDefault();
                return check != null;
            }
        }
    }
}
