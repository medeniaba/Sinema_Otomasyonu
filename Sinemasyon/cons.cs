using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemasyon
{
    internal class cons
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=MYCOMPUTER ;Initial Catalog=SinemasyonDB;Integrated Security=True");
    }
}
