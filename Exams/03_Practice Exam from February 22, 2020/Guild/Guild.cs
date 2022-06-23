using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public string Name { get; set; }
        public int Capacity { get; set; }

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }

        public int Count => roster.Count;

        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            if (roster.Any(x => x.Name == name))
            {
                Player playerToRemove = roster.Where(x => x.Name == name).First();
                roster.Remove(playerToRemove);
                return true;
            }

            return false;
        }

        public void PromotePlayer(string name)
        {
            if (roster.Any(x => x.Name == name))
            {
                Player playerToPromote = roster.Where(x => x.Name == name).First();
                playerToPromote.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            if (roster.Any(x => x.Name == name))
            {
                Player playerToDemote = roster.Where(x => x.Name == name).First();
                playerToDemote.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string clas)
        {
            Player[] playersToKick = roster.Where(x => x.Class == clas).ToArray();

            for (int i = 0; i < playersToKick.Length; i++)
            {
                roster.Remove(playersToKick[i]);
            }

            return playersToKick;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (Player player in roster)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
