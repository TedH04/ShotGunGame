using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotGunGame.Classes
{
    public class OutCome
    {
        public int Bullets { get; set; }
        public int PcBullets { get; set; }
        public Move move { get; set; }
        public enum Move
        {
            Shoot,
            Block,
            Reload,
            Shotgun,
        }


        public OutCome Shoot(OutCome outCome)
        {
            if(Bullets < 1)
            {
                MessageBox.Show("Du har inte tillräckligt med skott");
            }
            else
            {
                outCome.Bullets--;
                outCome.PcBullets--;
                outCome.move = Move.Shoot;
            }
            return outCome;
        }

        public OutCome Block(OutCome outCome)
        {
            outCome.move = Move.Block;
            return outCome;
        }
        public OutCome Reload(OutCome outCome)
        {
            outCome.PcBullets++;
            outCome.Bullets++;
            outCome.move = Move.Reload;
            return outCome;
        }
        public OutCome ShotGun(OutCome outCome)
        {
            outCome.Bullets -= 3;
            outCome.PcBullets -= 3;
            outCome.move = Move.Shotgun;
            return outCome;
        }
        
        public static bool win(OutCome playerOne, Computer Computer)
        {
            if(playerOne.move == Move.Shoot && Computer.move == Move.Block)
            {
                MessageBox.Show("Datorn blockade ditt skott");
            }
            if(playerOne.move == Move.Shoot && Computer.move != Move.Block)
            {
                MessageBox.Show("Du Vann!!");
                Application.Exit();
            }
            if(Computer.move == Move.Shoot && playerOne.move != Move.Block)
            {
                MessageBox.Show("Du förlorade! :(");
                Application.Exit();
            }
            if(Computer.move == Move.Shoot && playerOne.move == Move.Block)
            {
                MessageBox.Show("Bullet Dodged! Nice job!");
            }
            if(Computer.move == Move.Shotgun)
            {
                MessageBox.Show("Du blev Shotgunned down FÖRLUST");
                Application.Exit();
            }
            if(playerOne.move == Move.Shotgun)
            {
                MessageBox.Show("Du Shotgunned down datorn VINST");
                Application.Exit();
            }

            return false;
        }
    }
}
