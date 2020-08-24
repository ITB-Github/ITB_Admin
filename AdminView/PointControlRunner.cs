using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AdminInteractor.PointControl;
using AdminPresenterController.PointControl;

namespace AdminView
{
    public class PointControlRunner
    {
        InteractorMain interactorMain;
        AdminPresenterController.PointControl.PresenterControllerMain presenterControllerMain;
        PointControl.PointControlViewMain viewMain;
        public PointControlRunner()
        {
            viewMain = new PointControl.PointControlViewMain();
            presenterControllerMain = new PresenterControllerMain(viewMain.GetPointControlViewModel());
        }
        public void AttachService(ServiceBuilder service)
        {
            if (interactorMain != null)
                return;
            interactorMain = new InteractorMain(service.GetPointControlDataGateway(),
                presenterControllerMain.GetOutputBoundary());

            presenterControllerMain.AttachInput(interactorMain.GetInputBoundary());
        }

        public Window Run()
        {
            return viewMain.GetPointControlMainWindow();
        }
    }
}
