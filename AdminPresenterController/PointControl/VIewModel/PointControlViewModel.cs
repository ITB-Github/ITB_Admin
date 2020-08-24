using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPresenterController.PointControl
{
    public class PointControlViewModel: ViewModelBase
    {
        IControllerPointControl _iCtrl;
        internal void AttachController(IControllerPointControl iCtrl)
        {
            _iCtrl = iCtrl;
        }

        ObservableCollection<TeamViewModel> _TeamViewModels;
        public ObservableCollection<TeamViewModel> TeamViewModels
        {
            get => _TeamViewModels;
            set
            {
                _TeamViewModels = value;
                RaisePropertyChanged("TeamViewModels");
            }
        }

        bool _IsConnected;
        public bool IsConnected
        {
            get => _IsConnected;
            set
            {
                _IsConnected = value;
                RaisePropertyChanged("IsConnected");
            }
        }

        public  PointControlViewModel()
        {
            TeamViewModels = new ObservableCollection<TeamViewModel>();
            TeamViewModels.Add(new TeamViewModel());
        }

        public void GetTeams()
        {
            //throw new NotImplementedException();
            if(_iCtrl!=null)
            {
                _iCtrl.GetTeams();
            }
        }
    }
}
