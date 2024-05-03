using System.Data.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using ChuongTrinhQLKS;
namespace ChuongTrinhQLKS.Models
{
    internal static class linqConnect
    {
        public static HotelManagement GetDatabase() => new HotelManagement();
    }
}
