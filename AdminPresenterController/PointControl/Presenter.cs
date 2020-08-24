using AdminInteractor;
using AdminInteractor.PointControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
       

        public void ReceiveTeams(List<TeamOutData> datas)
        {
            //throw new NotImplementedException();
            _pcvm.TeamViewModels = new System.Collections.ObjectModel.ObservableCollection<TeamViewModel>();
            datas.ForEach(x => _pcvm.TeamViewModels.Add(new TeamViewModel()
            {
                Id = x.Id,
                TeamName = x.TeamName,
                Point = x.PointOnSystem,
                PointSet = x.Point
            }));
        }

        public void ReceiveConnectionState(ConnectionOutData conn)
        {
            _pcvm.IsConnected = conn.IsConnected;
        }

        public void UpdateSuccessState(bool state)
        {
            //throw new NotImplementedException();
           if(state)
           {
                _pcvm.UpdateStateVisibility = System.Windows.Visibility.Visible;
           }
        }
    }
}
