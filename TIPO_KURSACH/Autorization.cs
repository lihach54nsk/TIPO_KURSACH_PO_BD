using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIPO_KURSACH
{
    class Autorization
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Геральт из Ривии\Desktop\TIPO_KURSACH\TIPO_KURSACH\Database1.mdf;Integrated Security=True";

        public static string GetConnectionString() => connectionString;
    }    
}