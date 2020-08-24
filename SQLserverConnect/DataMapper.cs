using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AdminInteractor.PointControl;
using System.Timers;

namespace SQLserverConnect
{
    internal class DataMapper: DataGateWay
    {
        private int checkInMiliSecond = 3000;
        DataAccess _da;
        public DataMapper()
        {
            _da = new DataAccess();
            //
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = checkInMiliSecond;
            timer.Start();
            timer.Elapsed += Timer_Elapsed;
            
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            OnConnectionChanged(EventArgs.Empty);
        }

        private void OnConnectionChanged(EventArgs e)
        {
            ConnectionChanged?.Invoke((DataGateWay)this, e);
        }

        public event EventHandler ConnectionChanged;

        public string GetTeamsInJson()
        {
            return _da.GetTeamsInJson();
            //throw new NotImplementedException();
        }

        public bool IsConnectionOpen()
        {
            return _da.IsConnectionOpen;
            //throw new NotImplementedException();
        }

        public bool WriteTeamByJson(string teamJson)
        {
            return _da.WriteTeamByJson(teamJson) >0 ? true: false;
            //throw new NotImplementedException();
        }
    }
}
