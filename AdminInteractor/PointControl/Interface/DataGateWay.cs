using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminInteractor.PointControl
{
    public interface DataGateWay
    {
        event EventHandler ConnectionChanged;
        string GetTeamsInJson();
        bool WriteTeamByJson(string teamJson);
        bool IsConnectionOpen();
    }
}
