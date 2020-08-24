using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminInteractor.PointControl
{
    public interface DataGateWay
    {
        event Action<bool> ConnectionChanged;
        string GetTeamsInJson();
        int WriteTeamsByJson(string teamArrJson);
        bool IsConnectionOpen();
    }
}
