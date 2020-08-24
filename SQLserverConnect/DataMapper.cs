using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminInteractor.PointControl;

namespace SQLserverConnect
{
    internal class DataMapper: DataGateWay
    {
        DataAccess _da;
        public DataMapper()
        {
            _da = new DataAccess(ConnectionChanged);
        }

        public event Action<bool> ConnectionChanged;

        public string GetTeamsInJson()
        {
            return _da.GetTeamsInJson();
            //throw new NotImplementedException();
        }

        public bool IsConnectionOpen()
        {
            return _da.IsConnectionOpen;
            //throw new NotImplementedException();
        }

        public bool WriteTeamByJson(string teamJson)
        {
            return _da.WriteTeamByJson(teamJson);
            //throw new NotImplementedException();
        }
    }
}
