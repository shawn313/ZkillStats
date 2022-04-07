using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ZkillStats
{
    public class Zkill
    {

        public static async Task<Root> GetCharStats(string charId)
        {

            var client = new RestClient(@"https://zkillboard.com/api/stats/characterID");
            var request = new RestRequest(charId+"/", Method.Get);
            var response = await client.ExecuteAsync(request);
        
            string json = response.Content
                .Replace("\"25\":", "")
.Replace("\"26\":", "")
.Replace("\"27\":", "")
.Replace("\"28\":", "")
.Replace("\"29\":", "")
.Replace("\"30\":", "")
.Replace("\"31\":", "")
.Replace("\"237\":", "")
.Replace("\"324\":", "")
.Replace("\"358\":", "")
.Replace("\"361\":", "")
.Replace("\"363\":", "")
.Replace("\"365\":", "")
.Replace("\"404\":", "")
.Replace("\"416\":", "")
.Replace("\"417\":", "")
.Replace("\"419\":", "")
.Replace("\"420\":", "")
.Replace("\"426\":", "")
.Replace("\"430\":", "")
.Replace("\"438\":", "")
.Replace("\"439\":", "")
.Replace("\"440\":", "")
.Replace("\"441\":", "")
.Replace("\"443\":", "")
.Replace("\"444\":", "")
.Replace("\"449\":", "")
.Replace("\"463\":", "")
.Replace("\"471\":", "")
.Replace("\"485\":", "")
.Replace("\"540\":", "")
.Replace("\"541\":", "")
.Replace("\"547\":", "")
.Replace("\"659\":", "")
.Replace("\"830\":", "")
.Replace("\"831\":", "")
.Replace("\"832\":", "")
.Replace("\"833\":", "")
.Replace("\"834\":", "")
.Replace("\"893\":", "")
.Replace("\"894\":", "")
.Replace("\"898\":", "")
.Replace("\"900\":", "")
.Replace("\"906\":", "")
.Replace("\"941\":", "")
.Replace("\"963\":", "")
.Replace("\"1003\":", "")
.Replace("\"1005\":", "")
.Replace("\"1025\":", "")
.Replace("\"1201\":", "")
.Replace("\"1202\":", "")
.Replace("\"1212\":", "")
.Replace("\"1246\":", "")
.Replace("\"1247\":", "")
.Replace("\"1249\":", "")
.Replace("\"1250\":", "")
.Replace("\"1283\":", "")
.Replace("\"1305\":", "")
.Replace("\"1404\":", "")
.Replace("\"1406\":", "")
.Replace("\"1408\":", "")
.Replace("\"1534\":", "")
.Replace("\"1537\":", "")
.Replace("\"1538\":", "")
.Replace("\"1652\":", "")
.Replace("\"1653\":", "")
.Replace("\"1657\":", "")
.Replace("\"1972\":", "")
.Replace("\"2016\":", "")
.Replace("\"4137\":", "")
.Replace("\"707\":", "")
.Replace("\"837\":", "")
.Replace("\"883\":", "")
.Replace("\"1012\":", "")
.Replace("\"1527\":", "")
.Replace("\"101\":", "")
.Replace("\"311\":", "")
.Replace("\"380\":", "")
.Replace("\"397\":", "")
.Replace("\"413\":", "")
.Replace("\"473\":", "")
.Replace("\"513\":", "")
.Replace("\"543\":", "")
.Replace("\"902\":", "")
.Replace("\"1022\":", "")
.Replace("\"1275\":", "")
.Replace("\"1276\":", "")
.Replace("\"1282\":", "")
.Replace("\"2017\":", "")
.Replace("\"1273\":", "")
.Replace("\"4093\":", "")
.Replace("\"4107\":", "")
.Replace("\"839\":", "")
.Replace("\"351064\":", "")
.Replace("\"351210\":", "")
.Replace("\"groups\":{", "\"groups\":[")
.Replace("},\"months\"", "],\"months\"");

            var WorkingData = JsonSerializer.Deserialize<Root>(json);


            return WorkingData;
        }


        public class Datum
        {
            public int kills { get; set; }
            public int characterID { get; set; }
            public int? corporationID { get; set; }
            public int? allianceID { get; set; }
            public int? factionID { get; set; }
            public int? shipTypeID { get; set; }
            public int? solarSystemID { get; set; }
        }

        public class TopAllTime
        {
            public string type { get; set; }
            public List<Datum> data { get; set; }
        }

        public class Group
        {
            public int groupID { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public long iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _200712
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _200801
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _200802
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _200806
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _200807
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _200808
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _200809
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _200810
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _200812
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _200901
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _200903
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _200904
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _200905
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _200906
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _200907
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _200908
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _200909
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _200911
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201001
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201004
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _201009
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201012
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _201101
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _201104
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201110
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _201202
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201203
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public long iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201204
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _201206
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _201209
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _201212
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _201301
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201302
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _201306
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201308
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201309
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201311
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _201403
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _201405
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _201406
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _201407
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201408
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _201601
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201602
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201603
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _201606
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _201809
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _201905
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201912
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
        }

        public class _202005
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _202006
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _202007
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _202010
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _202011
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _202012
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _202101
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _202104
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _202105
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _202106
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _202107
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _202108
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _202111
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _202112
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _200811
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _200912
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201103
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201105
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201402
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201409
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201411
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201512
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _201906
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _201907
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _202001
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _202002
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _202009
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _202201
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class _202203
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
        }

        public class _202204
        {
            public int year { get; set; }
            public int month { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public int iskLost { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public int iskDestroyed { get; set; }
        }

        public class Months
        {
            public _200712 _200712 { get; set; }
            public _200801 _200801 { get; set; }
            public _200802 _200802 { get; set; }
            public _200806 _200806 { get; set; }
            public _200807 _200807 { get; set; }
            public _200808 _200808 { get; set; }
            public _200809 _200809 { get; set; }
            public _200810 _200810 { get; set; }
            public _200812 _200812 { get; set; }
            public _200901 _200901 { get; set; }
            public _200903 _200903 { get; set; }
            public _200904 _200904 { get; set; }
            public _200905 _200905 { get; set; }
            public _200906 _200906 { get; set; }
            public _200907 _200907 { get; set; }
            public _200908 _200908 { get; set; }
            public _200909 _200909 { get; set; }
            public _200911 _200911 { get; set; }
            public _201001 _201001 { get; set; }
            public _201004 _201004 { get; set; }
            public _201009 _201009 { get; set; }
            public _201012 _201012 { get; set; }
            public _201101 _201101 { get; set; }
            public _201104 _201104 { get; set; }
            public _201110 _201110 { get; set; }
            public _201202 _201202 { get; set; }
            public _201203 _201203 { get; set; }
            public _201204 _201204 { get; set; }
            public _201206 _201206 { get; set; }
            public _201209 _201209 { get; set; }
            public _201212 _201212 { get; set; }
            public _201301 _201301 { get; set; }
            public _201302 _201302 { get; set; }
            public _201306 _201306 { get; set; }
            public _201308 _201308 { get; set; }
            public _201309 _201309 { get; set; }
            public _201311 _201311 { get; set; }
            public _201403 _201403 { get; set; }
            public _201405 _201405 { get; set; }
            public _201406 _201406 { get; set; }
            public _201407 _201407 { get; set; }
            public _201408 _201408 { get; set; }
            public _201601 _201601 { get; set; }
            public _201602 _201602 { get; set; }
            public _201603 _201603 { get; set; }
            public _201606 _201606 { get; set; }
            public _201809 _201809 { get; set; }
            public _201905 _201905 { get; set; }
            public _201912 _201912 { get; set; }
            public _202005 _202005 { get; set; }
            public _202006 _202006 { get; set; }
            public _202007 _202007 { get; set; }
            public _202010 _202010 { get; set; }
            public _202011 _202011 { get; set; }
            public _202012 _202012 { get; set; }
            public _202101 _202101 { get; set; }
            public _202104 _202104 { get; set; }
            public _202105 _202105 { get; set; }
            public _202106 _202106 { get; set; }
            public _202107 _202107 { get; set; }
            public _202108 _202108 { get; set; }
            public _202111 _202111 { get; set; }
            public _202112 _202112 { get; set; }
            public _200811 _200811 { get; set; }
            public _200912 _200912 { get; set; }
            public _201103 _201103 { get; set; }
            public _201105 _201105 { get; set; }
            public _201402 _201402 { get; set; }
            public _201409 _201409 { get; set; }
            public _201411 _201411 { get; set; }
            public _201512 _201512 { get; set; }
            public _201906 _201906 { get; set; }
            public _201907 _201907 { get; set; }
            public _202001 _202001 { get; set; }
            public _202002 _202002 { get; set; }
            public _202009 _202009 { get; set; }
            public _202201 _202201 { get; set; }
            public _202203 _202203 { get; set; }
            public _202204 _202204 { get; set; }
        }

        public class Trophies
        {
            public int levels { get; set; }
            public int max { get; set; }
        }

        public class Ships
        {
            public string type { get; set; }
            public int count { get; set; }
        }

        public class Systems
        {
            public string type { get; set; }
            public int count { get; set; }
        }

        public class Regions
        {
            public string type { get; set; }
            public int count { get; set; }
        }

        public class Kills
        {
            public string type { get; set; }
            public int count { get; set; }
        }

        public class Activepvp
        {
            public Ships ships { get; set; }
            public Systems systems { get; set; }
            public Regions regions { get; set; }
            public Kills kills { get; set; }
        }

        public class LastApiUpdate
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Info
        {
            public int id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public LastApiUpdate lastApiUpdate { get; set; }
            public int serverVersion { get; set; }
            public int allianceID { get; set; }
            public int corporationID { get; set; }
            public int factionID { get; set; }
            public int alliance_id { get; set; }
            public DateTime birthday { get; set; }
            public int bloodline_id { get; set; }
            public int corporation_id { get; set; }
            public string gender { get; set; }
            public int race_id { get; set; }
            public double secStatus { get; set; }
            public double security_status { get; set; }
            public string title { get; set; }
        }

        public class Value
        {
            public int kills { get; set; }
            public int characterID { get; set; }
            public string characterName { get; set; }
            public int id { get; set; }
            public object typeID { get; set; }
            public string name { get; set; }
            public int? corporationID { get; set; }
            public string corporationName { get; set; }
            public string cticker { get; set; }
            public int? allianceID { get; set; }
            public string allianceName { get; set; }
            public string aticker { get; set; }
            public int? shipTypeID { get; set; }
            public string shipName { get; set; }
            public int? groupID { get; set; }
            public string groupName { get; set; }
            public int? solarSystemID { get; set; }
            public string solarSystemName { get; set; }
            public int? sunTypeID { get; set; }
            public string solarSystemSecurity { get; set; }
            public string systemColorCode { get; set; }
            public int? constellationID { get; set; }
            public object regionID { get; set; }
            public string constellationName { get; set; }
            public int? locationID { get; set; }
            public object itemName { get; set; }
            public string locationName { get; set; }
        }

        public class TopList
        {
            public string type { get; set; }
            public string title { get; set; }
            public List<Value> values { get; set; }
        }

        public class _0
        {
            public int _16 { get; set; }
        }

        public class _1
        {
            public int _23 { get; set; }
        }

        public class _2
        {
            public int _1 { get; set; }
            public int _3 { get; set; }
        }

        public class _3
        {
            public int _1 { get; set; }
        }

        public class _6
        {
            public int _16 { get; set; }
        }

        public class Activity
        {
            public int max { get; set; }
            public _0 _0 { get; set; }
            public _1 _1 { get; set; }
            public _2 _2 { get; set; }
            public _3 _3 { get; set; }
            public _6 _6 { get; set; }
            public List<string> days { get; set; }
        }

        public class Root
        {
            public string type { get; set; }
            public int id { get; set; }
            public List<TopAllTime> topAllTime { get; set; }
            public int shipsLost { get; set; }
            public int pointsLost { get; set; }
            public long iskLost { get; set; }
            public int attackersLost { get; set; }
            public List<Group> groups { get; set; }
            public Months months { get; set; }
            public int soloLosses { get; set; }
            public int shipsDestroyed { get; set; }
            public int pointsDestroyed { get; set; }
            public long iskDestroyed { get; set; }
            public int attackersDestroyed { get; set; }
            public int soloKills { get; set; }
            public int sequence { get; set; }
            public int epoch { get; set; }
            public int dangerRatio { get; set; }
            public int gangRatio { get; set; }
            public Trophies trophies { get; set; }
            public int allTimeSum { get; set; }
            public int nextTopRecalc { get; set; }
            public List<int> topIskKills { get; set; }
            public Activepvp activepvp { get; set; }
            public Info info { get; set; }
            public List<TopList> topLists { get; set; }
            public List<int> topIskKillIDs { get; set; }
            public Activity activity { get; set; }
        }



    }
}
