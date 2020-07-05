using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class CarRacingGameForm : Form
    {
        static Random random = new Random();
        List<Control> brokenLines;
        List<Control> enemyCars;
        List<Control> coins;
        int gameSpeed, maxSpeed, minSpeed;
        int carDisplacement;
        int playerPoint;
        public CarRacingGameForm()
        {
            InitializeComponent();
            Init();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Move(gameSpeed);
        }


        private void Move(int speed)
        {
            int x, y = 0;
           foreach(var c in brokenLines)
            {
                if(c.Top >= 540)
                {
                    c.Top = 0;
                }
                else
                {
                    c.Top += speed - random.Next(gameSpeed);
                }
            }

           foreach(var c in enemyCars)
            {
                if(c.Top >= 540)
                {
                    x = random.Next(SolidLineLeft.Right, SolidLineRight.Left-c.Width);
                    c.Location = new Point(x, y);
                }
                else
                {
                    c.Top += gameSpeed - random.Next(gameSpeed);
                }

                if(c.Bounds.IntersectsWith(PlayerCar.Bounds))
                {
                    GameOver();
                }
            }

           foreach(var c in coins)
            {
                if(c.Top >= 540)
                {
                    x = random.Next(SolidLineLeft.Right, SolidLineRight.Left - c.Width);
                    c.Location = new Point(x, y);
                }
                else
                {
                    c.Top += random.Next(minSpeed, maxSpeed);
                }

                if(c.Bounds.IntersectsWith(PlayerCar.Bounds))
                {
                    playerPoint++;
                    labelPlayerPoint.Text = playerPoint.ToString();
                    x = random.Next(SolidLineLeft.Right, SolidLineRight.Left - c.Width);
                    c.Location = new Point(x, y);
                }
            }

        }

        /// <summary>
        /// Initialization variables
        /// </summary>
        private void Init()
        {
            labelGameOver.Visible = false;
            brokenLines = new List<Control>();
            enemyCars = new List<Control>();
            coins = new List<Control>();
            foreach(Control c in Controls)
            {
                if(c.Tag == "BrokenLine")
                {
                    brokenLines.Add(c);
                }
                if(c.Tag == "EnemyCar")
                {
                    enemyCars.Add(c);
                }
                if(c.Tag == "Coin")
                {
                    coins.Add(c);
                }
            }

            gameSpeed = 8;
            maxSpeed = 14;
            minSpeed = 3;
            carDisplacement = 15;
            playerPoint = 0;
            labelPlayerPoint.Text = playerPoint.ToString();
        }

        /// <summary>
        /// Player control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarRacingGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if (PlayerCar.Left - carDisplacement >= SolidLineLeft.Right)
                    PlayerCar.Left += -carDisplacement;
            }
            if(e.KeyCode == Keys.Right)
            {
                if (PlayerCar.Right + carDisplacement <= SolidLineRight.Left)
                    PlayerCar.Left += carDisplacement;
            }
            if(e.KeyCode == Keys.Up)
            {
                if(gameSpeed < maxSpeed)
                {
                    gameSpeed++;
                }
            }
            if(e.KeyCode == Keys.Down)
            {
                if(gameSpeed > minSpeed)
                {
                    gameSpeed--;
                }    
            }

            if(e.KeyCode == Keys.Space && timer1.Enabled == false)
            {
                RestartGame();
            }
        }

        private void RestartGame()
        {
            int x, y = 0;
            
            foreach(var c in enemyCars)
            {
                x = random.Next(SolidLineLeft.Right, SolidLineRight.Left - c.Width);
                c.Location = new Point(x, y);
            }

            foreach(var c in coins)
            {
                x = random.Next(SolidLineLeft.Right, SolidLineRight.Left - c.Width);
                c.Location = new Point(x, y);
            }

            playerPoint = 0;
            labelGameOver.Visible = false;
            timer1.Enabled = true;
        }

        private void GameOver()
        {
            timer1.Enabled = false;
            labelGameOver.Visible = true;
        }

    }
}
