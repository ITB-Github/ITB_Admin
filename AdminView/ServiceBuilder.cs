using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLserverConnect;
namespace AdminView
{
    public class ServiceBuilder
    {
        SqlConnectMain sqlMain;
        public ServiceBuilder()
        {
            sqlMain = new SqlConnectMain();
        }
        public AdminInteractor.PointControl.DataGateWay GetPointControlDataGateway()
        {
            return sqlMain.GetPointControlDataGateWay();
        }
    }
}
