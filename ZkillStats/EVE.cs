using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ZkillStats
{
    public class EVE
    {
        public static async Task<String> GetTypeId(string TypeId)
        {

            var client = new RestClient(@"https://esi.evetech.net/latest/universe/groups/");
            var request = new RestRequest(TypeId + "/?datasource=tranquility&language=en", Method.Get);
            var response = await client.ExecuteAsync(request);
            var WorkingData = JsonSerializer.Deserialize<EVERootobject>(response.Content);

            return WorkingData.name;
        }



        public static async Task<String> GetKdRank(int kills , int lost) 
        {
            decimal rank = kills/lost;
            if(rank < 1)
            {
                return "Iron";
            }else if(rank < 2)
            {
                return "Bronze";
            }
            else if (rank < 3)
            {
                return "Silver";
            }
            else if (rank < 4)
            {
                return "Gold";
            }
            else if (rank < 5)
            {
                return "Platinum";
            }
            else if (rank < 6)
            {
                return "Diamond";
            }
            else if (rank < 7)
            {
                return "Master";
            }
            else if (rank > 7)
            {
                return "Grandmaster";
            }
            return "God Like";
        }


        public class KillStats
        {
            public int groupID { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public long iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }

        };

        public class EVERootobject
        {
            public int category_id { get; set; }
            public int group_id { get; set; }
            public string name { get; set; }
            public bool published { get; set; }
            public int[] types { get; set; }
        }


    }
}
