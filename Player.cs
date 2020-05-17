﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGame
{
    class Player
    {
        public bool goUp, goDown, goLeft, goRight;
        private PictureBox player_img;
        public int playerVel;

        public Player(PictureBox img)
        {
            this.player_img = img;
        }

        public void move_player() // this method allow the useer to move the player. also it does not allaw the player to go over the screen
        {
            int player_x = player_img.Left;
            int player_y = player_img.Top;
            if (goUp == true && player_img.Top >= 10)
            {
                player_img.Top -= playerVel;
                Console.WriteLine("{0} , {1}", player_x, player_y);
            }

            if (goDown == true && player_img.Top <= 700)
            {
                player_img.Top += playerVel;
                Console.WriteLine("{0} , {1}", player_x, player_y);
            }

            if (goRight == true && player_img.Left < 730)
            {
                player_img.Left += playerVel;
                Console.WriteLine("{0} , {1}", player_x, player_y);
            }

            if (goLeft == true && player_img.Left > 0)
            {
                player_img.Left -= playerVel;
                Console.WriteLine("{0} , {1}", player_x, player_y);
            }
        }
        public bool is_player_TopLeft()
        {
            if (player_img.Top < 400 && player_img.Left < 400)
            {
                return true;
            }
            return false;
        }
        public bool is_player_TopRight()
        {
            if (player_img.Top < 400 && player_img.Left > 400)
            {
                return true;
            }
            return false;
        }
        public bool is_player_BottomLeft()
        {
            if (player_img.Top >= 400 && player_img.Left <= 400)
            {
                return true;
            }
            return false;
        }
        public bool is_player_BottomRight()
        {
            if (player_img.Top >= 400 && player_img.Left > 400)
            {
                return true;
            }
            return false;
        }


    }
}
