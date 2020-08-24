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
        public DataAccess(Action<bool> connectedChanged) : base(connectedChanged)
        {

        }

        public string GetTeamsInJson()
        {
            string sqlProc = "GetTeamsInJsonForAdmin";
            return base.getJsonWithProc(sqlProc);
        }

        public int WriteTeamsByJson(string teamArrJson)
        {
            string sqlProc = "WriteTeamsInJsonByAdmin";
            SqlParameter parameter = new SqlParameter("@Teams", teamArrJson);
            return base.writeByJson(sqlProc, parameter);
        }
    }
}
