using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;

namespace Register.ds
{
    public class Conexion
    {
        public static OrmLiteConnectionFactory SetConexion()
        {
            return new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
        }
    }
}
