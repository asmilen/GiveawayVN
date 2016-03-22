using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin.Security.Providers.OpenID;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace GiveawayVN
{
    public static class GlobalData
    {
        //static string SteamAPIKey = "E86D715C1DC849AFE8C73B59556E7965";

        public static string myConnectionString = "giveawayvn";
        public static string connectionString = ConfigurationManager.ConnectionStrings["giveawayvn"].ConnectionString;
        public static string steamImageLink = "http://cdn.steamcommunity.com/economy/image/";


        public static string SteamAPIKey = "E86D715C1DC849AFE8C73B59556E7965";
        
        // Get steamID from UserID
        public static Int64 getSteamID(string userID)
        {
            string steamOpenID;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT ProviderKey from aspnetuserlogins where UserID=@ID", con))
                {
                    command.Parameters.AddWithValue("@ID", userID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            steamOpenID = reader.GetString(0);
                            Match match = Regex.Match(steamOpenID, @"http://steamcommunity.com/openid/id/([0-9]+)$");
                            if (match.Success)
                            {
                                return Int64.Parse(match.Groups[1].Value);
                            }
                        }
                    }
                }
            }
            
            return 0;
        }
    }
}
