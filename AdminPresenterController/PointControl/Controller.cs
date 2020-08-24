using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminInteractor.PointControl;

namespace AdminPresenterController.PointControl
{
    internal class Controller : ControllerBase, IControllerPointControl
    {
        InputBoundary _iInput;
        public void AttachInput(InputBoundary input)
        {
            _iInput = input;
        }
        
        public void GetTeams()
        {
            if (_iInput == null)
                return;
            _iInput.ReceiveRequestTeams();
            //throw new NotImplementedException();
        }

        public void SetPoint(string teamId, int point)
        {

            _iInput.UpdateTeam(new TeamInData() { Id = teamId, TeamName = null, Point = point });
            //throw new NotImplementedException();
        }
    }
}
