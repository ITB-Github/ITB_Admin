using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminInteractor.PointControl
{
    public interface OutputBoundary
    {
        void ReceiveTeams(List<TeamOutData> datas);
       
        void ReceiveConnectionState(ConnectionOutData conn);
        void UpdateSuccessState(bool state);
    }
}
