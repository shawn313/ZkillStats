using static ZkillStats.Zkill;
using static ZkillStats.EVE;
// See https://aka.ms/new-console-template for more information

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("How to use!");
Console.WriteLine("Start by going to your character in zkill.");
Console.WriteLine("Look in the url you should see something like this https://zkillboard.com/character/812900457/");
Console.WriteLine("You want the number so it would be 812900457");
Console.WriteLine("Do this for each character");
Console.WriteLine("Now you will need to place a , after each one so if the 2nd character url is https://zkillboard.com/character/944673510/");
Console.WriteLine("the string you willl enter is 812900457,944673510");
Console.WriteLine("Enter your ids:");
string ids = Console.ReadLine();
string[] vs = ids.Split(',');
List<KillStats> List = new List<KillStats>();



foreach (string v in vs)
{
    Root RO = await GetCharStats(v);
    foreach(Group g in RO.groups)
    {
        var existingItem = List.Where(x => x.groupID == g.groupID).FirstOrDefault();

        if (existingItem != null)
        {
            //do something here to check if both rows are same, if not update the row with new values
            existingItem.iskDestroyed = existingItem.iskDestroyed + g.iskDestroyed;
            existingItem.pointsDestroyed = existingItem.pointsDestroyed + g.pointsDestroyed;
            existingItem.shipsDestroyed = existingItem.shipsDestroyed + g.shipsDestroyed;
            existingItem.iskLost = existingItem.iskLost + g.iskLost;
            existingItem.pointsLost = existingItem.pointsLost + g.pointsLost;
            existingItem.shipsLost = existingItem.shipsLost + g.shipsLost;

        }
        else if (existingItem == null)
        {
            List.Add( new KillStats { groupID = g.groupID, iskDestroyed = g.iskDestroyed, iskLost = g.iskLost, pointsDestroyed = g.pointsDestroyed , pointsLost = g.pointsLost , shipsDestroyed = g.shipsDestroyed, shipsLost = g.shipsLost });
        }
    }


};
int totalKills = 0;
int totalLost = 0;
foreach(KillStats killStats in List) 
{
    string name =await GetTypeId(killStats.groupID.ToString());
    Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write(name);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" Kills: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(killStats.shipsDestroyed);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" Lost: ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(killStats.shipsLost.ToString());
    Console.WriteLine();
    totalKills = totalKills + killStats.shipsDestroyed;
    totalLost = totalLost + killStats.shipsLost;
}


Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Total Kills: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(totalKills);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(" Total Lost: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(totalLost);
Console.WriteLine() ;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Your rank is :");

Console.ForegroundColor = ConsoleColor.DarkRed;
string Rank = await GetKdRank(totalKills, totalLost);
Console.Write(Rank+"!");
Console.ReadLine();

