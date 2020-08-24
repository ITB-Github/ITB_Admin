using AdminInteractor;
using AdminInteractor.PointControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPresenterController.PointControl
{
    internal class Presenter : PresenterBase, OutputBoundary
    {

        PointControlViewModel _pcvm;
        public Presenter(PointControlViewModel pcvm)
        {
            _pcvm = pcvm;
        }
        public void ReceiveConnectionState(ConnectionOutData conn)
        {
            throw new NotImplementedException();
        }

        public void ReceiveTeams(List<TeamOutData> datas)
        {
            throw new NotImplementedException();
        }

        public void UpdateSuccessState(bool state)
        {
            throw new NotImplementedException();
        }
    }
}
