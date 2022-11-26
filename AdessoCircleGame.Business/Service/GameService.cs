using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoCircleGame.Business.Service
{
    public class GameService : IGameService
    {
        public int CalculateGameWinner(int size)
        {
            int index = 0;
            var playerList = GetPlayerList(size);


            while (playerList.Count != 1)
            {              
                index++;
                index %= playerList.Count;
                playerList.RemoveAt(index);

            }

            return playerList[0];

        }

        public List<int> GetPlayerList(int size)
        {
            var playerList = new List<int>(size);
            for (int i = 1; i <= size; i++)
            {
                playerList.Add(i);
            }
            return playerList;
        }
    }
}
