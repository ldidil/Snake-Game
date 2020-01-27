using SnakeGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form2 : Form
    {
        public static string nickname;
        public static int speed;
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (hardButton.Checked) {
                    speed = 20;
            }
            else if (mediumButton.Checked)
            {
                    speed = 15;
              
            }
            else if(easyButton.Checked){
                speed = 8;
            }

            if (nicknamebox.TextLength > 0) {
                nickname = nicknamebox.Text;
                var f1 = new Form1();
                
                f1.ShowDialog();
                Close();
            }
            else {
                MessageBox.Show("Check your Nickname", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
