using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQStok
{
    public static class Connection
    {
        public static string ConnectionString { get; } = "Server=EMREHALIM\\SQLEXPRESS;Database=SQStok;Trusted_Connection=True;";
    }
}
