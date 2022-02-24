﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class clsMap
    {
        #region Attributes
        int id;
        String nick;
        String name;
        int size;
        int communityMap;
        #endregion

        #region Builders

        public clsMap()
        {
            size = 30;
            communityMap = 1;
        }

        public clsMap(int id,String nick,String name,int size,int communityMap)
        {
            this.id = id;
            this.nick = nick;
            this.name = name;
            this.size = size;
            this.communityMap = communityMap;
        }
        #endregion

        #region Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Nick { get => nick; set => nick = value; }
        public string Name { get => name; set => name = value; }
        public int Size { get => size; set => size = value; }
        public int CommunityMap { get => communityMap; set => communityMap = value; }
        #endregion
    }
}
