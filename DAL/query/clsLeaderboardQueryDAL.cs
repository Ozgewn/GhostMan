﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Text;
using Entities;

namespace DAL.query
{
    public class clsLeaderBoardQueryDAL
    {
        /// <summary>
        ///     <header>public static List<clsLeaderboard> getListOfLeaderboardDAL()</header>
        ///     <description> This method calls the database and returns a list of clsLeaderboard</description>
        ///     <precondition> None </precondition>
        ///     <postcondition> returns List<clsLeaderboard> leaderboards to the BL </postcondition>
        /// </summary>
        /// <returns>returns List<clsLeaderboard> leaderboards</returns>
        public static List<clsLeaderboard> getListOfLeaderboardDAL()
        {
            conecction.clsConnection myConnection = new conecction.clsConnection();
            List<clsLeaderboard> leaderboards = new List<clsLeaderboard>();
            SqlConnection connection = null;
            SqlCommand myCommand = new SqlCommand();
            SqlDataReader myReader = null;
            clsLeaderboard oLeaderboard;

            try
            {
                connection = myConnection.getConnection();
                myCommand.CommandText = "SELECT * FROM GM_Leaderboards";
                myCommand.Connection = connection;
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        oLeaderboard = new clsLeaderboard();
                        oLeaderboard.IdMap = (int)myReader["idMap"];
                        oLeaderboard.Nick = (String)myReader["nick"];
                        oLeaderboard.Score = (String)myReader["score"];
                        leaderboards.Add(oLeaderboard);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                myReader.Close();
                myConnection.closeConnection(ref connection);
            }
            return leaderboards;
        }

        public static List<clsLeaderboard> getMapLeaderboardDAL(int id)
        {
            conecction.clsConnection myConnection = new conecction.clsConnection();
            List<clsLeaderboard> leaderboards = new List<clsLeaderboard>();
            SqlConnection connection = null;
            SqlCommand myCommand = new SqlCommand();
            SqlDataReader myReader = null;
            clsLeaderboard oLeaderboard;

            try
            {
                connection = myConnection.getConnection();
                myCommand.CommandText = "SELECT * FROM GM_Leaderboards WHERE idMap = @id order by score asc";
                myCommand.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                myCommand.Connection = connection;
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        oLeaderboard = new clsLeaderboard();
                        oLeaderboard.IdMap = (int)myReader["idMap"];
                        oLeaderboard.Nick = (String)myReader["nick"];
                        oLeaderboard.Score = (String)myReader["score"];
                        leaderboards.Add(oLeaderboard);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                myConnection.closeConnection(ref connection);
            }
            return leaderboards;
        }

        public static List<clsLeaderboard> getAllLeaderboardDAL()
        {
            conecction.clsConnection myConnection = new conecction.clsConnection();
            List<clsLeaderboard> leaderboards = new List<clsLeaderboard>();
            SqlConnection connection = null;
            SqlCommand myCommand = new SqlCommand();
            SqlDataReader myReader = null;
            clsLeaderboard oLeaderboard;

            try
            {
                connection = myConnection.getConnection();
                myCommand.CommandText = "SELECT * FROM GM_Leaderboards order by score asc";
                myCommand.Connection = connection;
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        oLeaderboard = new clsLeaderboard();
                        oLeaderboard.IdMap = (int)myReader["idMap"];
                        oLeaderboard.Nick = (string)myReader["nick"];
                        oLeaderboard.Score = (string)myReader["score"];
                        leaderboards.Add(oLeaderboard);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                myConnection.closeConnection(ref connection);
            }
            return leaderboards;
        }
    }
}
