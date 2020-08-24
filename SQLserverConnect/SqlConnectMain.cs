using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminInteractor.PointControl;

namespace SQLserverConnect
{
    public class SqlConnectMain
    {
        DataMapper _da;
        public SqlConnectMain()
        {
            _da = new DataMapper();
        }
        public AdminInteractor.PointControl.DataGateWay GetDataGateWay()
        {
            return _da as AdminInteractor.PointControl.DataGateWay;
        }
    }
}
