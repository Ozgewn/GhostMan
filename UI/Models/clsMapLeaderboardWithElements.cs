﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace UI.Models
{
    public class clsMapLeaderboardWithElements : clsMap
    {
        #region Attributes
        List<clsLeaderboard> leaderboards;
        List<clsElementMap> elementList;
        #endregion
        #region Builders
        public clsMapLeaderboardWithElements() : base()
        {

        }

        public clsMapLeaderboardWithElements(clsMap map, List<clsLeaderboard> leaderboards) : base(map.Id, map.Nick, map.Name, map.Size, map.CommunityMap)
        {
            this.leaderboards = leaderboards;
        }
        public clsMapLeaderboardWithElements(clsMap map, List<clsLeaderboard> leaderboards, List<clsElementMap> elementList) : base(map.Id, map.Nick, map.Name, map.Size, map.CommunityMap)
        {
            this.leaderboards = leaderboards;
            this.elementList = elementList;
        }
        #endregion
        #region Getters & Setters
        public List<clsLeaderboard> Leaderboards { get => leaderboards; set => leaderboards = value; }
        public List<clsElementMap> ElementList { get => elementList; set => elementList = value; }
        #endregion
    }
}
