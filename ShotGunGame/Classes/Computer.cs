using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotGunGame.Classes
{
    public class Computer:OutCome
    {
        public Computer ComputerOne(Computer outCome)
        {
            if (outCome.PcBullets <= 0)
            {
                outCome.Reload(outCome);
            }
            if (outCome.PcBullets == 3)
            {
                outCome.ShotGun(outCome);
            }
            else
            {
                Random rand = new Random();
                int num = rand.Next(1, 4);
                if (num > 1)
                {
                    if (num == 1)
                    {
                        outCome.Shoot(outCome);
                    }
                    else if (num == 2)
                    {
                        outCome.Block(outCome);
                    }
                    else if (num == 3)
                    {
                        outCome.Reload(outCome);
                    }
                }
            }
            return outCome;

        }
    }
}
