using AdminInteractor.PointControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPresenterController.PointControl
{
    public class PresenterControllerMain
    {
        Presenter _presenter;
        Controller _controller;
        public PresenterControllerMain(PointControlViewModel pcvm)
        {
            _presenter = new Presenter(pcvm);
            _controller = new Controller();

            pcvm.AttachController(_controller);
        }

        public OutputBoundary GetOutputBoundary()
        {
            return _presenter as OutputBoundary;
        }

        public void AttachInput(InputBoundary input)
        {
            _controller.AttachInput(input);
        }
    }
}
