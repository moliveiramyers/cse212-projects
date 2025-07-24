/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();
        var playerIdSet = new HashSet<string>();

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        while (!reader.EndOfData)
        {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            playerIdSet.Add(playerId);
            var points = int.Parse(fields[8]);

            if (players.ContainsKey(playerId))
            {
                players[playerId] += points;
            }
            else
            {
                players[playerId] = points;
            }


            // Console.WriteLine($"Players: {{{string.Join(", ", players)}}}");


        }

        var highestScore = players.ToArray();
        Array.Sort(highestScore, (lowest, highest) => highest.Value.CompareTo(lowest.Value));

        var topPlayers = new List<KeyValuePair<string, int>>();
        for (int i = 0; i < 10; i++)
        {
            topPlayers.Add(highestScore[i]);
        }

        foreach (var player in topPlayers)
        {
            Console.WriteLine($"{player.Key}: {player.Value}");
        }

    }
}