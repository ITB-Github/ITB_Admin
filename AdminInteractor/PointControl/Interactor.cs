using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.PointControl;

namespace AdminInteractor.PointControl
{
    internal class Interactor : InteractorBase, InputBoundary
    {
        /// <summary>
        /// Constructor
        /// </summary>
        DataGateWay _iDatagateway;
        OutputBoundary _iOutput;
        public Interactor(DataGateWay gate, OutputBoundary output)
        {
            _iDatagateway = gate;
            _iOutput = output;

            //
            _iDatagateway.ConnectionChanged += _iDatagateway_ConnectionChanged;
        }

        private void _iDatagateway_ConnectionChanged(object sender, EventArgs e)
        {
            if(sender is DataGateWay)
            {
                _GatewayConnected = ((DataGateWay)sender).IsConnectionOpen();
            }
            else
            {
                _GatewayConnected = false;
            }
             
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Property
        /// </summary>
        /// 
        bool _GatewayConnected
        {
            set
            {
                sendConnectionOut(produceConnectionOut(value));
            }
        }
        List<Team> _teams;
        List<Team> _Teams
        {
            get
            {
                return _teams;
            }
            set
            {
                _teams = value;
                sendTeamOutList(produceTeamOutList(_teams));
            }
        }

        Team _TeamSet
        {
            set
            {
                updateTeam(value);
            }
        }
        /// <summary>
        /// Interface
        /// </summary>
        public void ReceiveRequestTeams()
        {
            //throw new NotImplementedException();
            _Teams = produceTeamFromJson(_iDatagateway.GetTeamsInJson());
        }

        public bool UpdateTeam(TeamInData data)
        {
            _TeamSet = findAndSetTeamPoint(data);
            return true;
            //throw new NotImplementedException();
        }
        /// <summary>
        /// private function 
        /// </summary>
        ///
        List<Team> produceTeamFromJson(string json)
        {
            return Utils.Converter.DeserializeJsonToList<Team>(json);
        }

        List<TeamOutData> produceTeamOutList(List<Team> teams)
        {
            var list = new List<TeamOutData>();
            teams.ForEach(x => list.Add(new TeamOutData()
            {
                Id = x.Id,
                TeamName = x.TeamName,
                Point = x.Point,
                PointOnSystem = x.PointOnSystem
            }));
            return list;
        }
        void sendTeamOutList(List<TeamOutData> list)
        {
            _iOutput.ReceiveTeams(list);
        }
        //
        Team findAndSetTeamPoint(TeamInData teamIn)
        {
            var theTeam = (from team in _teams
                          where team.Id == teamIn.Id
                          select team).FirstOrDefault();
            theTeam.Point = teamIn.Point;
            return theTeam;
        }

        void updateTeam(Team team)
        {
            bool state = _iDatagateway.WriteTeamByJson(Utils.Converter.ToJson(team));
            _iOutput.UpdateSuccessState(state);
        }
        //
        ConnectionOutData produceConnectionOut(bool state)
        {
            return new ConnectionOutData() { IsConnected = state };
        }
        void sendConnectionOut(ConnectionOutData conn)
        {
            _iOutput.ReceiveConnectionState(conn);
        }
    }
}
