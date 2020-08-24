using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        TeamViewModel _TeamChosen;
        public TeamViewModel TeamChosen
        {
            get
            {
                return _TeamChosen;
            }
            set
            {
                _TeamChosen = value;
                RaisePropertyChanged("TeamChosen");
            }
        }

        Visibility _UpdateStateVisibility;
        public Visibility UpdateStateVisibility
        {
            get
            {
                return _UpdateStateVisibility;
            }
            set
            {
                _UpdateStateVisibility = value;
                RaisePropertyChanged("UpdateStateVisibility");
            }
        }

        public  PointControlViewModel()
        {
            TeamViewModels = new ObservableCollection<TeamViewModel>();
            TeamViewModels.Add(new TeamViewModel());

            UpdateStateVisibility = Visibility.Collapsed;
        }

        public void GetTeams()
        {
            //throw new NotImplementedException();
            if(_iCtrl!=null)
            {
                _iCtrl.GetTeams();
            }
        }

        public void SetPoint(TeamViewModel team)
        {
            if (team == null)
                return;
            UpdateStateVisibility = Visibility.Collapsed;
            _iCtrl.SetPoint(team.Id, team.PointSet);
        }
    }
}
