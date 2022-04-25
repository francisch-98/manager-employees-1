using Register.ds.Interface;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.ds.Class
{
    public class datospersonal 
    {
        public List<datos.datospersonal> ListarPersonal() 
        {
            var conexion = Conexion.SetConexion();
            var db = conexion.OpenDbConnection();
            db.Open();
            var listapersonal = db.Select<datos.datospersonal>();
            return listapersonal;


        }

    }
}
