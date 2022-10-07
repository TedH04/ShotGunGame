using ShotGunGame.Classes;
namespace ShotGunGame
{
    public partial class Form1 : Form
    {
        OutCome playerOne = new OutCome();
        OutCome Computer = new OutCome();
        public Form1()
        {
            InitializeComponent();
        }

        public void TextUpdate()
        {
            txtPlayerBullets.Text = playerOne.Bullets.ToString();
            txtPlayerMove.Text = playerOne.move.ToString();
            txtComputerBullets.Text = Computer.PcBullets.ToString();
            txtComputerMove.Text = Computer.move.ToString();
            
        }
        private void btnShoot_Click(object sender, EventArgs e)
        {
            if (playerOne.Bullets > 0)
            {
                playerOne.Shoot(playerOne);
                Computer.Computer(Computer);
                CheckWin();
                TextUpdate();
            }
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            playerOne.Block(playerOne);
            Computer.Computer(Computer);
            CheckWin();
            TextUpdate();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            playerOne.Reload(playerOne);
            Computer.Computer(Computer);
            CheckWin();
            TextUpdate();
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            if(playerOne.Bullets > 2 || Computer.PcBullets > 2)
            {
                TextUpdate();
                playerOne.ShotGun(playerOne);
                Computer.Computer(Computer);
                CheckWin();
            }
        }
        private void CheckWin()
        {
            bool win = false;
            win = OutCome.win(playerOne, Computer);
            if(win == true)
            {
                MessageBox.Show("Du vann!");
                this.Close();
            }
        }
    }
}