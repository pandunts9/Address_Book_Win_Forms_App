using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Address_Book_Win_Forms_App
{
    class DataBaseCnn
    {
        public string Connection()
        {
            string cnn = @"Data Source=DESKTOP-QCJQ1A0\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True";
            return cnn;
        }
    }
}
