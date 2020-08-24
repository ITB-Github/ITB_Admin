using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLserverAbstract;

namespace SQLserverConnect
{
    internal class DataAccess:SQLserver
    {
        public DataAccess() : base()
        {

        }

        public string GetTeamsInJson()
        {
            string sqlProc = "GetTeamsInJsonForAdmin";
            return base.getJsonWithProc(sqlProc);
        }

        public int WriteTeamByJson(string teamJson)
        {
            string sqlProc = "WriteTeamsInJsonByAdmin";
            SqlParameter parameter = new SqlParameter("@Team", teamJson);
            return base.writeByJson(sqlProc, parameter);
        }
    }
}
