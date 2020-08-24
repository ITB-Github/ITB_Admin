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
            throw new NotImplementedException();
        }

        public bool IsConnectionOpen()
        {
            throw new NotImplementedException();
        }

        public int WriteTeamsByJson(string teamArrJson)
        {
            throw new NotImplementedException();
        }
    }
}
