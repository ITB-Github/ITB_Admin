using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminInteractor.PointControl
{
    public class InteractorMain
    {
        Interactor _interactor;
        public InteractorMain(DataGateWay iData, OutputBoundary output)
        {
            _interactor = new Interactor(iData, output);
        }
        public InputBoundary GetInputBoundary()
        {
            return _interactor;
        }
    }
}
