using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPresenterController.PointControl
{
    interface IControllerPointControl
    {
        void GetTeams();
        void SetPoint(string teamId, int point);
    }
}
