using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoCircleGame.Business.Service
{
    public interface IGameService
    {
        int CalculateGameWinner(int size);

        List<int> GetPlayerList(int size);
    }
}
