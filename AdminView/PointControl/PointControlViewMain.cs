using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminView.PointControl
{
    public class PointControlViewMain
    {
        PointControlView _pointControlView;
        public PointControlViewMain()
        {
            _pointControlView = new PointControlView();
        }
        public PointControlView GetPointControlMainWindow()
        {
            return _pointControlView;
        }
    }
}
